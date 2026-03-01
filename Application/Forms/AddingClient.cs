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

        public formAddingClient()
        {
            InitializeComponent();
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.CustomFormat = "MMMM dd, yyyy";
            dateTimePicker1.Value = DateTime.Today;
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
                DamageSummary = txtBoxSummary.Text.Trim(),
                AdditionalInfo = txtBoxAddInfo.Text.Trim(),
                DateReceived = dateTimePicker1.Value.Date,
                Status = "New"
            };

            DialogResult = DialogResult.OK;
            Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
