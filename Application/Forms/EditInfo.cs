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
    public partial class EditInfo : Form
    {
        private readonly DamageReports? _report;
        private readonly BindingSource? _bindingSource;
        private readonly BindingList<DamageReports>? _masterList;
        private readonly List<byte[]> _deviceImages = new();
        private int _currentImageIndex;
        private bool _hasChanges;
        private static bool _databaseInitialized;

        public EditInfo()
        {
            InitializeComponent();
        }

        public EditInfo(DamageReports report, BindingSource? bindingSource = null, BindingList<DamageReports>? masterList = null)
        {
            InitializeComponent();
            _report = report;
            _bindingSource = bindingSource;
            _masterList = masterList;
            txtClientName.Text = report.ClientName;
            if (cmbBoxEditInfoOS.Items.Contains(report.OperatingSystem))
            {
                cmbBoxEditInfoOS.SelectedItem = report.OperatingSystem;
            }
            else
            {
                cmbBoxEditInfoOS.SelectedIndex = -1;
            }
            txtDeviceModel.Text = string.IsNullOrWhiteSpace(report.DeviceModel) ? "N/A" : report.DeviceModel;
            txtIssueSummary.Text = report.DamageSummary;
            txtAdditionalInfo.Text = string.IsNullOrWhiteSpace(report.AdditionalInfo) ? "N/A" : report.AdditionalInfo;
            labelDateReceived.Text = report.DateReceived == default
                ? string.Empty
                : report.DateReceived.ToString("MMMM dd, yyyy");
            labelUpdatedOn.Text = report.UpdatedOn is null
                ? string.Empty
                : report.UpdatedOn.Value.ToString("MMMM dd, yyyy hh:mm tt");
            LoadDeviceImage();
            LoadStatuses();
            HookChangeTracking();
            var toolTip = new ToolTip();
            toolTip.SetToolTip(picDeviceImage, "Click for a full view.");
        }

        private void HookChangeTracking()
        {
            txtClientName.TextChanged += MarkAsChanged;
            cmbBoxEditInfoOS.SelectedIndexChanged += MarkAsChanged;
            txtDeviceModel.TextChanged += MarkAsChanged;
            txtIssueSummary.TextChanged += MarkAsChanged;
            txtAdditionalInfo.TextChanged += MarkAsChanged;
            comboBoxStatus.SelectedIndexChanged += MarkAsChanged;
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

            if (!_hasChanges)
            {
                return;
            }

            if (string.IsNullOrWhiteSpace(txtClientName.Text))
            {
                MessageBox.Show("Client name is required.", "Update Client", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (cmbBoxEditInfoOS.SelectedIndex < 0)
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

            if (string.IsNullOrWhiteSpace(comboBoxStatus.Text))
            {
                MessageBox.Show("Status is required.", "Update Client", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var isCompletedStatus = string.Equals(comboBoxStatus.Text.Trim(), "Completed", StringComparison.OrdinalIgnoreCase);
            if (isCompletedStatus)
            {
                var confirmStatusUpdate = MessageBox.Show(
                    "Are you sure you want to update this status to \"Completed\"?",
                    "Update Status",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning);

                if (confirmStatusUpdate != DialogResult.Yes)
                {
                    return;
                }
            }

            _report.ClientName = txtClientName.Text.Trim();
            _report.OperatingSystem = cmbBoxEditInfoOS.Text.Trim();
            _report.DeviceModel = txtDeviceModel.Text.Trim();
            _report.DamageSummary = txtIssueSummary.Text.Trim();
            _report.AdditionalInfo = txtAdditionalInfo.Text.Trim();
            _report.Status = comboBoxStatus.Text.Trim();
            _report.UpdatedOn = DateTime.Now;

            try
            {
                using var dbContext = CreateDbContext();
                dbContext.DamageReports.Update(_report);
                dbContext.SaveChanges();
                _bindingSource?.ResetBindings(false);
                _hasChanges = false;
                labelUpdatedOn.Text = _report.UpdatedOn.Value.ToString("MMMM dd, yyyy hh:mm tt");
                MessageBox.Show("Info Updated", "Update Client", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (isCompletedStatus)
                {
                    DialogResult = DialogResult.OK;
                    Close();
                }
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
            ShowImagePreview();
        }

        private void btnUploadImage_Click(object sender, EventArgs e)
        {
            using var openFileDialog = new OpenFileDialog();
            openFileDialog.Title = "Select Device Image";
            openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp";
            openFileDialog.Multiselect = true;

            if (openFileDialog.ShowDialog() != DialogResult.OK)
            {
                return;
            }

            var images = GetDeviceImages();
            foreach (var fileName in openFileDialog.FileNames)
            {
                images.Add(File.ReadAllBytes(fileName));
            }

            if (images.Count == 0)
            {
                return;
            }

            _currentImageIndex = images.Count - 1;
            UpdateImageDisplay();
            _hasChanges = true;
        }

        private void LoadDeviceImage()
        {
            var images = GetDeviceImages();

            if (_currentImageIndex >= images.Count)
            {
                _currentImageIndex = Math.Max(0, images.Count - 1);
            }

            UpdateImageDisplay();
        }

        private List<byte[]> GetDeviceImages()
        {
            if (_report is null)
            {
                return _deviceImages;
            }

            if (_report.DeviceImages.Count == 0 && _report.DeviceImage is { Length: > 0 })
            {
                _report.DeviceImages.Add(_report.DeviceImage);
            }

            return _report.DeviceImages;
        }

        private void UpdateImageDisplay()
        {
            var images = GetDeviceImages();

            if (images.Count == 0)
            {
                picDeviceImage.Image = null;
                labelPictureNumber.Text = string.Empty;
                return;
            }

            _currentImageIndex = Math.Clamp(_currentImageIndex, 0, images.Count - 1);
            using var stream = new MemoryStream(images[_currentImageIndex]);
            picDeviceImage.Image = Image.FromStream(stream);
            labelPictureNumber.Text = $"{_currentImageIndex + 1}/{images.Count}";

            if (_report is not null)
            {
                _report.DeviceImage = images[_currentImageIndex];
            }
        }

        private bool TryMoveImage(int delta)
        {
            var images = GetDeviceImages();
            if (images.Count == 0)
            {
                return false;
            }

            var newIndex = _currentImageIndex + delta;
            if (newIndex < 0 || newIndex >= images.Count)
            {
                return false;
            }

            _currentImageIndex = newIndex;
            UpdateImageDisplay();
            return true;
        }

        private void ShowImagePreview()
        {
            if (picDeviceImage.Image is null)
            {
                return;
            }

            using var preview = new Form
            {
                Text = "Device Image",
                StartPosition = FormStartPosition.CenterParent,
                BackColor = Color.Black,
                ClientSize = new Size(800, 600),
                KeyPreview = true
            };

            var pictureBox = new PictureBox
            {
                Dock = DockStyle.Fill,
                Image = picDeviceImage.Image,
                SizeMode = PictureBoxSizeMode.Zoom
            };

            preview.KeyDown += (_, e) =>
            {
                if (e.KeyCode == Keys.Left || e.KeyCode == Keys.Oemcomma)
                {
                    if (TryMoveImage(-1))
                    {
                        pictureBox.Image = picDeviceImage.Image;
                    }
                }
                else if (e.KeyCode == Keys.Right || e.KeyCode == Keys.OemPeriod)
                {
                    if (TryMoveImage(1))
                    {
                        pictureBox.Image = picDeviceImage.Image;
                    }
                }
            };

            preview.Controls.Add(pictureBox);
            preview.ShowDialog(this);
        }

        private void labelPrevious_Click(object sender, EventArgs e)
        {
            TryMoveImage(-1);
        }

        private void labelNext_Click(object sender, EventArgs e)
        {
            TryMoveImage(1);
        }

        private void LoadStatuses()
        {
            try
            {
                using var dbContext = CreateDbContext();
                var statuses = dbContext.Statuses
                    .AsNoTracking()
                    .OrderBy(status => status.Id)
                    .Select(status => status.Name)
                    .ToList();

                if (_report is not null && !string.IsNullOrWhiteSpace(_report.Status) && !statuses.Contains(_report.Status))
                {
                    statuses.Add(_report.Status);
                }

                comboBoxStatus.DataSource = statuses;

                if (_report is not null)
                {
                    comboBoxStatus.SelectedItem = _report.Status;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Failed to load statuses: {ex.Message}", "Load Statuses", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private static AppDbContext CreateDbContext()
        {
            var options = new DbContextOptionsBuilder<AppDbContext>().Options;
            var dbContext = new AppDbContext(options);

            dbContext.Database.Migrate();
            _databaseInitialized = true;

            return dbContext;
        }
    }
}

