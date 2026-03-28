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
            btnRemoveImageAddingClient = new Button();
            btnUploadImageAddingClient = new Button();
            labelPictureNumber = new Label();
            labelPrevious = new Label();
            labelNext = new Label();
            picBoxAddingClient = new PictureBox();
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
            ((System.ComponentModel.ISupportInitialize)picBoxAddingClient).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(34, 33, 72);
            panel1.Controls.Add(btnRemoveImageAddingClient);
            panel1.Controls.Add(btnUploadImageAddingClient);
            panel1.Controls.Add(labelPictureNumber);
            panel1.Controls.Add(labelPrevious);
            panel1.Controls.Add(labelNext);
            panel1.Controls.Add(picBoxAddingClient);
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
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(762, 361);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // btnRemoveImageAddingClient
            // 
            btnRemoveImageAddingClient.BackColor = Color.FromArgb(88, 86, 147);
            btnRemoveImageAddingClient.FlatAppearance.BorderSize = 0;
            btnRemoveImageAddingClient.FlatStyle = FlatStyle.Flat;
            btnRemoveImageAddingClient.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            btnRemoveImageAddingClient.ForeColor = Color.White;
            btnRemoveImageAddingClient.Location = new Point(55, 218);
            btnRemoveImageAddingClient.Name = "btnRemoveImageAddingClient";
            btnRemoveImageAddingClient.Size = new Size(67, 30);
            btnRemoveImageAddingClient.TabIndex = 28;
            btnRemoveImageAddingClient.Text = "Remove";
            btnRemoveImageAddingClient.UseVisualStyleBackColor = false;
            btnRemoveImageAddingClient.Click += btnRemoveImageAddingClient_Click;
            // 
            // btnUploadImageAddingClient
            // 
            btnUploadImageAddingClient.BackColor = Color.FromArgb(88, 86, 147);
            btnUploadImageAddingClient.FlatAppearance.BorderSize = 0;
            btnUploadImageAddingClient.FlatStyle = FlatStyle.Flat;
            btnUploadImageAddingClient.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            btnUploadImageAddingClient.ForeColor = Color.White;
            btnUploadImageAddingClient.Location = new Point(55, 182);
            btnUploadImageAddingClient.Name = "btnUploadImageAddingClient";
            btnUploadImageAddingClient.Size = new Size(67, 30);
            btnUploadImageAddingClient.TabIndex = 27;
            btnUploadImageAddingClient.Text = "Upload";
            btnUploadImageAddingClient.UseVisualStyleBackColor = false;
            btnUploadImageAddingClient.Click += btnUploadImageAddingClient_Click;
            // 
            // labelPictureNumber
            // 
            labelPictureNumber.AutoSize = true;
            labelPictureNumber.Cursor = Cursors.Hand;
            labelPictureNumber.Font = new Font("Segoe UI", 10F);
            labelPictureNumber.ForeColor = Color.Gainsboro;
            labelPictureNumber.Location = new Point(223, 302);
            labelPictureNumber.Name = "labelPictureNumber";
            labelPictureNumber.Size = new Size(0, 19);
            labelPictureNumber.TabIndex = 26;
            labelPictureNumber.Click += labelPictureNumber_Click;
            // 
            // labelPrevious
            // 
            labelPrevious.AutoSize = true;
            labelPrevious.Cursor = Cursors.Hand;
            labelPrevious.Font = new Font("Segoe UI", 10F);
            labelPrevious.ForeColor = Color.Gainsboro;
            labelPrevious.Location = new Point(198, 302);
            labelPrevious.Name = "labelPrevious";
            labelPrevious.Size = new Size(19, 19);
            labelPrevious.TabIndex = 25;
            labelPrevious.Text = "<";
            labelPrevious.Click += labelPrevious_Click;
            // 
            // labelNext
            // 
            labelNext.AutoSize = true;
            labelNext.Cursor = Cursors.Hand;
            labelNext.Font = new Font("Segoe UI", 10F);
            labelNext.ForeColor = Color.Gainsboro;
            labelNext.Location = new Point(254, 302);
            labelNext.Name = "labelNext";
            labelNext.Size = new Size(19, 19);
            labelNext.TabIndex = 24;
            labelNext.Text = ">";
            labelNext.Click += labelNext_Click;
            // 
            // picBoxAddingClient
            // 
            picBoxAddingClient.BackColor = Color.FromArgb(54, 53, 97);
            picBoxAddingClient.Cursor = Cursors.Hand;
            picBoxAddingClient.Location = new Point(128, 137);
            picBoxAddingClient.Name = "picBoxAddingClient";
            picBoxAddingClient.Size = new Size(215, 152);
            picBoxAddingClient.TabIndex = 17;
            picBoxAddingClient.TabStop = false;
            picBoxAddingClient.Click += picBoxAddingClient_Click;
            // 
            // txtBoxAddInfo
            // 
            txtBoxAddInfo.BackColor = Color.FromArgb(54, 53, 97);
            txtBoxAddInfo.BorderStyle = BorderStyle.FixedSingle;
            txtBoxAddInfo.ForeColor = Color.WhiteSmoke;
            txtBoxAddInfo.Location = new Point(469, 60);
            txtBoxAddInfo.Multiline = true;
            txtBoxAddInfo.Name = "txtBoxAddInfo";
            txtBoxAddInfo.Size = new Size(216, 152);
            txtBoxAddInfo.TabIndex = 13;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 10F);
            label6.ForeColor = Color.Gainsboro;
            label6.Location = new Point(398, 122);
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
            txtBoxDeviceModel.Location = new Point(127, 77);
            txtBoxDeviceModel.Name = "txtBoxDeviceModel";
            txtBoxDeviceModel.Size = new Size(216, 25);
            txtBoxDeviceModel.TabIndex = 11;
            txtBoxDeviceModel.TextChanged += txtBoxDeviceModel_TextChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10F);
            label5.ForeColor = Color.Gainsboro;
            label5.Location = new Point(26, 83);
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
            txtBoxSummary.Location = new Point(469, 17);
            txtBoxSummary.Multiline = true;
            txtBoxSummary.Name = "txtBoxSummary";
            txtBoxSummary.Size = new Size(216, 25);
            txtBoxSummary.TabIndex = 9;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10F);
            label4.ForeColor = Color.Gainsboro;
            label4.Location = new Point(358, 23);
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
            dateTimePicker1.Enabled = false;
            dateTimePicker1.Font = new Font("Segoe UI", 10F);
            dateTimePicker1.Location = new Point(127, 106);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(216, 25);
            dateTimePicker1.TabIndex = 7;
            dateTimePicker1.ValueChanged += dateTimePicker1_ValueChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10F);
            label3.ForeColor = Color.Gainsboro;
            label3.Location = new Point(23, 112);
            label3.Name = "label3";
            label3.Size = new Size(98, 19);
            label3.TabIndex = 6;
            label3.Text = "Date Recieved:";
            // 
            // cmbBoxOS
            // 
            cmbBoxOS.BackColor = Color.FromArgb(54, 53, 97);
            cmbBoxOS.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbBoxOS.FlatStyle = FlatStyle.Flat;
            cmbBoxOS.Font = new Font("Segoe UI", 10F);
            cmbBoxOS.ForeColor = Color.WhiteSmoke;
            cmbBoxOS.FormattingEnabled = true;
            cmbBoxOS.Items.AddRange(new object[] { "Windows 10", "Windows 11", "MacOS", "Linux", "ChromeOS", "Others" });
            cmbBoxOS.Location = new Point(127, 48);
            cmbBoxOS.Name = "cmbBoxOS";
            cmbBoxOS.Size = new Size(216, 25);
            cmbBoxOS.TabIndex = 5;
            cmbBoxOS.SelectedIndexChanged += cmbBoxOS_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F);
            label2.ForeColor = Color.Gainsboro;
            label2.Location = new Point(91, 54);
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
            txtBoxName.Location = new Point(128, 17);
            txtBoxName.Name = "txtBoxName";
            txtBoxName.Size = new Size(215, 25);
            txtBoxName.TabIndex = 3;
            txtBoxName.TextChanged += txtBoxName_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10F);
            label1.ForeColor = Color.Gainsboro;
            label1.Location = new Point(73, 23);
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
            btnAdd.Location = new Point(469, 259);
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
            btnCancel.Location = new Point(599, 259);
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
            ClientSize = new Size(735, 339);
            ControlBox = false;
            Controls.Add(panel1);
            Font = new Font("Segoe UI", 10F);
            FormBorderStyle = FormBorderStyle.None;
            Name = "formAddingClient";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AddingClient";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picBoxAddingClient).EndInit();
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
        private PictureBox picBoxAddingClient;
        private Label labelPictureNumber;
        private Label labelPrevious;
        private Label labelNext;
        private Button btnRemoveImageAddingClient;
        private Button btnUploadImageAddingClient;
    }
}