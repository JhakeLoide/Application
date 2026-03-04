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
            labelPictureNumber = new Label();
            labelPrevious = new Label();
            labelNext = new Label();
            iconButtonClose = new FontAwesome.Sharp.IconButton();
            iconEditInfo = new FontAwesome.Sharp.IconButton();
            labelStatus = new Label();
            labelAdditionalInfo = new Label();
            labelIssueSummary = new Label();
            labelDeviceModel = new Label();
            labelOperatingSystem = new Label();
            labelClientName = new Label();
            label8 = new Label();
            label7 = new Label();
            labelUpdatedOn = new Label();
            labelDateReceived = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            pictureBoxMoreInfo = new PictureBox();
            panelMoreInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxMoreInfo).BeginInit();
            SuspendLayout();
            // 
            // panelMoreInfo
            // 
            panelMoreInfo.BackColor = Color.FromArgb(24, 24, 38);
            panelMoreInfo.Controls.Add(labelPictureNumber);
            panelMoreInfo.Controls.Add(labelPrevious);
            panelMoreInfo.Controls.Add(labelNext);
            panelMoreInfo.Controls.Add(iconButtonClose);
            panelMoreInfo.Controls.Add(iconEditInfo);
            panelMoreInfo.Controls.Add(labelStatus);
            panelMoreInfo.Controls.Add(labelAdditionalInfo);
            panelMoreInfo.Controls.Add(labelIssueSummary);
            panelMoreInfo.Controls.Add(labelDeviceModel);
            panelMoreInfo.Controls.Add(labelOperatingSystem);
            panelMoreInfo.Controls.Add(labelClientName);
            panelMoreInfo.Controls.Add(label8);
            panelMoreInfo.Controls.Add(label7);
            panelMoreInfo.Controls.Add(labelUpdatedOn);
            panelMoreInfo.Controls.Add(labelDateReceived);
            panelMoreInfo.Controls.Add(label6);
            panelMoreInfo.Controls.Add(label5);
            panelMoreInfo.Controls.Add(label4);
            panelMoreInfo.Controls.Add(label3);
            panelMoreInfo.Controls.Add(label2);
            panelMoreInfo.Controls.Add(label1);
            panelMoreInfo.Controls.Add(pictureBoxMoreInfo);
            panelMoreInfo.Dock = DockStyle.Fill;
            panelMoreInfo.Location = new Point(0, 0);
            panelMoreInfo.Name = "panelMoreInfo";
            panelMoreInfo.Size = new Size(800, 450);
            panelMoreInfo.TabIndex = 0;
            // 
            // labelPictureNumber
            // 
            labelPictureNumber.AutoSize = true;
            labelPictureNumber.Font = new Font("Segoe UI", 10F);
            labelPictureNumber.ForeColor = Color.Gainsboro;
            labelPictureNumber.Location = new Point(149, 357);
            labelPictureNumber.Name = "labelPictureNumber";
            labelPictureNumber.Size = new Size(0, 19);
            labelPictureNumber.TabIndex = 40;
            // 
            // labelPrevious
            // 
            labelPrevious.AutoSize = true;
            labelPrevious.Cursor = Cursors.Hand;
            labelPrevious.Font = new Font("Segoe UI", 10F);
            labelPrevious.ForeColor = Color.Gainsboro;
            labelPrevious.Location = new Point(124, 357);
            labelPrevious.Name = "labelPrevious";
            labelPrevious.Size = new Size(19, 19);
            labelPrevious.TabIndex = 39;
            labelPrevious.Text = "<";
            labelPrevious.Click += labelPrevious_Click;
            // 
            // labelNext
            // 
            labelNext.AutoSize = true;
            labelNext.Cursor = Cursors.Hand;
            labelNext.Font = new Font("Segoe UI", 10F);
            labelNext.ForeColor = Color.Gainsboro;
            labelNext.Location = new Point(190, 357);
            labelNext.Name = "labelNext";
            labelNext.Size = new Size(19, 19);
            labelNext.TabIndex = 38;
            labelNext.Text = ">";
            labelNext.Click += labelNext_Click;
            // 
            // iconButtonClose
            // 
            iconButtonClose.BackColor = Color.FromArgb(60, 59, 100);
            iconButtonClose.FlatAppearance.BorderSize = 0;
            iconButtonClose.FlatStyle = FlatStyle.Flat;
            iconButtonClose.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            iconButtonClose.ForeColor = Color.White;
            iconButtonClose.IconChar = FontAwesome.Sharp.IconChar.Cancel;
            iconButtonClose.IconColor = Color.White;
            iconButtonClose.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButtonClose.IconSize = 24;
            iconButtonClose.Location = new Point(702, 67);
            iconButtonClose.Name = "iconButtonClose";
            iconButtonClose.Size = new Size(86, 33);
            iconButtonClose.TabIndex = 37;
            iconButtonClose.Text = "Close";
            iconButtonClose.TextImageRelation = TextImageRelation.ImageBeforeText;
            iconButtonClose.UseVisualStyleBackColor = false;
            iconButtonClose.Click += iconButtonClose_Click;
            // 
            // iconEditInfo
            // 
            iconEditInfo.BackColor = Color.FromArgb(88, 86, 147);
            iconEditInfo.FlatAppearance.BorderSize = 0;
            iconEditInfo.FlatStyle = FlatStyle.Flat;
            iconEditInfo.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            iconEditInfo.ForeColor = Color.White;
            iconEditInfo.IconChar = FontAwesome.Sharp.IconChar.ArrowRotateLeft;
            iconEditInfo.IconColor = Color.White;
            iconEditInfo.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconEditInfo.IconSize = 24;
            iconEditInfo.ImageAlign = ContentAlignment.MiddleLeft;
            iconEditInfo.Location = new Point(702, 25);
            iconEditInfo.Name = "iconEditInfo";
            iconEditInfo.Size = new Size(86, 33);
            iconEditInfo.TabIndex = 36;
            iconEditInfo.Text = "Edit";
            iconEditInfo.TextImageRelation = TextImageRelation.ImageBeforeText;
            iconEditInfo.UseVisualStyleBackColor = false;
            iconEditInfo.Click += iconEditInfo_Click;
            // 
            // labelStatus
            // 
            labelStatus.AutoSize = true;
            labelStatus.Font = new Font("Segoe UI", 10F);
            labelStatus.ForeColor = Color.Gainsboro;
            labelStatus.Location = new Point(476, 327);
            labelStatus.Name = "labelStatus";
            labelStatus.Size = new Size(0, 19);
            labelStatus.TabIndex = 35;
            // 
            // labelAdditionalInfo
            // 
            labelAdditionalInfo.AutoSize = true;
            labelAdditionalInfo.Font = new Font("Segoe UI", 10F);
            labelAdditionalInfo.ForeColor = Color.Gainsboro;
            labelAdditionalInfo.Location = new Point(476, 207);
            labelAdditionalInfo.MaximumSize = new Size(300, 0);
            labelAdditionalInfo.Name = "labelAdditionalInfo";
            labelAdditionalInfo.Size = new Size(0, 19);
            labelAdditionalInfo.TabIndex = 34;
            // 
            // labelIssueSummary
            // 
            labelIssueSummary.AutoSize = true;
            labelIssueSummary.Font = new Font("Segoe UI", 10F);
            labelIssueSummary.ForeColor = Color.Gainsboro;
            labelIssueSummary.Location = new Point(476, 158);
            labelIssueSummary.Name = "labelIssueSummary";
            labelIssueSummary.Size = new Size(0, 19);
            labelIssueSummary.TabIndex = 33;
            // 
            // labelDeviceModel
            // 
            labelDeviceModel.AutoSize = true;
            labelDeviceModel.Font = new Font("Segoe UI", 10F);
            labelDeviceModel.ForeColor = Color.Gainsboro;
            labelDeviceModel.Location = new Point(476, 120);
            labelDeviceModel.Name = "labelDeviceModel";
            labelDeviceModel.Size = new Size(0, 19);
            labelDeviceModel.TabIndex = 32;
            // 
            // labelOperatingSystem
            // 
            labelOperatingSystem.AutoSize = true;
            labelOperatingSystem.Font = new Font("Segoe UI", 10F);
            labelOperatingSystem.ForeColor = Color.Gainsboro;
            labelOperatingSystem.Location = new Point(476, 81);
            labelOperatingSystem.Name = "labelOperatingSystem";
            labelOperatingSystem.Size = new Size(0, 19);
            labelOperatingSystem.TabIndex = 31;
            // 
            // labelClientName
            // 
            labelClientName.AutoSize = true;
            labelClientName.Font = new Font("Segoe UI", 10F);
            labelClientName.ForeColor = Color.Gainsboro;
            labelClientName.Location = new Point(476, 46);
            labelClientName.Name = "labelClientName";
            labelClientName.Size = new Size(0, 19);
            labelClientName.TabIndex = 30;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 10F);
            label8.ForeColor = Color.Gainsboro;
            label8.Location = new Point(420, 327);
            label8.Name = "label8";
            label8.Size = new Size(50, 19);
            label8.TabIndex = 29;
            label8.Text = "Status:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 10F);
            label7.ForeColor = Color.Gainsboro;
            label7.Location = new Point(382, 388);
            label7.Name = "label7";
            label7.Size = new Size(88, 19);
            label7.TabIndex = 28;
            label7.Text = "Updated On:";
            // 
            // labelUpdatedOn
            // 
            labelUpdatedOn.AutoSize = true;
            labelUpdatedOn.Font = new Font("Segoe UI", 10F);
            labelUpdatedOn.ForeColor = Color.Gainsboro;
            labelUpdatedOn.Location = new Point(476, 388);
            labelUpdatedOn.Name = "labelUpdatedOn";
            labelUpdatedOn.Size = new Size(0, 19);
            labelUpdatedOn.TabIndex = 27;
            // 
            // labelDateReceived
            // 
            labelDateReceived.AutoSize = true;
            labelDateReceived.Font = new Font("Segoe UI", 10F);
            labelDateReceived.ForeColor = Color.Gainsboro;
            labelDateReceived.Location = new Point(476, 357);
            labelDateReceived.Name = "labelDateReceived";
            labelDateReceived.Size = new Size(0, 19);
            labelDateReceived.TabIndex = 26;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 10F);
            label6.ForeColor = Color.Gainsboro;
            label6.Location = new Point(372, 357);
            label6.Name = "label6";
            label6.Size = new Size(98, 19);
            label6.TabIndex = 25;
            label6.Text = "Date Received:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10F);
            label5.ForeColor = Color.Gainsboro;
            label5.Location = new Point(320, 207);
            label5.Name = "label5";
            label5.Size = new Size(150, 19);
            label5.TabIndex = 24;
            label5.Text = "Additional Information:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10F);
            label4.ForeColor = Color.Gainsboro;
            label4.Location = new Point(365, 158);
            label4.Name = "label4";
            label4.Size = new Size(105, 19);
            label4.TabIndex = 23;
            label4.Text = "Issue Summary:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10F);
            label3.ForeColor = Color.Gainsboro;
            label3.Location = new Point(375, 120);
            label3.Name = "label3";
            label3.Size = new Size(95, 19);
            label3.TabIndex = 22;
            label3.Text = "Device Model:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F);
            label2.ForeColor = Color.Gainsboro;
            label2.Location = new Point(348, 81);
            label2.Name = "label2";
            label2.Size = new Size(122, 19);
            label2.TabIndex = 21;
            label2.Text = "Operating System:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10F);
            label1.ForeColor = Color.Gainsboro;
            label1.Location = new Point(363, 46);
            label1.Name = "label1";
            label1.Size = new Size(113, 19);
            label1.TabIndex = 20;
            label1.Text = "Client Name/PC: ";
            // 
            // pictureBoxMoreInfo
            // 
            pictureBoxMoreInfo.Location = new Point(22, 81);
            pictureBoxMoreInfo.Name = "pictureBoxMoreInfo";
            pictureBoxMoreInfo.Size = new Size(292, 265);
            pictureBoxMoreInfo.TabIndex = 0;
            pictureBoxMoreInfo.TabStop = false;
            pictureBoxMoreInfo.Click += pictureBoxMoreInfo_Click;
            // 
            // MoreInfo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            ControlBox = false;
            Controls.Add(panelMoreInfo);
            FormBorderStyle = FormBorderStyle.None;
            Name = "MoreInfo";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MoreInfo";
            panelMoreInfo.ResumeLayout(false);
            panelMoreInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxMoreInfo).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelMoreInfo;
        private PictureBox pictureBoxMoreInfo;
        private Label label8;
        private Label label7;
        private Label labelUpdatedOn;
        private Label labelDateReceived;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Label labelStatus;
        private Label labelAdditionalInfo;
        private Label labelIssueSummary;
        private Label labelDeviceModel;
        private Label labelOperatingSystem;
        private Label labelClientName;
        private FontAwesome.Sharp.IconButton iconEditInfo;
        private FontAwesome.Sharp.IconButton iconButtonClose;
        private Label labelPictureNumber;
        private Label labelPrevious;
        private Label labelNext;
    }
}