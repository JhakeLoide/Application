namespace Application.Forms
{
    partial class formAddingClient
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
            panel1 = new Panel();
            labelUploadPhoto = new Label();
            txtBoxAddInfo = new TextBox();
            label6 = new Label();
            txtBoxDeviceModel = new TextBox();
            label5 = new Label();
            txtBoxSummary = new TextBox();
            label4 = new Label();
            dateTimePicker1 = new DateTimePicker();
            label3 = new Label();
            cmbBoxOS = new ComboBox();
            label2 = new Label();
            txtBoxName = new TextBox();
            label1 = new Label();
            btnAdd = new Button();
            btnCancel = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(34, 33, 72);
            panel1.Controls.Add(labelUploadPhoto);
            panel1.Controls.Add(txtBoxAddInfo);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(txtBoxDeviceModel);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(txtBoxSummary);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(dateTimePicker1);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(cmbBoxOS);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(txtBoxName);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(btnAdd);
            panel1.Controls.Add(btnCancel);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(543, 361);
            panel1.TabIndex = 0;
            // 
            // labelUploadPhoto
            // 
            labelUploadPhoto.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            labelUploadPhoto.AutoSize = true;
            labelUploadPhoto.Cursor = Cursors.Hand;
            labelUploadPhoto.ForeColor = Color.White;
            labelUploadPhoto.Location = new Point(3, 333);
            labelUploadPhoto.Name = "labelUploadPhoto";
            labelUploadPhoto.Size = new Size(105, 19);
            labelUploadPhoto.TabIndex = 14;
            labelUploadPhoto.Text = "Upload a photo";
            labelUploadPhoto.Click += labelUploadPhoto_Click;
            // 
            // txtBoxAddInfo
            // 
            txtBoxAddInfo.BackColor = Color.FromArgb(54, 53, 97);
            txtBoxAddInfo.BorderStyle = BorderStyle.FixedSingle;
            txtBoxAddInfo.ForeColor = Color.WhiteSmoke;
            txtBoxAddInfo.Location = new Point(204, 197);
            txtBoxAddInfo.Multiline = true;
            txtBoxAddInfo.Name = "txtBoxAddInfo";
            txtBoxAddInfo.Size = new Size(191, 113);
            txtBoxAddInfo.TabIndex = 13;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 10F);
            label6.ForeColor = Color.Gainsboro;
            label6.Location = new Point(133, 244);
            label6.Name = "label6";
            label6.Size = new Size(65, 19);
            label6.TabIndex = 12;
            label6.Text = "Add Info:";
            // 
            // txtBoxDeviceModel
            // 
            txtBoxDeviceModel.BackColor = Color.FromArgb(54, 53, 97);
            txtBoxDeviceModel.BorderStyle = BorderStyle.FixedSingle;
            txtBoxDeviceModel.ForeColor = Color.WhiteSmoke;
            txtBoxDeviceModel.Location = new Point(204, 83);
            txtBoxDeviceModel.Name = "txtBoxDeviceModel";
            txtBoxDeviceModel.Size = new Size(191, 25);
            txtBoxDeviceModel.TabIndex = 11;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10F);
            label5.ForeColor = Color.Gainsboro;
            label5.Location = new Point(103, 89);
            label5.Name = "label5";
            label5.Size = new Size(95, 19);
            label5.TabIndex = 10;
            label5.Text = "Device Model:";
            // 
            // txtBoxSummary
            // 
            txtBoxSummary.BackColor = Color.FromArgb(54, 53, 97);
            txtBoxSummary.BorderStyle = BorderStyle.FixedSingle;
            txtBoxSummary.ForeColor = Color.WhiteSmoke;
            txtBoxSummary.Location = new Point(204, 143);
            txtBoxSummary.Multiline = true;
            txtBoxSummary.Name = "txtBoxSummary";
            txtBoxSummary.Size = new Size(191, 50);
            txtBoxSummary.TabIndex = 9;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10F);
            label4.ForeColor = Color.Gainsboro;
            label4.Location = new Point(93, 158);
            label4.Name = "label4";
            label4.Size = new Size(105, 19);
            label4.TabIndex = 8;
            label4.Text = "Issue Summary:";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.CalendarForeColor = Color.WhiteSmoke;
            dateTimePicker1.CalendarMonthBackground = Color.FromArgb(54, 53, 97);
            dateTimePicker1.CalendarTitleBackColor = Color.FromArgb(48, 47, 86);
            dateTimePicker1.CalendarTitleForeColor = Color.WhiteSmoke;
            dateTimePicker1.Font = new Font("Segoe UI", 10F);
            dateTimePicker1.Enabled = false;
            dateTimePicker1.Location = new Point(204, 112);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(191, 25);
            dateTimePicker1.TabIndex = 7;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10F);
            label3.ForeColor = Color.Gainsboro;
            label3.Location = new Point(100, 118);
            label3.Name = "label3";
            label3.Size = new Size(98, 19);
            label3.TabIndex = 6;
            label3.Text = "Date Recieved:";
            // 
            // cmbBoxOS
            // 
            cmbBoxOS.BackColor = Color.FromArgb(54, 53, 97);
            cmbBoxOS.FlatStyle = FlatStyle.Flat;
            cmbBoxOS.Font = new Font("Segoe UI", 10F);
            cmbBoxOS.ForeColor = Color.WhiteSmoke;
            cmbBoxOS.FormattingEnabled = true;
            cmbBoxOS.Items.AddRange(new object[] { "Windows 10", "Windows 11", "MacOS", "Linux", "ChromeOS", "Others" });
            cmbBoxOS.Location = new Point(204, 54);
            cmbBoxOS.Name = "cmbBoxOS";
            cmbBoxOS.Size = new Size(192, 25);
            cmbBoxOS.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F);
            label2.ForeColor = Color.Gainsboro;
            label2.Location = new Point(169, 60);
            label2.Name = "label2";
            label2.Size = new Size(30, 19);
            label2.TabIndex = 4;
            label2.Text = "OS:";
            // 
            // txtBoxName
            // 
            txtBoxName.BackColor = Color.FromArgb(54, 53, 97);
            txtBoxName.BorderStyle = BorderStyle.FixedSingle;
            txtBoxName.ForeColor = Color.WhiteSmoke;
            txtBoxName.Location = new Point(205, 23);
            txtBoxName.Name = "txtBoxName";
            txtBoxName.Size = new Size(191, 25);
            txtBoxName.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10F);
            label1.ForeColor = Color.Gainsboro;
            label1.Location = new Point(151, 29);
            label1.Name = "label1";
            label1.Size = new Size(48, 19);
            label1.TabIndex = 2;
            label1.Text = "Name:";
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.FromArgb(88, 86, 147);
            btnAdd.FlatAppearance.BorderSize = 0;
            btnAdd.FlatStyle = FlatStyle.Flat;
            btnAdd.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            btnAdd.ForeColor = Color.White;
            btnAdd.Location = new Point(205, 316);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(86, 30);
            btnAdd.TabIndex = 1;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.FromArgb(60, 59, 100);
            btnCancel.FlatAppearance.BorderSize = 0;
            btnCancel.FlatStyle = FlatStyle.Flat;
            btnCancel.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            btnCancel.ForeColor = Color.White;
            btnCancel.Location = new Point(310, 316);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(86, 30);
            btnCancel.TabIndex = 0;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // formAddingClient
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(543, 361);
            ControlBox = false;
            Controls.Add(panel1);
            Font = new Font("Segoe UI", 10F);
            FormBorderStyle = FormBorderStyle.None;
            Name = "formAddingClient";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AddingClient";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button btnAdd;
        private Button btnCancel;
        private Label label2;
        private TextBox txtBoxName;
        private Label label1;
        private ComboBox cmbBoxOS;
        private TextBox txtBoxSummary;
        private Label label4;
        private DateTimePicker dateTimePicker1;
        private Label label3;
        private TextBox txtBoxDeviceModel;
        private Label label5;
        private TextBox txtBoxAddInfo;
        private Label label6;
        private Label labelUploadPhoto;
    }
}