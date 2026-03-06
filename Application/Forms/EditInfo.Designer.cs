namespace Application.Forms
{
    partial class EditInfo
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
            panelEditInfo = new Panel();
            labelPictureNumber = new Label();
            labelPrevious = new Label();
            labelNext = new Label();
            comboBoxStatus = new ComboBox();
            label8 = new Label();
            label7 = new Label();
            labelUpdatedOn = new Label();
            labelDateReceived = new Label();
            label6 = new Label();
            btnUploadImage = new Button();
            picDeviceImage = new PictureBox();
            iconButtonDelete = new FontAwesome.Sharp.IconButton();
            iconButtonCancel = new FontAwesome.Sharp.IconButton();
            iconButtonUpdate = new FontAwesome.Sharp.IconButton();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            txtAdditionalInfo = new TextBox();
            txtIssueSummary = new TextBox();
            txtDeviceModel = new TextBox();
            txtClientName = new TextBox();
            cmbBoxEditInfoOS = new ComboBox();
            panelEditInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picDeviceImage).BeginInit();
            SuspendLayout();
            // 
            // panelEditInfo
            // 
            panelEditInfo.BackColor = Color.FromArgb(24, 24, 38);
            panelEditInfo.Controls.Add(cmbBoxEditInfoOS);
            panelEditInfo.Controls.Add(labelPictureNumber);
            panelEditInfo.Controls.Add(labelPrevious);
            panelEditInfo.Controls.Add(labelNext);
            panelEditInfo.Controls.Add(comboBoxStatus);
            panelEditInfo.Controls.Add(label8);
            panelEditInfo.Controls.Add(label7);
            panelEditInfo.Controls.Add(labelUpdatedOn);
            panelEditInfo.Controls.Add(labelDateReceived);
            panelEditInfo.Controls.Add(label6);
            panelEditInfo.Controls.Add(btnUploadImage);
            panelEditInfo.Controls.Add(picDeviceImage);
            panelEditInfo.Controls.Add(iconButtonDelete);
            panelEditInfo.Controls.Add(iconButtonCancel);
            panelEditInfo.Controls.Add(iconButtonUpdate);
            panelEditInfo.Controls.Add(label5);
            panelEditInfo.Controls.Add(label4);
            panelEditInfo.Controls.Add(label3);
            panelEditInfo.Controls.Add(label2);
            panelEditInfo.Controls.Add(label1);
            panelEditInfo.Controls.Add(txtAdditionalInfo);
            panelEditInfo.Controls.Add(txtIssueSummary);
            panelEditInfo.Controls.Add(txtDeviceModel);
            panelEditInfo.Controls.Add(txtClientName);
            panelEditInfo.Dock = DockStyle.Fill;
            panelEditInfo.Location = new Point(0, 0);
            panelEditInfo.Name = "panelEditInfo";
            panelEditInfo.Size = new Size(800, 450);
            panelEditInfo.TabIndex = 0;
            // 
            // labelPictureNumber
            // 
            labelPictureNumber.AutoSize = true;
            labelPictureNumber.Font = new Font("Segoe UI", 10F);
            labelPictureNumber.ForeColor = Color.Gainsboro;
            labelPictureNumber.Location = new Point(144, 302);
            labelPictureNumber.Name = "labelPictureNumber";
            labelPictureNumber.Size = new Size(0, 19);
            labelPictureNumber.TabIndex = 23;
            // 
            // labelPrevious
            // 
            labelPrevious.AutoSize = true;
            labelPrevious.Cursor = Cursors.Hand;
            labelPrevious.Font = new Font("Segoe UI", 10F);
            labelPrevious.ForeColor = Color.Gainsboro;
            labelPrevious.Location = new Point(119, 302);
            labelPrevious.Name = "labelPrevious";
            labelPrevious.Size = new Size(19, 19);
            labelPrevious.TabIndex = 22;
            labelPrevious.Text = "<";
            labelPrevious.Click += labelPrevious_Click;
            // 
            // labelNext
            // 
            labelNext.AutoSize = true;
            labelNext.Cursor = Cursors.Hand;
            labelNext.Font = new Font("Segoe UI", 10F);
            labelNext.ForeColor = Color.Gainsboro;
            labelNext.Location = new Point(175, 302);
            labelNext.Name = "labelNext";
            labelNext.Size = new Size(19, 19);
            labelNext.TabIndex = 21;
            labelNext.Text = ">";
            labelNext.Click += labelNext_Click;
            // 
            // comboBoxStatus
            // 
            comboBoxStatus.BackColor = Color.FromArgb(54, 53, 97);
            comboBoxStatus.FlatStyle = FlatStyle.Flat;
            comboBoxStatus.Font = new Font("Segoe UI", 10F);
            comboBoxStatus.ForeColor = Color.WhiteSmoke;
            comboBoxStatus.FormattingEnabled = true;
            comboBoxStatus.Location = new Point(349, 317);
            comboBoxStatus.Name = "comboBoxStatus";
            comboBoxStatus.Size = new Size(112, 25);
            comboBoxStatus.TabIndex = 20;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 10F);
            label8.ForeColor = Color.Gainsboro;
            label8.Location = new Point(293, 317);
            label8.Name = "label8";
            label8.Size = new Size(50, 19);
            label8.TabIndex = 19;
            label8.Text = "Status:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 10F);
            label7.ForeColor = Color.Gainsboro;
            label7.Location = new Point(258, 389);
            label7.Name = "label7";
            label7.Size = new Size(88, 19);
            label7.TabIndex = 18;
            label7.Text = "Updated On:";
            // 
            // labelUpdatedOn
            // 
            labelUpdatedOn.AutoSize = true;
            labelUpdatedOn.Font = new Font("Segoe UI", 10F);
            labelUpdatedOn.ForeColor = Color.Gainsboro;
            labelUpdatedOn.Location = new Point(352, 389);
            labelUpdatedOn.Name = "labelUpdatedOn";
            labelUpdatedOn.Size = new Size(0, 19);
            labelUpdatedOn.TabIndex = 17;
            // 
            // labelDateReceived
            // 
            labelDateReceived.AutoSize = true;
            labelDateReceived.Font = new Font("Segoe UI", 10F);
            labelDateReceived.ForeColor = Color.Gainsboro;
            labelDateReceived.Location = new Point(352, 353);
            labelDateReceived.Name = "labelDateReceived";
            labelDateReceived.Size = new Size(0, 19);
            labelDateReceived.TabIndex = 16;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 10F);
            label6.ForeColor = Color.Gainsboro;
            label6.Location = new Point(248, 353);
            label6.Name = "label6";
            label6.Size = new Size(98, 19);
            label6.TabIndex = 15;
            label6.Text = "Date Received:";
            // 
            // btnUploadImage
            // 
            btnUploadImage.BackColor = Color.FromArgb(88, 86, 147);
            btnUploadImage.FlatAppearance.BorderSize = 0;
            btnUploadImage.FlatStyle = FlatStyle.Flat;
            btnUploadImage.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            btnUploadImage.ForeColor = Color.White;
            btnUploadImage.Location = new Point(40, 295);
            btnUploadImage.Name = "btnUploadImage";
            btnUploadImage.Size = new Size(62, 30);
            btnUploadImage.TabIndex = 9;
            btnUploadImage.Text = "Upload";
            btnUploadImage.UseVisualStyleBackColor = false;
            btnUploadImage.Click += btnUploadImage_Click;
            // 
            // picDeviceImage
            // 
            picDeviceImage.BackColor = Color.FromArgb(54, 53, 97);
            picDeviceImage.BorderStyle = BorderStyle.FixedSingle;
            picDeviceImage.Location = new Point(40, 66);
            picDeviceImage.Name = "picDeviceImage";
            picDeviceImage.Size = new Size(154, 223);
            picDeviceImage.SizeMode = PictureBoxSizeMode.Zoom;
            picDeviceImage.TabIndex = 8;
            picDeviceImage.TabStop = false;
            picDeviceImage.Click += picDeviceImage_Click;
            // 
            // iconButtonDelete
            // 
            iconButtonDelete.BackColor = Color.FromArgb(188, 69, 74);
            iconButtonDelete.FlatAppearance.BorderSize = 0;
            iconButtonDelete.FlatStyle = FlatStyle.Flat;
            iconButtonDelete.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            iconButtonDelete.ForeColor = Color.White;
            iconButtonDelete.IconChar = FontAwesome.Sharp.IconChar.TrashAlt;
            iconButtonDelete.IconColor = Color.White;
            iconButtonDelete.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButtonDelete.IconSize = 24;
            iconButtonDelete.Location = new Point(702, 115);
            iconButtonDelete.Name = "iconButtonDelete";
            iconButtonDelete.Size = new Size(86, 33);
            iconButtonDelete.TabIndex = 7;
            iconButtonDelete.Text = "Delete";
            iconButtonDelete.TextImageRelation = TextImageRelation.ImageBeforeText;
            iconButtonDelete.UseVisualStyleBackColor = false;
            iconButtonDelete.Click += iconButtonDelete_Click;
            // 
            // iconButtonCancel
            // 
            iconButtonCancel.BackColor = Color.FromArgb(60, 59, 100);
            iconButtonCancel.FlatAppearance.BorderSize = 0;
            iconButtonCancel.FlatStyle = FlatStyle.Flat;
            iconButtonCancel.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            iconButtonCancel.ForeColor = Color.White;
            iconButtonCancel.IconChar = FontAwesome.Sharp.IconChar.Cancel;
            iconButtonCancel.IconColor = Color.White;
            iconButtonCancel.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButtonCancel.IconSize = 24;
            iconButtonCancel.Location = new Point(702, 154);
            iconButtonCancel.Name = "iconButtonCancel";
            iconButtonCancel.Size = new Size(86, 33);
            iconButtonCancel.TabIndex = 6;
            iconButtonCancel.Text = "Close";
            iconButtonCancel.TextImageRelation = TextImageRelation.ImageBeforeText;
            iconButtonCancel.UseVisualStyleBackColor = false;
            iconButtonCancel.Click += iconButtonCancel_Click;
            // 
            // iconButtonUpdate
            // 
            iconButtonUpdate.BackColor = Color.FromArgb(88, 86, 147);
            iconButtonUpdate.FlatAppearance.BorderSize = 0;
            iconButtonUpdate.FlatStyle = FlatStyle.Flat;
            iconButtonUpdate.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            iconButtonUpdate.ForeColor = Color.White;
            iconButtonUpdate.IconChar = FontAwesome.Sharp.IconChar.ArrowRotateLeft;
            iconButtonUpdate.IconColor = Color.White;
            iconButtonUpdate.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButtonUpdate.IconSize = 24;
            iconButtonUpdate.ImageAlign = ContentAlignment.MiddleLeft;
            iconButtonUpdate.Location = new Point(702, 76);
            iconButtonUpdate.Name = "iconButtonUpdate";
            iconButtonUpdate.Size = new Size(86, 33);
            iconButtonUpdate.TabIndex = 5;
            iconButtonUpdate.Text = "Update";
            iconButtonUpdate.TextImageRelation = TextImageRelation.ImageBeforeText;
            iconButtonUpdate.UseVisualStyleBackColor = false;
            iconButtonUpdate.Click += iconButtonUpdate_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10F);
            label5.ForeColor = Color.Gainsboro;
            label5.Location = new Point(200, 249);
            label5.Name = "label5";
            label5.Size = new Size(150, 19);
            label5.TabIndex = 4;
            label5.Text = "Additional Information:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10F);
            label4.ForeColor = Color.Gainsboro;
            label4.Location = new Point(238, 192);
            label4.Name = "label4";
            label4.Size = new Size(105, 19);
            label4.TabIndex = 3;
            label4.Text = "Issue Summary:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10F);
            label3.ForeColor = Color.Gainsboro;
            label3.Location = new Point(246, 136);
            label3.Name = "label3";
            label3.Size = new Size(95, 19);
            label3.TabIndex = 2;
            label3.Text = "Device Model:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F);
            label2.ForeColor = Color.Gainsboro;
            label2.Location = new Point(224, 95);
            label2.Name = "label2";
            label2.Size = new Size(122, 19);
            label2.TabIndex = 1;
            label2.Text = "Operating System:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10F);
            label1.ForeColor = Color.Gainsboro;
            label1.Location = new Point(229, 55);
            label1.Name = "label1";
            label1.Size = new Size(113, 19);
            label1.TabIndex = 0;
            label1.Text = "Client Name/PC: ";
            // 
            // txtAdditionalInfo
            // 
            txtAdditionalInfo.BackColor = Color.FromArgb(54, 53, 97);
            txtAdditionalInfo.BorderStyle = BorderStyle.FixedSingle;
            txtAdditionalInfo.ForeColor = Color.WhiteSmoke;
            txtAdditionalInfo.Location = new Point(350, 231);
            txtAdditionalInfo.Multiline = true;
            txtAdditionalInfo.Name = "txtAdditionalInfo";
            txtAdditionalInfo.Size = new Size(300, 69);
            txtAdditionalInfo.TabIndex = 14;
            // 
            // txtIssueSummary
            // 
            txtIssueSummary.BackColor = Color.FromArgb(54, 53, 97);
            txtIssueSummary.BorderStyle = BorderStyle.FixedSingle;
            txtIssueSummary.ForeColor = Color.WhiteSmoke;
            txtIssueSummary.Location = new Point(349, 180);
            txtIssueSummary.Multiline = true;
            txtIssueSummary.Name = "txtIssueSummary";
            txtIssueSummary.Size = new Size(300, 40);
            txtIssueSummary.TabIndex = 13;
            // 
            // txtDeviceModel
            // 
            txtDeviceModel.BackColor = Color.FromArgb(54, 53, 97);
            txtDeviceModel.BorderStyle = BorderStyle.FixedSingle;
            txtDeviceModel.ForeColor = Color.WhiteSmoke;
            txtDeviceModel.Location = new Point(350, 132);
            txtDeviceModel.Name = "txtDeviceModel";
            txtDeviceModel.Size = new Size(300, 25);
            txtDeviceModel.TabIndex = 12;
            // 
            // txtClientName
            // 
            txtClientName.BackColor = Color.FromArgb(54, 53, 97);
            txtClientName.BorderStyle = BorderStyle.FixedSingle;
            txtClientName.ForeColor = Color.WhiteSmoke;
            txtClientName.Location = new Point(350, 52);
            txtClientName.Name = "txtClientName";
            txtClientName.Size = new Size(300, 25);
            txtClientName.TabIndex = 10;
            // 
            // cmbBoxEditInfoOS
            // 
            cmbBoxEditInfoOS.BackColor = Color.FromArgb(54, 53, 97);
            cmbBoxEditInfoOS.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbBoxEditInfoOS.FlatStyle = FlatStyle.Flat;
            cmbBoxEditInfoOS.Font = new Font("Segoe UI", 10F);
            cmbBoxEditInfoOS.ForeColor = Color.WhiteSmoke;
            cmbBoxEditInfoOS.FormattingEnabled = true;
            cmbBoxEditInfoOS.Items.AddRange(new object[] { "Windows 10", "Windows 11", "MacOS", "Linux", "ChromeOS", "Others" });
            cmbBoxEditInfoOS.Location = new Point(350, 89);
            cmbBoxEditInfoOS.Name = "cmbBoxEditInfoOS";
            cmbBoxEditInfoOS.Size = new Size(300, 25);
            cmbBoxEditInfoOS.TabIndex = 24;
            // 
            // EditInfo
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            ControlBox = false;
            Controls.Add(panelEditInfo);
            Font = new Font("Segoe UI", 10F);
            FormBorderStyle = FormBorderStyle.None;
            Name = "EditInfo";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "EditInfo";
            panelEditInfo.ResumeLayout(false);
            panelEditInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picDeviceImage).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelEditInfo;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Label label5;
        private FontAwesome.Sharp.IconButton iconButtonDelete;
        private FontAwesome.Sharp.IconButton iconButtonCancel;
        private FontAwesome.Sharp.IconButton iconButtonUpdate;
        private PictureBox picDeviceImage;
        private Button btnUploadImage;
        private TextBox txtClientName;
        private TextBox txtDeviceModel;
        private TextBox txtIssueSummary;
        private TextBox txtAdditionalInfo;
        private Label labelDateReceived;
        private Label label6;
        private Label labelUpdatedOn;
        private Label label7;
        private ComboBox comboBoxStatus;
        private Label label8;
        private Label labelPrevious;
        private Label labelNext;
        private Label labelPictureNumber;
        private ComboBox cmbBoxEditInfoOS;
    }
}