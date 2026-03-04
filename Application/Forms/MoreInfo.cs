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
using System.IO;

namespace Application.Forms
{
    public partial class MoreInfo : Form
    {
        private readonly DamageReports? _report;
        private readonly BindingSource? _bindingSource;
        private readonly BindingList<DamageReports>? _masterList;
        private readonly List<byte[]> _deviceImages = new();
        private int _currentImageIndex;

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
            LoadReportDetails();
        }

        private void LoadReportDetails()
        {
            if (_report is null)
            {
                return;
            }

            labelClientName.Text = _report.ClientName;
            labelOperatingSystem.Text = _report.OperatingSystem;
            labelDeviceModel.Text = string.IsNullOrWhiteSpace(_report.DeviceModel) ? "N/A" : _report.DeviceModel;
            labelIssueSummary.Text = _report.DamageSummary;
            labelAdditionalInfo.Text = string.IsNullOrWhiteSpace(_report.AdditionalInfo) ? "N/A" : _report.AdditionalInfo;
            labelStatus.Text = string.IsNullOrWhiteSpace(_report.Status) ? "N/A" : _report.Status;
            labelDateReceived.Text = _report.DateReceived == default
                ? string.Empty
                : _report.DateReceived.ToString("MMMM dd, yyyy");
            labelUpdatedOn.Text = _report.UpdatedOn is null
                ? string.Empty
                : _report.UpdatedOn.Value.ToString("MMMM dd, yyyy hh:mm tt");
            LoadDeviceImage();
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
                pictureBoxMoreInfo.Image = null;
                labelPictureNumber.Text = string.Empty;
                return;
            }

            _currentImageIndex = Math.Clamp(_currentImageIndex, 0, images.Count - 1);
            using var stream = new MemoryStream(images[_currentImageIndex]);
            pictureBoxMoreInfo.Image = Image.FromStream(stream);
            pictureBoxMoreInfo.SizeMode = PictureBoxSizeMode.Zoom;
            labelPictureNumber.Text = $"{_currentImageIndex + 1}/{images.Count}";
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

        private void iconEditInfo_Click(object sender, EventArgs e)
        {
            if (_report is null)
            {
                return;
            }

            using var editInfoForm = new EditInfo(_report, _bindingSource, _masterList);
            var result = editInfoForm.ShowDialog(this);
            if (result == DialogResult.OK)
            {
                Close();
                return;
            }

            LoadReportDetails();
        }

        private void iconButtonClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void pictureBoxMoreInfo_Click(object sender, EventArgs e)
        {
            ShowImagePreview();
        }

        private void ShowImagePreview()
        {
            if (pictureBoxMoreInfo.Image is null)
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
                Image = pictureBoxMoreInfo.Image,
                SizeMode = PictureBoxSizeMode.Zoom
            };

            preview.KeyDown += (_, e) =>
            {
                if (e.KeyCode == Keys.Left || e.KeyCode == Keys.Oemcomma)
                {
                    if (TryMoveImage(-1))
                    {
                        pictureBox.Image = pictureBoxMoreInfo.Image;
                    }
                }
                else if (e.KeyCode == Keys.Right || e.KeyCode == Keys.OemPeriod)
                {
                    if (TryMoveImage(1))
                    {
                        pictureBox.Image = pictureBoxMoreInfo.Image;
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
    }
}
