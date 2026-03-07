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
            chkThemeLight = new CheckBox();
            chkThemeDark = new CheckBox();
            lblTheme = new Label();
            lblTitle = new Label();
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
            panel1.Controls.Add(chkThemeLight);
            panel1.Controls.Add(chkThemeDark);
            panel1.Controls.Add(lblTheme);
            panel1.Controls.Add(lblTitle);
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
            lblBuildVersionValue.Location = new Point(180, 171);
            lblBuildVersionValue.Name = "lblBuildVersionValue";
            lblBuildVersionValue.Size = new Size(81, 17);
            lblBuildVersionValue.TabIndex = 9;
            lblBuildVersionValue.Text = "Unpublished";
            // 
            // lblBuildVersion
            // 
            lblBuildVersion.AutoSize = true;
            lblBuildVersion.ForeColor = Color.White;
            lblBuildVersion.Location = new Point(28, 171);
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
            cmbStartupPage.Location = new Point(180, 122);
            cmbStartupPage.Name = "cmbStartupPage";
            cmbStartupPage.Size = new Size(200, 25);
            cmbStartupPage.TabIndex = 7;
            // 
            // lblStartupPage
            // 
            lblStartupPage.AutoSize = true;
            lblStartupPage.ForeColor = Color.White;
            lblStartupPage.Location = new Point(28, 126);
            lblStartupPage.Name = "lblStartupPage";
            lblStartupPage.Size = new Size(84, 17);
            lblStartupPage.TabIndex = 6;
            lblStartupPage.Text = "Startup page";
            // 
            // chkThemeLight
            // 
            chkThemeLight.AutoSize = true;
            chkThemeLight.ForeColor = Color.White;
            chkThemeLight.Location = new Point(250, 78);
            chkThemeLight.Name = "chkThemeLight";
            chkThemeLight.Size = new Size(55, 21);
            chkThemeLight.TabIndex = 3;
            chkThemeLight.Text = "Light";
            chkThemeLight.UseVisualStyleBackColor = true;
            // 
            // chkThemeDark
            // 
            chkThemeDark.AutoSize = true;
            chkThemeDark.Checked = true;
            chkThemeDark.CheckState = CheckState.Checked;
            chkThemeDark.ForeColor = Color.White;
            chkThemeDark.Location = new Point(180, 78);
            chkThemeDark.Name = "chkThemeDark";
            chkThemeDark.Size = new Size(54, 21);
            chkThemeDark.TabIndex = 2;
            chkThemeDark.Text = "Dark";
            chkThemeDark.UseVisualStyleBackColor = true;
            // 
            // lblTheme
            // 
            lblTheme.AutoSize = true;
            lblTheme.ForeColor = Color.White;
            lblTheme.Location = new Point(28, 80);
            lblTheme.Name = "lblTheme";
            lblTheme.Size = new Size(47, 17);
            lblTheme.TabIndex = 1;
            lblTheme.Text = "Theme";
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblTitle.ForeColor = Color.White;
            lblTitle.Location = new Point(24, 20);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(84, 25);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Settings";
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
        private Label lblTitle;
        private Label lblTheme;
        private CheckBox chkThemeDark;
        private CheckBox chkThemeLight;
        private Label lblStartupPage;
        private ComboBox cmbStartupPage;
        private Label lblBuildVersion;
        private Label lblBuildVersionValue;
    }
}