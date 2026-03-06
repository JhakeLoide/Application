using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using App.Domain.Entities;
using App.Infrastructure.Context;
using Microsoft.EntityFrameworkCore;

namespace Application.Forms
{
    public partial class Reports : Form
    {
        private readonly BindingList<DamageReports> _reports = new();
        private readonly BindingList<DamageReports> _filteredReports = new();
        private readonly BindingSource _bindingSource = new();
        private static bool _databaseInitialized;

        public Reports()
        {
            InitializeComponent();
            Load += Reports_Load;
            Resize += Reports_Resize;
            txtSearch.TextChanged += (_, _) => ApplyFilter();
            cmbStatus.SelectedIndexChanged += (_, _) => ApplyFilter();
            dtpFrom.ValueChanged += (_, _) => ApplyFilter();
            dtpTo.ValueChanged += (_, _) => ApplyFilter();
        }

        private async void Reports_Load(object? sender, EventArgs e)
        {
            dgvCompleted.AutoGenerateColumns = true;
            _bindingSource.DataSource = _filteredReports;
            dgvCompleted.DataSource = _bindingSource;

            if (cmbStatus.Items.Count > 0 && cmbStatus.SelectedIndex < 0)
            {
                cmbStatus.SelectedIndex = 0;
            }

            await LoadReportsAsync();
            AdjustCompletedColumns();
        }

        private void Reports_Resize(object? sender, EventArgs e)
        {
            AdjustCompletedColumns();
        }

        private async Task LoadReportsAsync()
        {
            try
            {
                var reports = await Task.Run(() =>
                {
                    using var dbContext = CreateDbContext();
                    return dbContext.DamageReports
                        .AsNoTracking()
                        .Where(report => report.Status == "Completed")
                        .OrderBy(report => report.Id)
                        .ToList();
                });

                _reports.Clear();
                foreach (var report in reports)
                {
                    _reports.Add(report);
                }

                ApplyFilter();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Failed to load completed clients: {ex.Message}", "Reports", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ApplyFilter()
        {
            var searchText = txtSearch.Text.Trim();
            var selectedStatus = cmbStatus.SelectedItem?.ToString();
            var fromDate = dtpFrom.Value.Date;
            var toDate = dtpTo.Value.Date;

            _bindingSource.RaiseListChangedEvents = false;
            _filteredReports.Clear();

            foreach (var report in _reports)
            {
                if (!string.IsNullOrWhiteSpace(selectedStatus) &&
                    !string.Equals(report.Status, selectedStatus, StringComparison.OrdinalIgnoreCase))
                {
                    continue;
                }

                if (!string.IsNullOrWhiteSpace(searchText) &&
                    !(report.ClientName?.Contains(searchText, StringComparison.OrdinalIgnoreCase) == true))
                {
                    continue;
                }

                var completionDate = (report.UpdatedOn ?? report.DateReceived).Date;
                if (completionDate < fromDate || completionDate > toDate)
                {
                    continue;
                }

                _filteredReports.Add(report);
            }

            _bindingSource.RaiseListChangedEvents = true;
            _bindingSource.ResetBindings(false);
            UpdateSummary();
        }

        private void UpdateSummary()
        {
            var now = DateTime.Today;
            var totalCompleted = _filteredReports.Count;
            var completedThisMonth = _filteredReports.Count(report =>
                (report.UpdatedOn ?? report.DateReceived).Month == now.Month &&
                (report.UpdatedOn ?? report.DateReceived).Year == now.Year);

            var durations = _filteredReports
                .Select(report => (report.UpdatedOn ?? report.DateReceived).Date - report.DateReceived.Date)
                .Where(duration => duration.TotalDays >= 0)
                .Select(duration => duration.TotalDays)
                .ToList();

            var avgDays = durations.Count > 0 ? durations.Average() : 0;

            lblTotal.Text = $"Total Completed: {totalCompleted}";
            lblThisMonth.Text = $"This Month: {completedThisMonth}";
            lblAvgTime.Text = $"Avg Completion: {avgDays:0} days";
        }

        private void AdjustCompletedColumns()
        {
            if (WindowState != FormWindowState.Maximized)
            {
                return;
            }

            dgvCompleted.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvCompleted.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
        }

        private static AppDbContext CreateDbContext()
        {
            var options = new DbContextOptionsBuilder<AppDbContext>().Options;
            var dbContext = new AppDbContext(options);

            if (!_databaseInitialized)
            {
                dbContext.Database.Migrate();
                _databaseInitialized = true;
            }

            return dbContext;
        }
    }
}
