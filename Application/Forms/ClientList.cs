using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using App.Infrastructure.Context;
using Microsoft.EntityFrameworkCore;
using System.Drawing.Drawing2D;
using System.Text;
using System.Threading.Tasks;
using App.Domain.Entities;
using System.Windows.Forms;

namespace Application.Forms
{
    public partial class formClientList : Form
    {
        private readonly BindingList<DamageReports> _reports = new();
        private readonly BindingList<DamageReports> _filteredReports = new();
        private static bool _databaseInitialized;
        private string? _statusFilter;

        public formClientList()
        {
            InitializeComponent();
            _reports.ListChanged += (_, __) => UpdateClientCount();
        }

        private void formClientList_Load(object sender, EventArgs e)
        {
            dataGridViewClientList.AutoGenerateColumns = false;
            dataGridViewClientList.Columns.Clear();
            dataGridViewClientList.Columns.AddRange(Column1, Column2, Column3, Column4, ColumnMoreInfo);
            damageReportsBindingSource.DataSource = _filteredReports;
            dataGridViewClientList.DataSource = damageReportsBindingSource;
            LoadReports();
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            if (sender is not Panel panel)
            {
                return;
            }

            var bounds = panel.ClientRectangle;
            bounds.Inflate(-1, -1);

            using var path = CreateRoundedRectanglePath(bounds, 12);
            panel.Region = new Region(path);
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
            using var borderPen = new Pen(Color.FromArgb(64, 63, 110));
            e.Graphics.DrawPath(borderPen, path);
        }

        private static GraphicsPath CreateRoundedRectanglePath(Rectangle bounds, int radius)
        {
            var path = new GraphicsPath();
            var diameter = radius * 2;

            path.AddArc(bounds.X, bounds.Y, diameter, diameter, 180, 90);
            path.AddArc(bounds.Right - diameter, bounds.Y, diameter, diameter, 270, 90);
            path.AddArc(bounds.Right - diameter, bounds.Bottom - diameter, diameter, diameter, 0, 90);
            path.AddArc(bounds.X, bounds.Bottom - diameter, diameter, diameter, 90, 90);
            path.CloseFigure();
            return path;
        }

        private void searchBoxClientList_TextChanged(object sender, EventArgs e)
        {
            var filterText = searchBoxClientList.Text.Trim();
            ApplyFilter(filterText);
        }

        private void ApplyFilter(string filterText)
        {
            var normalizedFilter = filterText?.Trim() ?? string.Empty;

            damageReportsBindingSource.RaiseListChangedEvents = false;
            _filteredReports.Clear();

            foreach (var report in _reports)
            {
                var matchesName = string.IsNullOrWhiteSpace(normalizedFilter) ||
                    report.ClientName?.Contains(normalizedFilter, StringComparison.OrdinalIgnoreCase) == true;
                var matchesStatus = string.IsNullOrWhiteSpace(_statusFilter) ||
                    string.Equals(report.Status, _statusFilter, StringComparison.OrdinalIgnoreCase);

                if (matchesName && matchesStatus)
                {
                    _filteredReports.Add(report);
                }
            }

            damageReportsBindingSource.RaiseListChangedEvents = true;
            damageReportsBindingSource.ResetBindings(false);
        }

        private void SetStatusFilter(string? status)
        {
            _statusFilter = status;
            ApplyFilter(searchBoxClientList.Text);
        }

        private void UpdateClientCount()
        {
            labelTotalClients.Text = _reports.Count.ToString();
        }

        private void LoadReports()
        {
            try
            {
                using var dbContext = CreateDbContext();
                var reports = dbContext.DamageReports
                    .AsNoTracking()
                    .OrderBy(report => report.Id)
                    .ToList();

                _reports.Clear();
                foreach (var report in reports)
                {
                    _reports.Add(report);
                }

                ApplyFilter(searchBoxClientList.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Failed to load clients: {ex.Message}", "Load Clients", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void iconAddClient_Click(object sender, EventArgs e)
        {
            using var addClientForm = new formAddingClient();
            if (addClientForm.ShowDialog(this) == DialogResult.OK && addClientForm.CreatedReport is not null)
            {
                try
                {
                    using var dbContext = CreateDbContext();
                    dbContext.DamageReports.Add(addClientForm.CreatedReport);
                    dbContext.SaveChanges();

                    _reports.Add(addClientForm.CreatedReport);
                    ApplyFilter(searchBoxClientList.Text);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Failed to save client: {ex.Message}", "Add Client", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
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

        private void dataGridViewClientList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex != dataGridViewClientList.Columns["ColumnMoreInfo"].Index)
            {
                return;
            }

            if (dataGridViewClientList.Rows[e.RowIndex].DataBoundItem is not DamageReports report)
            {
                return;
            }

            using var moreInfoForm = new MoreInfo(report, damageReportsBindingSource, _reports);
            moreInfoForm.ShowDialog(this);
        }

        private void labelSortByOnHold_Click(object sender, EventArgs e)
        {
            SetStatusFilter("On-hold");
        }

        private void labelSortByInProgress_Click(object sender, EventArgs e)
        {
            SetStatusFilter("In-progress");
        }

        private void labelSortByCompleted_Click(object sender, EventArgs e)
        {
            SetStatusFilter("Completed");
        }

        private void labelSortByAll_Click(object sender, EventArgs e)
        {
            SetStatusFilter(null);
        }
    }
}
