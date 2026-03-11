namespace Application.Forms
{
    partial class formSettings
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
            lblBuildVersionValue = new Label();
            lblBuildVersion = new Label();
            cmbStartupPage = new ComboBox();
            lblStartupPage = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(24, 24, 38);
            panel1.Controls.Add(lblBuildVersionValue);
            panel1.Controls.Add(lblBuildVersion);
            panel1.Controls.Add(cmbStartupPage);
            panel1.Controls.Add(lblStartupPage);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 450);
            panel1.TabIndex = 0;
            // 
            // lblBuildVersionValue
            // 
            lblBuildVersionValue.AutoSize = true;
            lblBuildVersionValue.ForeColor = Color.White;
            lblBuildVersionValue.Location = new Point(176, 111);
            lblBuildVersionValue.Name = "lblBuildVersionValue";
            lblBuildVersionValue.Size = new Size(81, 17);
            lblBuildVersionValue.TabIndex = 9;
            lblBuildVersionValue.Text = "Unpublished";
            // 
            // lblBuildVersion
            // 
            lblBuildVersion.AutoSize = true;
            lblBuildVersion.ForeColor = Color.White;
            lblBuildVersion.Location = new Point(24, 111);
            lblBuildVersion.Name = "lblBuildVersion";
            lblBuildVersion.Size = new Size(82, 17);
            lblBuildVersion.TabIndex = 8;
            lblBuildVersion.Text = "Build version";
            // 
            // cmbStartupPage
            // 
            cmbStartupPage.BackColor = Color.FromArgb(36, 36, 54);
            cmbStartupPage.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbStartupPage.FlatStyle = FlatStyle.Flat;
            cmbStartupPage.ForeColor = Color.White;
            cmbStartupPage.FormattingEnabled = true;
            cmbStartupPage.Items.AddRange(new object[] { "Menu", "Reports", "Dashboard", "Client List" });
            cmbStartupPage.Location = new Point(176, 62);
            cmbStartupPage.Name = "cmbStartupPage";
            cmbStartupPage.Size = new Size(200, 25);
            cmbStartupPage.TabIndex = 7;
            // 
            // lblStartupPage
            // 
            lblStartupPage.AutoSize = true;
            lblStartupPage.ForeColor = Color.White;
            lblStartupPage.Location = new Point(24, 66);
            lblStartupPage.Name = "lblStartupPage";
            lblStartupPage.Size = new Size(84, 17);
            lblStartupPage.TabIndex = 6;
            lblStartupPage.Text = "Startup page";
            // 
            // formSettings
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            Font = new Font("Segoe UI", 9.5F);
            Name = "formSettings";
            Text = "Settings";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label lblStartupPage;
        private ComboBox cmbStartupPage;
        private Label lblBuildVersion;
        private Label lblBuildVersionValue;
    }
}