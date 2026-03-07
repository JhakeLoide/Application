namespace Final_Project
{
    partial class Menu
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panelMenu = new Panel();
            btnSettings = new FontAwesome.Sharp.IconButton();
            btnClientList = new FontAwesome.Sharp.IconButton();
            btnDashboard = new FontAwesome.Sharp.IconButton();
            panelLogo = new Panel();
            iconButtonHome = new FontAwesome.Sharp.IconButton();
            iconButton10 = new FontAwesome.Sharp.IconButton();
            panelTitle = new Panel();
            iconButton9 = new FontAwesome.Sharp.IconButton();
            iconButton8 = new FontAwesome.Sharp.IconButton();
            iconButton7 = new FontAwesome.Sharp.IconButton();
            lblStatic = new Label();
            iconStatic = new FontAwesome.Sharp.IconPictureBox();
            panelDesktop = new Panel();
            btnReports = new FontAwesome.Sharp.IconButton();
            panelMenu.SuspendLayout();
            panelLogo.SuspendLayout();
            panelTitle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)iconStatic).BeginInit();
            SuspendLayout();
            // 
            // panelMenu
            // 
            panelMenu.BackColor = Color.FromArgb(31, 30, 68);
            panelMenu.Controls.Add(btnReports);
            panelMenu.Controls.Add(btnSettings);
            panelMenu.Controls.Add(btnClientList);
            panelMenu.Controls.Add(btnDashboard);
            panelMenu.Controls.Add(panelLogo);
            panelMenu.Dock = DockStyle.Left;
            panelMenu.Location = new Point(0, 0);
            panelMenu.Name = "panelMenu";
            panelMenu.Size = new Size(220, 601);
            panelMenu.TabIndex = 0;
            // 
            // btnSettings
            // 
            btnSettings.Cursor = Cursors.Hand;
            btnSettings.Dock = DockStyle.Bottom;
            btnSettings.FlatAppearance.BorderSize = 0;
            btnSettings.FlatStyle = FlatStyle.Flat;
            btnSettings.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSettings.ForeColor = Color.White;
            btnSettings.IconChar = FontAwesome.Sharp.IconChar.Tools;
            btnSettings.IconColor = Color.White;
            btnSettings.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnSettings.IconSize = 32;
            btnSettings.ImageAlign = ContentAlignment.MiddleLeft;
            btnSettings.Location = new Point(0, 541);
            btnSettings.Name = "btnSettings";
            btnSettings.Size = new Size(220, 60);
            btnSettings.TabIndex = 3;
            btnSettings.Text = "Settings";
            btnSettings.TextAlign = ContentAlignment.MiddleLeft;
            btnSettings.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnSettings.UseVisualStyleBackColor = true;
            // 
            // btnClientList
            // 
            btnClientList.Cursor = Cursors.Hand;
            btnClientList.Dock = DockStyle.Top;
            btnClientList.FlatAppearance.BorderSize = 0;
            btnClientList.FlatStyle = FlatStyle.Flat;
            btnClientList.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnClientList.ForeColor = Color.White;
            btnClientList.IconChar = FontAwesome.Sharp.IconChar.ContactBook;
            btnClientList.IconColor = Color.White;
            btnClientList.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnClientList.IconSize = 32;
            btnClientList.ImageAlign = ContentAlignment.MiddleLeft;
            btnClientList.Location = new Point(0, 200);
            btnClientList.Name = "btnClientList";
            btnClientList.Size = new Size(220, 60);
            btnClientList.TabIndex = 2;
            btnClientList.Text = "Client List";
            btnClientList.TextAlign = ContentAlignment.MiddleLeft;
            btnClientList.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnClientList.UseVisualStyleBackColor = true;
            // 
            // btnDashboard
            // 
            btnDashboard.Cursor = Cursors.Hand;
            btnDashboard.Dock = DockStyle.Top;
            btnDashboard.FlatAppearance.BorderSize = 0;
            btnDashboard.FlatStyle = FlatStyle.Flat;
            btnDashboard.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnDashboard.ForeColor = Color.White;
            btnDashboard.IconChar = FontAwesome.Sharp.IconChar.BarChart;
            btnDashboard.IconColor = Color.White;
            btnDashboard.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnDashboard.IconSize = 32;
            btnDashboard.ImageAlign = ContentAlignment.MiddleLeft;
            btnDashboard.Location = new Point(0, 140);
            btnDashboard.Name = "btnDashboard";
            btnDashboard.Size = new Size(220, 60);
            btnDashboard.TabIndex = 1;
            btnDashboard.Text = "Dashboard";
            btnDashboard.TextAlign = ContentAlignment.MiddleLeft;
            btnDashboard.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnDashboard.UseVisualStyleBackColor = true;
            btnDashboard.Click += iconButton1_Click;
            // 
            // panelLogo
            // 
            panelLogo.Controls.Add(iconButtonHome);
            panelLogo.Controls.Add(iconButton10);
            panelLogo.Dock = DockStyle.Top;
            panelLogo.Location = new Point(0, 0);
            panelLogo.Name = "panelLogo";
            panelLogo.Size = new Size(220, 140);
            panelLogo.TabIndex = 1;
            panelLogo.Paint += panelLogo_Paint;
            // 
            // iconButtonHome
            // 
            iconButtonHome.FlatAppearance.BorderSize = 0;
            iconButtonHome.FlatStyle = FlatStyle.Flat;
            iconButtonHome.Font = new Font("Noto Sans JP", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            iconButtonHome.ForeColor = Color.Crimson;
            iconButtonHome.IconChar = FontAwesome.Sharp.IconChar.Computer;
            iconButtonHome.IconColor = Color.Crimson;
            iconButtonHome.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButtonHome.IconSize = 52;
            iconButtonHome.Location = new Point(22, 20);
            iconButtonHome.Name = "iconButtonHome";
            iconButtonHome.Size = new Size(176, 51);
            iconButtonHome.TabIndex = 0;
            iconButtonHome.Text = "PC Monitor";
            iconButtonHome.TextImageRelation = TextImageRelation.ImageBeforeText;
            iconButtonHome.UseVisualStyleBackColor = true;
            // 
            // iconButton10
            // 
            iconButton10.Dock = DockStyle.Bottom;
            iconButton10.FlatAppearance.BorderSize = 0;
            iconButton10.FlatStyle = FlatStyle.Flat;
            iconButton10.IconChar = FontAwesome.Sharp.IconChar.Bars;
            iconButton10.IconColor = Color.White;
            iconButton10.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton10.IconSize = 32;
            iconButton10.ImageAlign = ContentAlignment.MiddleLeft;
            iconButton10.Location = new Point(0, 99);
            iconButton10.Name = "iconButton10";
            iconButton10.Size = new Size(220, 41);
            iconButton10.TabIndex = 0;
            iconButton10.UseVisualStyleBackColor = true;
            // 
            // panelTitle
            // 
            panelTitle.BackColor = Color.FromArgb(26, 25, 62);
            panelTitle.Controls.Add(iconButton9);
            panelTitle.Controls.Add(iconButton8);
            panelTitle.Controls.Add(iconButton7);
            panelTitle.Controls.Add(lblStatic);
            panelTitle.Controls.Add(iconStatic);
            panelTitle.Dock = DockStyle.Top;
            panelTitle.Location = new Point(220, 0);
            panelTitle.Name = "panelTitle";
            panelTitle.Size = new Size(802, 65);
            panelTitle.TabIndex = 1;
            // 
            // iconButton9
            // 
            iconButton9.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            iconButton9.FlatAppearance.BorderSize = 0;
            iconButton9.FlatStyle = FlatStyle.Flat;
            iconButton9.IconChar = FontAwesome.Sharp.IconChar.WindowMinimize;
            iconButton9.IconColor = Color.DodgerBlue;
            iconButton9.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton9.IconSize = 24;
            iconButton9.Location = new Point(731, 0);
            iconButton9.Name = "iconButton9";
            iconButton9.Size = new Size(26, 29);
            iconButton9.TabIndex = 5;
            iconButton9.UseVisualStyleBackColor = true;
            iconButton9.Click += iconButton9_Click;
            // 
            // iconButton8
            // 
            iconButton8.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            iconButton8.FlatAppearance.BorderSize = 0;
            iconButton8.FlatStyle = FlatStyle.Flat;
            iconButton8.IconChar = FontAwesome.Sharp.IconChar.WindowMaximize;
            iconButton8.IconColor = Color.FromArgb(128, 128, 255);
            iconButton8.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton8.IconSize = 24;
            iconButton8.Location = new Point(754, 0);
            iconButton8.Name = "iconButton8";
            iconButton8.Size = new Size(26, 29);
            iconButton8.TabIndex = 4;
            iconButton8.UseVisualStyleBackColor = true;
            iconButton8.Click += iconButton8_Click_1;
            // 
            // iconButton7
            // 
            iconButton7.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            iconButton7.FlatAppearance.BorderSize = 0;
            iconButton7.FlatStyle = FlatStyle.Flat;
            iconButton7.IconChar = FontAwesome.Sharp.IconChar.TimesRectangle;
            iconButton7.IconColor = Color.Red;
            iconButton7.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton7.IconSize = 24;
            iconButton7.Location = new Point(776, 0);
            iconButton7.Name = "iconButton7";
            iconButton7.Size = new Size(26, 29);
            iconButton7.TabIndex = 3;
            iconButton7.UseVisualStyleBackColor = true;
            iconButton7.Click += iconButton7_Click_1;
            // 
            // lblStatic
            // 
            lblStatic.AutoSize = true;
            lblStatic.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblStatic.ForeColor = Color.Crimson;
            lblStatic.Location = new Point(44, 20);
            lblStatic.Name = "lblStatic";
            lblStatic.Size = new Size(64, 25);
            lblStatic.TabIndex = 2;
            lblStatic.Text = "Home";
            lblStatic.Click += lblStatic_Click;
            // 
            // iconStatic
            // 
            iconStatic.BackColor = Color.FromArgb(26, 25, 62);
            iconStatic.ForeColor = Color.Crimson;
            iconStatic.IconChar = FontAwesome.Sharp.IconChar.House;
            iconStatic.IconColor = Color.Crimson;
            iconStatic.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconStatic.Location = new Point(17, 17);
            iconStatic.Name = "iconStatic";
            iconStatic.Size = new Size(32, 32);
            iconStatic.TabIndex = 2;
            iconStatic.TabStop = false;
            // 
            // panelDesktop
            // 
            panelDesktop.BackColor = Color.FromArgb(34, 33, 74);
            panelDesktop.Dock = DockStyle.Fill;
            panelDesktop.Location = new Point(220, 65);
            panelDesktop.Name = "panelDesktop";
            panelDesktop.Size = new Size(802, 536);
            panelDesktop.TabIndex = 2;
            // 
            // btnReports
            // 
            btnReports.Cursor = Cursors.Hand;
            btnReports.Dock = DockStyle.Top;
            btnReports.FlatAppearance.BorderSize = 0;
            btnReports.FlatStyle = FlatStyle.Flat;
            btnReports.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnReports.ForeColor = Color.White;
            btnReports.IconChar = FontAwesome.Sharp.IconChar.BookBookmark;
            btnReports.IconColor = Color.White;
            btnReports.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnReports.IconSize = 32;
            btnReports.ImageAlign = ContentAlignment.MiddleLeft;
            btnReports.Location = new Point(0, 260);
            btnReports.Name = "btnReports";
            btnReports.Size = new Size(220, 60);
            btnReports.TabIndex = 4;
            btnReports.Text = "Reports";
            btnReports.TextAlign = ContentAlignment.MiddleLeft;
            btnReports.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnReports.UseVisualStyleBackColor = true;
            btnReports.Click += btnReports_Click;
            // 
            // Menu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1022, 601);
            Controls.Add(panelDesktop);
            Controls.Add(panelTitle);
            Controls.Add(panelMenu);
            Name = "Menu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Form1_Load;
            MouseDown += Menu_MouseDown;
            panelMenu.ResumeLayout(false);
            panelLogo.ResumeLayout(false);
            panelTitle.ResumeLayout(false);
            panelTitle.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)iconStatic).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelMenu;
        private Panel panelLogo;
        private FontAwesome.Sharp.IconButton btnDashboard;
        private FontAwesome.Sharp.IconButton btnSettings;
        private FontAwesome.Sharp.IconButton btnClientList;
        private Panel panelTitle;
        private FontAwesome.Sharp.IconPictureBox iconStatic;
        private Label lblStatic;
        private Panel panelDesktop;
        private FontAwesome.Sharp.IconButton iconButton7;
        private FontAwesome.Sharp.IconButton iconButton9;
        private FontAwesome.Sharp.IconButton iconButton8;
        private FontAwesome.Sharp.IconButton iconButton10;
        private FontAwesome.Sharp.IconButton iconButtonHome;
        private FontAwesome.Sharp.IconButton btnReports;
    }
}
