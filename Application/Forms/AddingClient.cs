using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using App.Domain.Entities;
using System.Windows.Forms;

namespace Application.Forms
{
    public partial class formAddingClient : Form
    {
        public DamageReports? CreatedReport { get; private set; }
        private readonly List<byte[]> _deviceImages = new();
        private int _currentImageIndex = -1;

        public formAddingClient()
        {
            InitializeComponent();
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.CustomFormat = "MMMM dd, yyyy";
            dateTimePicker1.Value = DateTime.Today;
            picBoxAddingClient.SizeMode = PictureBoxSizeMode.Zoom;
            UpdateUploadedPhotoCount();
            UpdateImagePreview();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtBoxName.Text))
            {
                MessageBox.Show("Client name is required.", "Add Client", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(cmbBoxOS.Text))
            {
                MessageBox.Show("Operating system is required.", "Add Client", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(txtBoxDeviceModel.Text))
            {
                MessageBox.Show("Device model is required.", "Add Client", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(txtBoxSummary.Text))
            {
                MessageBox.Show("Issue summary is required.", "Add Client", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            CreatedReport = new DamageReports
            {
                ClientName = txtBoxName.Text.Trim(),
                OperatingSystem = cmbBoxOS.Text,
                DeviceModel = txtBoxDeviceModel.Text.Trim(),
                DamageSummary = txtBoxSummary.Text.Trim(),
                AdditionalInfo = txtBoxAddInfo.Text.Trim(),
                Remarks = string.Empty,
                DateReceived = dateTimePicker1.Value.Date,
                DeviceImage = _deviceImages.FirstOrDefault(),
                Status = "[New] On-Hold"
            };

            if (_deviceImages.Count > 0)
            {
                CreatedReport.DeviceImages = new List<byte[]>(_deviceImages);
            }

            DialogResult = DialogResult.OK;
            Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void labelUploadPhoto_Click(object sender, EventArgs e)
        {
            UploadImages();
        }

        private void btnUploadImageAddingClient_Click(object sender, EventArgs e)
        {
            UploadImages();
        }

        private void UploadImages()
        {
            using var openFileDialog = new OpenFileDialog();
            openFileDialog.Title = "Select Device Image";
            openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp";
            openFileDialog.Multiselect = true;

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                foreach (var fileName in openFileDialog.FileNames)
                {
                    _deviceImages.Add(File.ReadAllBytes(fileName));
                }
                if (_currentImageIndex < 0 && _deviceImages.Count > 0)
                {
                    _currentImageIndex = 0;
                }
                UpdateUploadedPhotoCount();
                UpdateImagePreview();
            }
        }

        private void btnRemoveImageAddingClient_Click(object sender, EventArgs e)
        {
            if (_deviceImages.Count == 0 || _currentImageIndex < 0)
            {
                return;
            }

            _deviceImages.RemoveAt(_currentImageIndex);
            if (_deviceImages.Count == 0)
            {
                _currentImageIndex = -1;
            }
            else if (_currentImageIndex >= _deviceImages.Count)
            {
                _currentImageIndex = _deviceImages.Count - 1;
            }

            UpdateUploadedPhotoCount();
            UpdateImagePreview();
        }

        private void picBoxAddingClient_Click(object sender, EventArgs e)
        {
            ShowFullImage();
        }

        private void labelPrevious_Click(object sender, EventArgs e)
        {
            if (_deviceImages.Count == 0)
            {
                return;
            }

            _currentImageIndex = (_currentImageIndex - 1 + _deviceImages.Count) % _deviceImages.Count;
            UpdateImagePreview();
        }

        private void labelNext_Click(object sender, EventArgs e)
        {
            if (_deviceImages.Count == 0)
            {
                return;
            }

            _currentImageIndex = (_currentImageIndex + 1) % _deviceImages.Count;
            UpdateImagePreview();
        }

        private void labelPictureNumber_Click(object sender, EventArgs e)
        {
            ShowFullImage();
        }

        private void ShowFullImage()
        {
            if (_currentImageIndex < 0 || _currentImageIndex >= _deviceImages.Count)
            {
                return;
            }

            using var image = CreateImageFromBytes(_deviceImages[_currentImageIndex]);
            if (image == null)
            {
                return;
            }

            using var preview = new Form
            {
                Text = "Image Preview",
                StartPosition = FormStartPosition.CenterParent,
                BackColor = Color.FromArgb(34, 33, 72),
                ClientSize = new Size(800, 600)
            };

            using var previewBox = new PictureBox
            {
                Dock = DockStyle.Fill,
                Image = (Image)image.Clone(),
                SizeMode = PictureBoxSizeMode.Zoom,
                BackColor = Color.FromArgb(34, 33, 72)
            };

            preview.Controls.Add(previewBox);
            preview.ShowDialog(this);
        }

        private void UpdateImagePreview()
        {
            picBoxAddingClient.Image?.Dispose();
            picBoxAddingClient.Image = null;

            if (_currentImageIndex < 0 || _currentImageIndex >= _deviceImages.Count)
            {
                labelPictureNumber.Text = string.Empty;
                return;
            }

            var image = CreateImageFromBytes(_deviceImages[_currentImageIndex]);
            if (image != null)
            {
                picBoxAddingClient.Image = image;
            }

            labelPictureNumber.Text = $"{_currentImageIndex + 1}/{_deviceImages.Count}";
        }

        private static Image? CreateImageFromBytes(byte[] data)
        {
            try
            {
                using var stream = new MemoryStream(data);
                using var image = Image.FromStream(stream);
                return new Bitmap(image);
            }
            catch
            {
                return null;
            }
        }

        private void UpdateUploadedPhotoCount()
        {
            if (_deviceImages.Count == 0)
            {
                labelPictureNumber.Text = string.Empty;
                return;
            }

            var index = _currentImageIndex < 0 ? 1 : _currentImageIndex + 1;
            labelPictureNumber.Text = $"{index}/{_deviceImages.Count}";
        }

        private void txtBoxName_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtBoxDeviceModel_TextChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void cmbBoxOS_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
