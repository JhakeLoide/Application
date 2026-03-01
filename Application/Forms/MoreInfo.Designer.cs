namespace Application.Forms
{
    partial class MoreInfo
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
            panelMoreInfo = new Panel();
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
            txtOperatingSystem = new TextBox();
            txtClientName = new TextBox();
            panelMoreInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picDeviceImage).BeginInit();
            SuspendLayout();
            // 
            // panelMoreInfo
            // 
            panelMoreInfo.BackColor = Color.FromArgb(34, 33, 72);
            panelMoreInfo.Controls.Add(labelDateReceived);
            panelMoreInfo.Controls.Add(label6);
            panelMoreInfo.Controls.Add(btnUploadImage);
            panelMoreInfo.Controls.Add(picDeviceImage);
            panelMoreInfo.Controls.Add(iconButtonDelete);
            panelMoreInfo.Controls.Add(iconButtonCancel);
            panelMoreInfo.Controls.Add(iconButtonUpdate);
            panelMoreInfo.Controls.Add(label5);
            panelMoreInfo.Controls.Add(label4);
            panelMoreInfo.Controls.Add(label3);
            panelMoreInfo.Controls.Add(label2);
            panelMoreInfo.Controls.Add(label1);
            panelMoreInfo.Controls.Add(txtAdditionalInfo);
            panelMoreInfo.Controls.Add(txtIssueSummary);
            panelMoreInfo.Controls.Add(txtDeviceModel);
            panelMoreInfo.Controls.Add(txtOperatingSystem);
            panelMoreInfo.Controls.Add(txtClientName);
            panelMoreInfo.Dock = DockStyle.Fill;
            panelMoreInfo.Location = new Point(0, 0);
            panelMoreInfo.Name = "panelMoreInfo";
            panelMoreInfo.Size = new Size(800, 450);
            panelMoreInfo.TabIndex = 0;
            // 
            // labelDateReceived
            // 
            labelDateReceived.AutoSize = true;
            labelDateReceived.Font = new Font("Segoe UI", 10F);
            labelDateReceived.ForeColor = Color.Gainsboro;
            labelDateReceived.Location = new Point(349, 386);
            labelDateReceived.Name = "labelDateReceived";
            labelDateReceived.Size = new Size(0, 19);
            labelDateReceived.TabIndex = 16;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 10F);
            label6.ForeColor = Color.Gainsboro;
            label6.Location = new Point(245, 386);
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
            btnUploadImage.Location = new Point(92, 295);
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
            picDeviceImage.Location = new Point(58, 111);
            picDeviceImage.Name = "picDeviceImage";
            picDeviceImage.Size = new Size(133, 178);
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
            label5.Location = new Point(197, 318);
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
            label4.Location = new Point(235, 251);
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
            label3.Location = new Point(243, 205);
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
            label2.Location = new Point(221, 164);
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
            label1.Location = new Point(226, 124);
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
            txtAdditionalInfo.Location = new Point(347, 300);
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
            txtIssueSummary.Location = new Point(347, 247);
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
            txtDeviceModel.Location = new Point(347, 201);
            txtDeviceModel.Name = "txtDeviceModel";
            txtDeviceModel.Size = new Size(300, 25);
            txtDeviceModel.TabIndex = 12;
            // 
            // txtOperatingSystem
            // 
            txtOperatingSystem.BackColor = Color.FromArgb(54, 53, 97);
            txtOperatingSystem.BorderStyle = BorderStyle.FixedSingle;
            txtOperatingSystem.ForeColor = Color.WhiteSmoke;
            txtOperatingSystem.Location = new Point(347, 160);
            txtOperatingSystem.Name = "txtOperatingSystem";
            txtOperatingSystem.Size = new Size(300, 25);
            txtOperatingSystem.TabIndex = 11;
            // 
            // txtClientName
            // 
            txtClientName.BackColor = Color.FromArgb(54, 53, 97);
            txtClientName.BorderStyle = BorderStyle.FixedSingle;
            txtClientName.ForeColor = Color.WhiteSmoke;
            txtClientName.Location = new Point(347, 121);
            txtClientName.Name = "txtClientName";
            txtClientName.Size = new Size(300, 25);
            txtClientName.TabIndex = 10;
            // 
            // MoreInfo
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panelMoreInfo);
            Font = new Font("Segoe UI", 10F);
            Name = "MoreInfo";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MoreInfo";
            panelMoreInfo.ResumeLayout(false);
            panelMoreInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picDeviceImage).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelMoreInfo;
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
        private TextBox txtOperatingSystem;
        private TextBox txtDeviceModel;
        private TextBox txtIssueSummary;
        private TextBox txtAdditionalInfo;
        private Label labelDateReceived;
        private Label label6;
    }
}