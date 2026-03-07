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
        private bool _initialized;

        public Reports()
        {
            InitializeComponent();
            Load += Reports_Load;
            Resize += Reports_Resize;
            dgvCompleted.CellContentClick += DgvCompleted_CellContentClick;
            dgvCompleted.CellFormatting += DgvCompleted_CellFormatting;
            txtSearch.TextChanged += (_, _) => ApplyFilter();
            cmbStatus.SelectedIndexChanged += (_, _) => ApplyFilter();
            dtpFrom.ValueChanged += (_, _) => ApplyFilter();
            dtpTo.ValueChanged += (_, _) => ApplyFilter();
        }

        private async void Reports_Load(object? sender, EventArgs e)
        {
            await InitializeAsync();
        }

        public async Task InitializeAsync()
        {
            if (_initialized)
            {
                return;
            }

            dgvCompleted.AutoGenerateColumns = false;
            ConfigureCompletedGrid();
            _bindingSource.DataSource = _filteredReports;
            dgvCompleted.DataSource = _bindingSource;

            if (cmbStatus.Items.Count > 0 && cmbStatus.SelectedIndex < 0)
            {
                cmbStatus.SelectedIndex = 0;
            }

            await LoadReportsAsync();
            AdjustCompletedColumns();
            _initialized = true;
        }

        private void Reports_Resize(object? sender, EventArgs e)
        {
            AdjustCompletedColumns();
        }

        private void ConfigureCompletedGrid()
        {
            dgvCompleted.Columns.Clear();
            dgvCompleted.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            dgvCompleted.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "ColumnId",
                HeaderText = "ID",
                DataPropertyName = "Id",
                ReadOnly = true,
                FillWeight = 10
            });

            dgvCompleted.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "ColumnClientName",
                HeaderText = "Client Name",
                DataPropertyName = "ClientName",
                ReadOnly = true,
                FillWeight = 22
            });

            dgvCompleted.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "ColumnOperatingSystem",
                HeaderText = "Operating System",
                DataPropertyName = "OperatingSystem",
                ReadOnly = true,
                FillWeight = 18
            });

            dgvCompleted.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "ColumnDeviceModel",
                HeaderText = "Device Model",
                DataPropertyName = "DeviceModel",
                ReadOnly = true,
                FillWeight = 18
            });

            dgvCompleted.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "ColumnCompletedOn",
                HeaderText = "Completed On",
                DataPropertyName = "UpdatedOn",
                ReadOnly = true,
                FillWeight = 22
            });

            var moreInfoStyle = new DataGridViewCellStyle
            {
                BackColor = Color.FromArgb(88, 86, 147),
                ForeColor = Color.White,
                SelectionBackColor = Color.FromArgb(99, 102, 241),
                SelectionForeColor = Color.White,
                Alignment = DataGridViewContentAlignment.MiddleCenter,
                Padding = new Padding(6, 2, 6, 2)
            };

            dgvCompleted.Columns.Add(new DataGridViewButtonColumn
            {
                Name = "ColumnMoreInfo",
                HeaderText = string.Empty,
                Text = "More Info",
                UseColumnTextForButtonValue = true,
                FlatStyle = FlatStyle.Flat,
                DefaultCellStyle = moreInfoStyle,
                FillWeight = 10
            });
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
            dgvCompleted.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void DgvCompleted_CellFormatting(object? sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0)
            {
                return;
            }

            if (dgvCompleted.Columns[e.ColumnIndex].Name != "ColumnCompletedOn")
            {
                return;
            }

            if (dgvCompleted.Rows[e.RowIndex].DataBoundItem is not DamageReports report)
            {
                return;
            }

            var completedOn = report.UpdatedOn ?? report.DateReceived;
            e.Value = completedOn.ToString("MMMM dd, yyyy hh:mm tt");
            e.FormattingApplied = true;
        }

        private void DgvCompleted_CellContentClick(object? sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex != dgvCompleted.Columns["ColumnMoreInfo"].Index)
            {
                return;
            }

            if (dgvCompleted.Rows[e.RowIndex].DataBoundItem is not DamageReports report)
            {
                return;
            }

            using var reportsInfoForm = new ReportsInfo(report, _bindingSource, _reports);
            reportsInfoForm.ShowDialog(this);
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
