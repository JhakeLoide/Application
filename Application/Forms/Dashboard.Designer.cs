namespace Application.Forms
{
    partial class formDashboard
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
            tableLayoutPanel1 = new TableLayoutPanel();
            panelTotalClients = new RoundedPanel();
            label11 = new Label();
            labelTotalClient = new Label();
            label1 = new Label();
            iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            panelNewToday = new RoundedPanel();
            label12 = new Label();
            labelNewToday = new Label();
            label2 = new Label();
            iconPictureBox2 = new FontAwesome.Sharp.IconPictureBox();
            panelInProgress = new RoundedPanel();
            label13 = new Label();
            labelInProgress = new Label();
            label3 = new Label();
            iconPictureBox3 = new FontAwesome.Sharp.IconPictureBox();
            panelCompleted = new RoundedPanel();
            label14 = new Label();
            labelCompleted = new Label();
            label4 = new Label();
            iconPictureBox4 = new FontAwesome.Sharp.IconPictureBox();
            panel2 = new RoundedPanel();
            label15 = new Label();
            labelOnHold = new Label();
            label5 = new Label();
            iconPictureBox5 = new FontAwesome.Sharp.IconPictureBox();
            panel1.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            panelTotalClients.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox1).BeginInit();
            panelNewToday.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox2).BeginInit();
            panelInProgress.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox3).BeginInit();
            panelCompleted.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox4).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox5).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(24, 24, 38);
            panel1.Controls.Add(tableLayoutPanel1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 450);
            panel1.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(panelTotalClients, 0, 0);
            tableLayoutPanel1.Controls.Add(panelNewToday, 1, 0);
            tableLayoutPanel1.Controls.Add(panelInProgress, 0, 1);
            tableLayoutPanel1.Controls.Add(panelCompleted, 1, 1);
            tableLayoutPanel1.Controls.Add(panel2, 0, 2);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.Padding = new Padding(12);
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 33.33333F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 33.33333F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 33.33333F));
            tableLayoutPanel1.Size = new Size(800, 450);
            tableLayoutPanel1.TabIndex = 6;
            // 
            // panelTotalClients
            // 
            panelTotalClients.BackColor = Color.FromArgb(45, 45, 68);
            panelTotalClients.BorderColor = Color.FromArgb(60, 60, 90);
            panelTotalClients.BorderThickness = 1;
            panelTotalClients.Controls.Add(label11);
            panelTotalClients.Controls.Add(labelTotalClient);
            panelTotalClients.Controls.Add(label1);
            panelTotalClients.Controls.Add(iconPictureBox1);
            panelTotalClients.CornerRadius = 18;
            panelTotalClients.Dock = DockStyle.Fill;
            panelTotalClients.Location = new Point(24, 24);
            panelTotalClients.Margin = new Padding(12);
            panelTotalClients.Name = "panelTotalClients";
            panelTotalClients.Size = new Size(364, 118);
            panelTotalClients.TabIndex = 0;
            // 
            // label11
            // 
            label11.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label11.AutoSize = true;
            label11.ForeColor = Color.White;
            label11.Location = new Point(22, 84);
            label11.Name = "label11";
            label11.Size = new Size(182, 15);
            label11.TabIndex = 4;
            label11.Text = "Show the total number of clients.";
            // 
            // labelTotalClient
            // 
            labelTotalClient.AutoSize = true;
            labelTotalClient.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelTotalClient.ForeColor = Color.White;
            labelTotalClient.Location = new Point(71, 50);
            labelTotalClient.Name = "labelTotalClient";
            labelTotalClient.Size = new Size(22, 21);
            labelTotalClient.TabIndex = 3;
            labelTotalClient.Text = "...";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(71, 28);
            label1.Name = "label1";
            label1.Size = new Size(102, 21);
            label1.TabIndex = 2;
            label1.Text = "Total Clients:";
            // 
            // iconPictureBox1
            // 
            iconPictureBox1.BackColor = Color.FromArgb(45, 45, 68);
            iconPictureBox1.ForeColor = Color.DeepSkyBlue;
            iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.PeopleGroup;
            iconPictureBox1.IconColor = Color.DeepSkyBlue;
            iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconPictureBox1.IconSize = 43;
            iconPictureBox1.Location = new Point(22, 28);
            iconPictureBox1.Name = "iconPictureBox1";
            iconPictureBox1.Size = new Size(43, 43);
            iconPictureBox1.TabIndex = 0;
            iconPictureBox1.TabStop = false;
            // 
            // panelNewToday
            // 
            panelNewToday.BackColor = Color.FromArgb(45, 45, 68);
            panelNewToday.BorderColor = Color.FromArgb(60, 60, 90);
            panelNewToday.BorderThickness = 1;
            panelNewToday.Controls.Add(label12);
            panelNewToday.Controls.Add(labelNewToday);
            panelNewToday.Controls.Add(label2);
            panelNewToday.Controls.Add(iconPictureBox2);
            panelNewToday.CornerRadius = 18;
            panelNewToday.Dock = DockStyle.Fill;
            panelNewToday.Location = new Point(412, 24);
            panelNewToday.Margin = new Padding(12);
            panelNewToday.Name = "panelNewToday";
            panelNewToday.Size = new Size(364, 118);
            panelNewToday.TabIndex = 1;
            // 
            // label12
            // 
            label12.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label12.AutoSize = true;
            label12.ForeColor = Color.White;
            label12.Location = new Point(22, 84);
            label12.Name = "label12";
            label12.Size = new Size(256, 15);
            label12.TabIndex = 5;
            label12.Text = "Track how many new clients were added today.";
            // 
            // labelNewToday
            // 
            labelNewToday.AutoSize = true;
            labelNewToday.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelNewToday.ForeColor = Color.White;
            labelNewToday.Location = new Point(71, 49);
            labelNewToday.Name = "labelNewToday";
            labelNewToday.Size = new Size(22, 21);
            labelNewToday.TabIndex = 4;
            labelNewToday.Text = "...";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(71, 28);
            label2.Name = "label2";
            label2.Size = new Size(94, 21);
            label2.TabIndex = 3;
            label2.Text = "New Today:";
            // 
            // iconPictureBox2
            // 
            iconPictureBox2.BackColor = Color.FromArgb(45, 45, 68);
            iconPictureBox2.ForeColor = Color.Aquamarine;
            iconPictureBox2.IconChar = FontAwesome.Sharp.IconChar.User;
            iconPictureBox2.IconColor = Color.Aquamarine;
            iconPictureBox2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconPictureBox2.IconSize = 43;
            iconPictureBox2.Location = new Point(22, 28);
            iconPictureBox2.Name = "iconPictureBox2";
            iconPictureBox2.Size = new Size(43, 43);
            iconPictureBox2.TabIndex = 0;
            iconPictureBox2.TabStop = false;
            // 
            // panelInProgress
            // 
            panelInProgress.BackColor = Color.FromArgb(45, 45, 68);
            panelInProgress.BorderColor = Color.FromArgb(60, 60, 90);
            panelInProgress.BorderThickness = 1;
            panelInProgress.Controls.Add(label13);
            panelInProgress.Controls.Add(labelInProgress);
            panelInProgress.Controls.Add(label3);
            panelInProgress.Controls.Add(iconPictureBox3);
            panelInProgress.CornerRadius = 18;
            panelInProgress.Dock = DockStyle.Fill;
            panelInProgress.Location = new Point(24, 166);
            panelInProgress.Margin = new Padding(12);
            panelInProgress.Name = "panelInProgress";
            panelInProgress.Size = new Size(364, 118);
            panelInProgress.TabIndex = 1;
            // 
            // label13
            // 
            label13.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label13.AutoSize = true;
            label13.ForeColor = Color.White;
            label13.Location = new Point(22, 85);
            label13.Name = "label13";
            label13.Size = new Size(262, 15);
            label13.TabIndex = 6;
            label13.Text = "Show how many requests are currently ongoing.";
            // 
            // labelInProgress
            // 
            labelInProgress.AutoSize = true;
            labelInProgress.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelInProgress.ForeColor = Color.White;
            labelInProgress.Location = new Point(71, 50);
            labelInProgress.Name = "labelInProgress";
            labelInProgress.Size = new Size(22, 21);
            labelInProgress.TabIndex = 4;
            labelInProgress.Text = "...";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(71, 28);
            label3.Name = "label3";
            label3.Size = new Size(96, 21);
            label3.TabIndex = 3;
            label3.Text = "In Progress:";
            // 
            // iconPictureBox3
            // 
            iconPictureBox3.BackColor = Color.FromArgb(45, 45, 68);
            iconPictureBox3.ForeColor = Color.DeepPink;
            iconPictureBox3.IconChar = FontAwesome.Sharp.IconChar.Cog;
            iconPictureBox3.IconColor = Color.DeepPink;
            iconPictureBox3.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconPictureBox3.IconSize = 43;
            iconPictureBox3.Location = new Point(22, 28);
            iconPictureBox3.Name = "iconPictureBox3";
            iconPictureBox3.Size = new Size(43, 43);
            iconPictureBox3.TabIndex = 0;
            iconPictureBox3.TabStop = false;
            // 
            // panelCompleted
            // 
            panelCompleted.BackColor = Color.FromArgb(45, 45, 68);
            panelCompleted.BorderColor = Color.FromArgb(60, 60, 90);
            panelCompleted.BorderThickness = 1;
            panelCompleted.Controls.Add(label14);
            panelCompleted.Controls.Add(labelCompleted);
            panelCompleted.Controls.Add(label4);
            panelCompleted.Controls.Add(iconPictureBox4);
            panelCompleted.CornerRadius = 18;
            panelCompleted.Dock = DockStyle.Fill;
            panelCompleted.Location = new Point(412, 166);
            panelCompleted.Margin = new Padding(12);
            panelCompleted.Name = "panelCompleted";
            panelCompleted.Size = new Size(364, 118);
            panelCompleted.TabIndex = 1;
            // 
            // label14
            // 
            label14.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label14.AutoSize = true;
            label14.ForeColor = Color.White;
            label14.Location = new Point(22, 85);
            label14.Name = "label14";
            label14.Size = new Size(247, 15);
            label14.TabIndex = 7;
            label14.Text = "Show how many requests have been finished.";
            label14.Click += label14_Click;
            // 
            // labelCompleted
            // 
            labelCompleted.AutoSize = true;
            labelCompleted.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelCompleted.ForeColor = Color.White;
            labelCompleted.Location = new Point(71, 50);
            labelCompleted.Name = "labelCompleted";
            labelCompleted.Size = new Size(22, 21);
            labelCompleted.TabIndex = 5;
            labelCompleted.Text = "...";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.White;
            label4.Location = new Point(71, 28);
            label4.Name = "label4";
            label4.Size = new Size(96, 21);
            label4.TabIndex = 4;
            label4.Text = "Completed:";
            // 
            // iconPictureBox4
            // 
            iconPictureBox4.BackColor = Color.FromArgb(45, 45, 68);
            iconPictureBox4.ForeColor = Color.SpringGreen;
            iconPictureBox4.IconChar = FontAwesome.Sharp.IconChar.CheckCircle;
            iconPictureBox4.IconColor = Color.SpringGreen;
            iconPictureBox4.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconPictureBox4.IconSize = 43;
            iconPictureBox4.Location = new Point(22, 28);
            iconPictureBox4.Name = "iconPictureBox4";
            iconPictureBox4.Size = new Size(43, 43);
            iconPictureBox4.TabIndex = 0;
            iconPictureBox4.TabStop = false;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(45, 45, 68);
            panel2.BorderColor = Color.FromArgb(60, 60, 90);
            panel2.BorderThickness = 1;
            tableLayoutPanel1.SetColumnSpan(panel2, 2);
            panel2.Controls.Add(label15);
            panel2.Controls.Add(labelOnHold);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(iconPictureBox5);
            panel2.CornerRadius = 18;
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(24, 308);
            panel2.Margin = new Padding(12);
            panel2.Name = "panel2";
            panel2.Size = new Size(752, 118);
            panel2.TabIndex = 5;
            // 
            // label15
            // 
            label15.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label15.AutoSize = true;
            label15.ForeColor = Color.White;
            label15.Location = new Point(22, 86);
            label15.Name = "label15";
            label15.Size = new Size(276, 15);
            label15.TabIndex = 7;
            label15.Text = "Track that are paused or waiting for parts/approval.";
            // 
            // labelOnHold
            // 
            labelOnHold.AutoSize = true;
            labelOnHold.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelOnHold.ForeColor = Color.White;
            labelOnHold.Location = new Point(71, 49);
            labelOnHold.Name = "labelOnHold";
            labelOnHold.Size = new Size(22, 21);
            labelOnHold.TabIndex = 5;
            labelOnHold.Text = "...";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.White;
            label5.Location = new Point(71, 28);
            label5.Name = "label5";
            label5.Size = new Size(74, 21);
            label5.TabIndex = 4;
            label5.Text = "On-hold:";
            // 
            // iconPictureBox5
            // 
            iconPictureBox5.BackColor = Color.FromArgb(45, 45, 68);
            iconPictureBox5.ForeColor = Color.DarkOrange;
            iconPictureBox5.IconChar = FontAwesome.Sharp.IconChar.Hourglass;
            iconPictureBox5.IconColor = Color.DarkOrange;
            iconPictureBox5.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconPictureBox5.IconSize = 43;
            iconPictureBox5.Location = new Point(22, 28);
            iconPictureBox5.Name = "iconPictureBox5";
            iconPictureBox5.Size = new Size(43, 43);
            iconPictureBox5.TabIndex = 0;
            iconPictureBox5.TabStop = false;
            // 
            // formDashboard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            Name = "formDashboard";
            Text = "Dashboard";
            panel1.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            panelTotalClients.ResumeLayout(false);
            panelTotalClients.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox1).EndInit();
            panelNewToday.ResumeLayout(false);
            panelNewToday.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox2).EndInit();
            panelInProgress.ResumeLayout(false);
            panelInProgress.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox3).EndInit();
            panelCompleted.ResumeLayout(false);
            panelCompleted.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox4).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox5).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private TableLayoutPanel tableLayoutPanel1;
        private RoundedPanel panelTotalClients;
        private RoundedPanel panelCompleted;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox4;
        private RoundedPanel panelInProgress;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox3;
        private RoundedPanel panelNewToday;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox2;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private RoundedPanel panel2;
        private Label label5;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Label labelOnHold;
        private Label labelCompleted;
        private Label labelInProgress;
        private Label labelNewToday;
        private Label labelTotalClient;
        private Label label11;
        private Label label12;
        private Label label13;
        private Label label14;
        private Label label15;
    }
}