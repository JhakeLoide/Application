using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
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
            ApplyFilter(string.Empty);
            UpdateClientCount();
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
                if (string.IsNullOrWhiteSpace(normalizedFilter) ||
                    report.ClientName?.Contains(normalizedFilter, StringComparison.OrdinalIgnoreCase) == true)
                {
                    _filteredReports.Add(report);
                }
            }

            damageReportsBindingSource.RaiseListChangedEvents = true;
            damageReportsBindingSource.ResetBindings(false);
        }

        private void UpdateClientCount()
        {
            labelTotalClients.Text = _reports.Count.ToString();
        }

        private void iconAddClient_Click(object sender, EventArgs e)
        {
            using var addClientForm = new formAddingClient();
            if (addClientForm.ShowDialog(this) == DialogResult.OK && addClientForm.CreatedReport is not null)
            {
                _reports.Add(addClientForm.CreatedReport);
                ApplyFilter(searchBoxClientList.Text);
            }
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
    }
}
