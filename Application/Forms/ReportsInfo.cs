using System;
using System.Drawing;
using System.Windows.Forms;
using App.Domain.Entities;
using App.Infrastructure.Context;
using Microsoft.EntityFrameworkCore;
using System.IO;
using System.ComponentModel;

namespace Application.Forms
{
    public partial class ReportsInfo : Form
    {
        private readonly DamageReports? _report;
        private readonly BindingSource? _bindingSource;
        private readonly BindingList<DamageReports>? _masterList;
        private readonly List<byte[]> _deviceImages = new();
        private int _currentImageIndex;
        private bool _hasChanges;
        private static bool _databaseInitialized;

        public ReportsInfo()
        {
            InitializeComponent();
            WireEvents();
        }

        public ReportsInfo(DamageReports report, BindingSource? bindingSource = null, BindingList<DamageReports>? masterList = null)
        {
            InitializeComponent();
            _report = report;
            _bindingSource = bindingSource;
            _masterList = masterList;
            WireEvents();
            LoadReportDetails();
        }

        private void LoadReportDetails()
        {
            if (_report is null)
            {
                return;
            }

            lblClientNameReportsInfo.Text = _report.ClientName;
            lblDateReceivedReportsInfo.Text = _report.DateReceived == default
                ? string.Empty
                : _report.DateReceived.ToString("MMMM dd, yyyy");
            lblCompletedOnReportsInfo.Text = _report.UpdatedOn is null
                ? string.Empty
                : _report.UpdatedOn.Value.ToString("MMMM dd, yyyy hh:mm tt");
            lblDeviceItemReportsInfo.Text = !string.IsNullOrWhiteSpace(_report.DeviceModel)
                ? _report.DeviceModel
                : string.IsNullOrWhiteSpace(_report.OperatingSystem) ? "N/A" : _report.OperatingSystem;
            lblIssueDescriptionReportsInfo.Text = _report.DamageSummary;
            txtBoxRemarksReportsInfo.Text = string.IsNullOrWhiteSpace(_report.AdditionalInfo) ? string.Empty : _report.AdditionalInfo;
            LoadDeviceImage();
            _hasChanges = false;
        }

        private void WireEvents()
        {
            txtBoxRemarksReportsInfo.TextChanged += (_, _) => _hasChanges = true;
            btnUploadImage.Click += btnUploadImage_Click;
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
                pictureBoxReportsInfo.Image = null;
                labelPictureNumber.Text = string.Empty;
                return;
            }

            _currentImageIndex = Math.Clamp(_currentImageIndex, 0, images.Count - 1);
            using var stream = new MemoryStream(images[_currentImageIndex]);
            pictureBoxReportsInfo.Image = Image.FromStream(stream);
            pictureBoxReportsInfo.SizeMode = PictureBoxSizeMode.Zoom;
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

        private void iconButtonUpdateReportsInfo_Click(object sender, EventArgs e)
        {
            if (_report is null)
            {
                return;
            }

            _report.AdditionalInfo = txtBoxRemarksReportsInfo.Text.Trim();

            try
            {
                using var dbContext = CreateDbContext();
                dbContext.DamageReports.Update(_report);
                dbContext.SaveChanges();
                _bindingSource?.ResetBindings(false);
                _hasChanges = false;
                MessageBox.Show("Info saved.", "Reports Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Failed to save info: {ex.Message}", "Reports Info", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void iconButtonCancelReportsInfo_Click(object sender, EventArgs e)
        {
            if (_hasChanges)
            {
                var result = MessageBox.Show(
                    "There are changes in this info, are you sure you want to cancel?",
                    "Cancel Changes",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning);

                if (result != DialogResult.Yes)
                {
                    return;
                }
            }

            Close();
        }

        private void pictureBoxReportsInfo_Click(object sender, EventArgs e)
        {
            ShowImagePreview();
        }

        private void ShowImagePreview()
        {
            if (pictureBoxReportsInfo.Image is null)
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
                Image = pictureBoxReportsInfo.Image,
                SizeMode = PictureBoxSizeMode.Zoom
            };

            preview.KeyDown += (_, e) =>
            {
                if (e.KeyCode == Keys.Left || e.KeyCode == Keys.Oemcomma)
                {
                    if (TryMoveImage(-1))
                    {
                        pictureBox.Image = pictureBoxReportsInfo.Image;
                    }
                }
                else if (e.KeyCode == Keys.Right || e.KeyCode == Keys.OemPeriod)
                {
                    if (TryMoveImage(1))
                    {
                        pictureBox.Image = pictureBoxReportsInfo.Image;
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

        private void btnUploadImage_Click(object sender, EventArgs e)
        {
            using var openFileDialog = new OpenFileDialog
            {
                Title = "Select Device Image",
                Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp",
                Multiselect = true
            };

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

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

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
