using System;
using System.Linq;
using System.Windows.Forms;
using App.Infrastructure.Context;
using Microsoft.EntityFrameworkCore;

namespace Application.Forms
{
    public partial class formDashboard : Form
    {
        private static bool _databaseInitialized;

        public formDashboard()
        {
            InitializeComponent();
            Load += formDashboard_Load;
            Resize += (_, __) => UpdateSummaryLabelWidths();
            tableLayoutPanel1.Layout += (_, __) => UpdateSummaryLabelWidths();
            ConfigureSummaryLabel(label11);
            ConfigureSummaryLabel(label12);
            ConfigureSummaryLabel(label13);
            ConfigureSummaryLabel(label14);
            ConfigureSummaryLabel(label15);
        }

        private async void formDashboard_Load(object sender, EventArgs e)
        {
            await LoadSummaryAsync();
            UpdateSummaryLabelWidths();
        }

        private void UpdateSummaryLabelWidths()
        {
            UpdateSummaryLabelBounds(label11, panelTotalClients);
            UpdateSummaryLabelBounds(label12, panelNewToday);
            UpdateSummaryLabelBounds(label13, panelInProgress);
            UpdateSummaryLabelBounds(label14, panelCompleted);
            UpdateSummaryLabelBounds(label15, panel2);
        }

        private static void ConfigureSummaryLabel(Label label)
        {
            label.AutoSize = false;
            label.TextAlign = ContentAlignment.TopLeft;
        }

        private static void UpdateSummaryLabelBounds(Label label, Control panel)
        {
            if (panel.ClientSize.Width <= 0 || panel.ClientSize.Height <= 0)
            {
                return;
            }

            var width = Math.Max(0, panel.ClientSize.Width - label.Left - 22);
            var height = Math.Max(0, panel.ClientSize.Height - label.Top - 12);

            label.Size = new Size(width, height);
        }

        private async Task LoadSummaryAsync()
        {
            try
            {
                var summary = await Task.Run(() =>
                {
                    using var dbContext = CreateDbContext();
                    var reports = dbContext.DamageReports.AsNoTracking();
                    var today = DateTime.Today;

                    return new
                    {
                        Total = reports.Count(),
                        NewToday = reports.Count(report => report.DateReceived >= today && report.DateReceived < today.AddDays(1)),
                        InProgress = reports.Count(report => report.Status == "In-progress"),
                        Completed = reports.Count(report => report.Status == "Completed"),
                        OnHold = reports.Count(report => report.Status == "On-hold")
                    };
                });

                labelTotalClient.Text = summary.Total.ToString();
                labelNewToday.Text = summary.NewToday.ToString();
                labelInProgress.Text = summary.InProgress.ToString();
                labelCompleted.Text = summary.Completed.ToString();
                labelOnHold.Text = summary.OnHold.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Failed to load dashboard summary: {ex.Message}", "Dashboard", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void label14_Click(object sender, EventArgs e)
        {

        }
    }
}
