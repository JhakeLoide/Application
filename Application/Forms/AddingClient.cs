using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
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

        public formAddingClient()
        {
            InitializeComponent();
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.CustomFormat = "MMMM dd, yyyy";
            dateTimePicker1.Value = DateTime.Today;
            UpdateUploadedPhotoCount();
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
                UpdateUploadedPhotoCount();
            }
        }

        private void UpdateUploadedPhotoCount()
        {
            labelUploadedPhoto.Text = _deviceImages.Count.ToString();
        }
    }
}
