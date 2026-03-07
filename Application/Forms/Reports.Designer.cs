namespace Application.Forms
{
    partial class Reports
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            panel1 = new Panel();
            lblAvgTime = new Label();
            lblThisMonth = new Label();
            lblTotal = new Label();
            dgvCompleted = new DataGridView();
            txtSearch = new TextBox();
            lblSearch = new Label();
            cmbStatus = new ComboBox();
            lblStatus = new Label();
            dtpTo = new DateTimePicker();
            lblTo = new Label();
            dtpFrom = new DateTimePicker();
            lblFrom = new Label();
            lblTitle = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCompleted).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(24, 24, 38);
            panel1.Controls.Add(lblAvgTime);
            panel1.Controls.Add(lblThisMonth);
            panel1.Controls.Add(lblTotal);
            panel1.Controls.Add(dgvCompleted);
            panel1.Controls.Add(txtSearch);
            panel1.Controls.Add(lblSearch);
            panel1.Controls.Add(cmbStatus);
            panel1.Controls.Add(lblStatus);
            panel1.Controls.Add(dtpTo);
            panel1.Controls.Add(lblTo);
            panel1.Controls.Add(dtpFrom);
            panel1.Controls.Add(lblFrom);
            panel1.Controls.Add(lblTitle);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(960, 600);
            panel1.TabIndex = 0;
            // 
            // lblAvgTime
            // 
            lblAvgTime.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            lblAvgTime.AutoSize = true;
            lblAvgTime.ForeColor = Color.White;
            lblAvgTime.Location = new Point(276, 515);
            lblAvgTime.Name = "lblAvgTime";
            lblAvgTime.Size = new Size(146, 17);
            lblAvgTime.TabIndex = 13;
            lblAvgTime.Text = "Avg Completion: 0 days";
            // 
            // lblThisMonth
            // 
            lblThisMonth.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            lblThisMonth.AutoSize = true;
            lblThisMonth.ForeColor = Color.White;
            lblThisMonth.Location = new Point(155, 515);
            lblThisMonth.Name = "lblThisMonth";
            lblThisMonth.Size = new Size(87, 17);
            lblThisMonth.TabIndex = 12;
            lblThisMonth.Text = "This Month: 0";
            // 
            // lblTotal
            // 
            lblTotal.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            lblTotal.AutoSize = true;
            lblTotal.ForeColor = Color.White;
            lblTotal.Location = new Point(12, 515);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(118, 17);
            lblTotal.TabIndex = 11;
            lblTotal.Text = "Total Completed: 0";
            // 
            // dgvCompleted
            // 
            dgvCompleted.AllowUserToAddRows = false;
            dgvCompleted.AllowUserToDeleteRows = false;
            dgvCompleted.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvCompleted.BackgroundColor = Color.FromArgb(30, 30, 46);
            dgvCompleted.BorderStyle = BorderStyle.None;
            dgvCompleted.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(45, 45, 72);
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = Color.White;
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(45, 45, 72);
            dataGridViewCellStyle3.SelectionForeColor = Color.White;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dgvCompleted.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dgvCompleted.ColumnHeadersHeight = 34;
            dgvCompleted.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = Color.FromArgb(36, 36, 54);
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 9.5F);
            dataGridViewCellStyle4.ForeColor = Color.White;
            dataGridViewCellStyle4.SelectionBackColor = Color.FromArgb(99, 102, 241);
            dataGridViewCellStyle4.SelectionForeColor = Color.White;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.False;
            dgvCompleted.DefaultCellStyle = dataGridViewCellStyle4;
            dgvCompleted.EnableHeadersVisualStyles = false;
            dgvCompleted.GridColor = Color.FromArgb(45, 45, 72);
            dgvCompleted.Location = new Point(12, 150);
            dgvCompleted.Name = "dgvCompleted";
            dgvCompleted.ReadOnly = true;
            dgvCompleted.RowHeadersVisible = false;
            dgvCompleted.RowTemplate.Height = 28;
            dgvCompleted.Size = new Size(936, 350);
            dgvCompleted.TabIndex = 10;
            // 
            // txtSearch
            // 
            txtSearch.BackColor = Color.FromArgb(36, 36, 54);
            txtSearch.BorderStyle = BorderStyle.FixedSingle;
            txtSearch.ForeColor = Color.White;
            txtSearch.Location = new Point(360, 106);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(230, 24);
            txtSearch.TabIndex = 9;
            // 
            // lblSearch
            // 
            lblSearch.AutoSize = true;
            lblSearch.ForeColor = Color.White;
            lblSearch.Location = new Point(276, 110);
            lblSearch.Name = "lblSearch";
            lblSearch.Size = new Size(81, 17);
            lblSearch.TabIndex = 8;
            lblSearch.Text = "Search client";
            // 
            // cmbStatus
            // 
            cmbStatus.BackColor = Color.FromArgb(36, 36, 54);
            cmbStatus.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbStatus.FlatStyle = FlatStyle.Flat;
            cmbStatus.ForeColor = Color.White;
            cmbStatus.FormattingEnabled = true;
            cmbStatus.Items.AddRange(new object[] { "Completed" });
            cmbStatus.Location = new Point(80, 106);
            cmbStatus.Name = "cmbStatus";
            cmbStatus.Size = new Size(180, 25);
            cmbStatus.TabIndex = 7;
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.ForeColor = Color.White;
            lblStatus.Location = new Point(28, 110);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(43, 17);
            lblStatus.TabIndex = 6;
            lblStatus.Text = "Status";
            // 
            // dtpTo
            // 
            dtpTo.CalendarForeColor = Color.White;
            dtpTo.CalendarMonthBackground = Color.FromArgb(36, 36, 54);
            dtpTo.Location = new Point(305, 66);
            dtpTo.Name = "dtpTo";
            dtpTo.Size = new Size(180, 24);
            dtpTo.TabIndex = 4;
            // 
            // lblTo
            // 
            lblTo.AutoSize = true;
            lblTo.ForeColor = Color.White;
            lblTo.Location = new Point(276, 70);
            lblTo.Name = "lblTo";
            lblTo.Size = new Size(22, 17);
            lblTo.TabIndex = 3;
            lblTo.Text = "To";
            // 
            // dtpFrom
            // 
            dtpFrom.CalendarForeColor = Color.White;
            dtpFrom.CalendarMonthBackground = Color.FromArgb(36, 36, 54);
            dtpFrom.Location = new Point(80, 66);
            dtpFrom.Name = "dtpFrom";
            dtpFrom.Size = new Size(180, 24);
            dtpFrom.TabIndex = 2;
            // 
            // lblFrom
            // 
            lblFrom.AutoSize = true;
            lblFrom.ForeColor = Color.White;
            lblFrom.Location = new Point(28, 70);
            lblFrom.Name = "lblFrom";
            lblFrom.Size = new Size(38, 17);
            lblFrom.TabIndex = 1;
            lblFrom.Text = "From";
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblTitle.ForeColor = Color.White;
            lblTitle.Location = new Point(24, 20);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(240, 25);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Completed Clients Report";
            // 
            // Reports
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(24, 24, 38);
            ClientSize = new Size(960, 600);
            Controls.Add(panel1);
            Font = new Font("Segoe UI", 9.5F);
            Name = "Reports";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Reports";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCompleted).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label lblTitle;
        private Label lblFrom;
        private DateTimePicker dtpFrom;
        private Label lblTo;
        private DateTimePicker dtpTo;
        private Label lblStatus;
        private ComboBox cmbStatus;
        private Label lblSearch;
        private TextBox txtSearch;
        private DataGridView dgvCompleted;
        private Label lblTotal;
        private Label lblThisMonth;
        private Label lblAvgTime;
    }
}