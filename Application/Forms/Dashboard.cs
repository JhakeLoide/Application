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
        }

        private void formDashboard_Load(object sender, EventArgs e)
        {
            LoadSummary();
        }

        private void LoadSummary()
        {
            try
            {
                using var dbContext = CreateDbContext();
                var reports = dbContext.DamageReports.AsNoTracking();
                var today = DateTime.Today;

                labelTotalClient.Text = reports.Count().ToString();
                labelNewToday.Text = reports.Count(report => report.DateReceived >= today && report.DateReceived < today.AddDays(1)).ToString();
                labelInProgress.Text = reports.Count(report => report.Status == "In-progress").ToString();
                labelCompleted.Text = reports.Count(report => report.Status == "Completed").ToString();
                labelOnHold.Text = reports.Count(report => report.Status == "On-hold").ToString();
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
    }
}
