using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using App.Infrastructure.Context;
using Microsoft.EntityFrameworkCore;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using App.Domain.Entities;

namespace Application.Forms
{
    public partial class MoreInfo : Form
    {
        private readonly DamageReports? _report;
        private readonly BindingSource? _bindingSource;
        private readonly BindingList<DamageReports>? _masterList;
        private bool _hasChanges;
        private static bool _databaseInitialized;

        public MoreInfo()
        {
            InitializeComponent();
        }

        public MoreInfo(DamageReports report, BindingSource? bindingSource = null, BindingList<DamageReports>? masterList = null)
        {
            InitializeComponent();
            _report = report;
            _bindingSource = bindingSource;
            _masterList = masterList;
            txtClientName.Text = report.ClientName;
            txtOperatingSystem.Text = report.OperatingSystem;
            txtDeviceModel.Text = string.IsNullOrWhiteSpace(report.DeviceModel) ? "N/A" : report.DeviceModel;
            txtIssueSummary.Text = report.DamageSummary;
            txtAdditionalInfo.Text = string.IsNullOrWhiteSpace(report.AdditionalInfo) ? "N/A" : report.AdditionalInfo;
            labelDateReceived.Text = report.DateReceived == default
                ? string.Empty
                : report.DateReceived.ToString("MMMM dd, yyyy");
            HookChangeTracking();
        }

        private void HookChangeTracking()
        {
            txtClientName.TextChanged += MarkAsChanged;
            txtOperatingSystem.TextChanged += MarkAsChanged;
            txtDeviceModel.TextChanged += MarkAsChanged;
            txtIssueSummary.TextChanged += MarkAsChanged;
            txtAdditionalInfo.TextChanged += MarkAsChanged;
        }

        private void MarkAsChanged(object? sender, EventArgs e)
        {
            _hasChanges = true;
        }

        private void iconButtonUpdate_Click(object sender, EventArgs e)
        {
            if (_report is null)
            {
                return;
            }

            if (string.IsNullOrWhiteSpace(txtClientName.Text))
            {
                MessageBox.Show("Client name is required.", "Update Client", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(txtOperatingSystem.Text))
            {
                MessageBox.Show("Operating system is required.", "Update Client", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(txtDeviceModel.Text))
            {
                MessageBox.Show("Device model is required.", "Update Client", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(txtIssueSummary.Text))
            {
                MessageBox.Show("Issue summary is required.", "Update Client", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            _report.ClientName = txtClientName.Text.Trim();
            _report.OperatingSystem = txtOperatingSystem.Text.Trim();
            _report.DeviceModel = txtDeviceModel.Text.Trim();
            _report.DamageSummary = txtIssueSummary.Text.Trim();
            _report.AdditionalInfo = txtAdditionalInfo.Text.Trim();

            try
            {
                using var dbContext = CreateDbContext();
                dbContext.DamageReports.Update(_report);
                dbContext.SaveChanges();

                _bindingSource?.ResetBindings(false);
                _hasChanges = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Failed to update client: {ex.Message}", "Update Client", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void iconButtonDelete_Click(object sender, EventArgs e)
        {
            var confirmDelete = MessageBox.Show(
                "Are you sure you want to delete this information?",
                "Delete Information",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (confirmDelete != DialogResult.Yes)
            {
                return;
            }

            if (_report is not null)
            {
                try
                {
                    using var dbContext = CreateDbContext();
                    dbContext.DamageReports.Remove(_report);
                    dbContext.SaveChanges();

                    _masterList?.Remove(_report);
                    _bindingSource?.Remove(_report);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Failed to delete client: {ex.Message}", "Delete Client", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }

            DialogResult = DialogResult.OK;
            Close();
        }

        private void iconButtonCancel_Click(object sender, EventArgs e)
        {
            if (_hasChanges)
            {
                var result = MessageBox.Show(
                    "Are you sure you want to cancel some changes?",
                    "Cancel Changes",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning);

                if (result != DialogResult.Yes)
                {
                    return;
                }
            }

            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void picDeviceImage_Click(object sender, EventArgs e)
        {

        }

        private void btnUploadImage_Click(object sender, EventArgs e)
        {

            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Title = "Select Device Image";
                openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp";


                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    picDeviceImage.Image = Image.FromFile(openFileDialog.FileName);
                    _hasChanges = true;
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
    }
}

