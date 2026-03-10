namespace Application.Forms
{
    partial class Dashboard_Remake_
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
            tableLayoutPanelMain = new TableLayoutPanel();
            tableLayoutPanelSummary = new TableLayoutPanel();
            roundedPanel1 = new RoundedPanel();
            labelNewToday = new Label();
            label1 = new Label();
            iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            roundedPanel3 = new RoundedPanel();
            labelOnHold = new Label();
            label6 = new Label();
            iconPictureBox3 = new FontAwesome.Sharp.IconPictureBox();
            roundedPanel2 = new RoundedPanel();
            labelInProgress = new Label();
            label4 = new Label();
            iconPictureBox2 = new FontAwesome.Sharp.IconPictureBox();
            roundedPanel4 = new RoundedPanel();
            labelCompleted = new Label();
            label8 = new Label();
            iconPictureBox4 = new FontAwesome.Sharp.IconPictureBox();
            panelWeeklyReport = new RoundedPanel();
            panelWeeklyReportChart = new Panel();
            panelWeeklyReportHeader = new Panel();
            panelWeeklyReportButtons = new FlowLayoutPanel();
            buttonWeekly = new Button();
            buttonMonthly = new Button();
            buttonYearly = new Button();
            labelWeeklyReportTitle = new Label();
            panelOperatingSystem = new RoundedPanel();
            panelOperatingSystemChart = new Panel();
            panelOperatingSystemLegend = new FlowLayoutPanel();
            labelOperatingSystem = new Label();
            panel1.SuspendLayout();
            tableLayoutPanelMain.SuspendLayout();
            tableLayoutPanelSummary.SuspendLayout();
            roundedPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox1).BeginInit();
            roundedPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox3).BeginInit();
            roundedPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox2).BeginInit();
            roundedPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox4).BeginInit();
            panelWeeklyReport.SuspendLayout();
            panelWeeklyReportHeader.SuspendLayout();
            panelWeeklyReportButtons.SuspendLayout();
            panelOperatingSystem.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(24, 24, 38);
            panel1.Controls.Add(tableLayoutPanelMain);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 450);
            panel1.TabIndex = 0;
            // 
            // tableLayoutPanelMain
            // 
            tableLayoutPanelMain.ColumnCount = 3;
            tableLayoutPanelMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanelMain.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 24F));
            tableLayoutPanelMain.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 308F));
            tableLayoutPanelMain.Controls.Add(tableLayoutPanelSummary, 0, 0);
            tableLayoutPanelMain.Controls.Add(panelOperatingSystem, 2, 0);
            tableLayoutPanelMain.Dock = DockStyle.Fill;
            tableLayoutPanelMain.Location = new Point(0, 0);
            tableLayoutPanelMain.Name = "tableLayoutPanelMain";
            tableLayoutPanelMain.Padding = new Padding(24);
            tableLayoutPanelMain.RowCount = 1;
            tableLayoutPanelMain.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanelMain.Size = new Size(800, 450);
            tableLayoutPanelMain.TabIndex = 6;
            // 
            // tableLayoutPanelSummary
            // 
            tableLayoutPanelSummary.ColumnCount = 2;
            tableLayoutPanelSummary.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanelSummary.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanelSummary.Controls.Add(roundedPanel1, 0, 0);
            tableLayoutPanelSummary.Controls.Add(roundedPanel3, 1, 0);
            tableLayoutPanelSummary.Controls.Add(roundedPanel2, 0, 1);
            tableLayoutPanelSummary.Controls.Add(roundedPanel4, 1, 1);
            tableLayoutPanelSummary.Controls.Add(panelWeeklyReport, 0, 2);
            tableLayoutPanelSummary.Dock = DockStyle.Fill;
            tableLayoutPanelSummary.Location = new Point(27, 27);
            tableLayoutPanelSummary.Name = "tableLayoutPanelSummary";
            tableLayoutPanelSummary.RowCount = 3;
            tableLayoutPanelSummary.RowStyles.Add(new RowStyle(SizeType.Absolute, 120F));
            tableLayoutPanelSummary.RowStyles.Add(new RowStyle(SizeType.Absolute, 120F));
            tableLayoutPanelSummary.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanelSummary.Size = new Size(414, 396);
            tableLayoutPanelSummary.TabIndex = 0;
            // 
            // roundedPanel1
            // 
            roundedPanel1.BackColor = Color.FromArgb(45, 45, 68);
            roundedPanel1.BorderColor = Color.FromArgb(60, 60, 90);
            roundedPanel1.BorderThickness = 1;
            roundedPanel1.Controls.Add(labelNewToday);
            roundedPanel1.Controls.Add(label1);
            roundedPanel1.Controls.Add(iconPictureBox1);
            roundedPanel1.CornerRadius = 16;
            roundedPanel1.Dock = DockStyle.Fill;
            roundedPanel1.Location = new Point(0, 0);
            roundedPanel1.Margin = new Padding(0, 0, 12, 12);
            roundedPanel1.Name = "roundedPanel1";
            roundedPanel1.Size = new Size(195, 108);
            roundedPanel1.TabIndex = 0;
            // 
            // labelNewToday
            // 
            labelNewToday.AutoSize = true;
            labelNewToday.ForeColor = Color.White;
            labelNewToday.Location = new Point(95, 62);
            labelNewToday.Name = "labelNewToday";
            labelNewToday.Size = new Size(12, 15);
            labelNewToday.TabIndex = 2;
            labelNewToday.Text = "-";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(95, 31);
            label1.Name = "label1";
            label1.Size = new Size(69, 15);
            label1.TabIndex = 1;
            label1.Text = "New Today:";
            // 
            // iconPictureBox1
            // 
            iconPictureBox1.BackColor = Color.FromArgb(45, 45, 68);
            iconPictureBox1.ForeColor = Color.Cyan;
            iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.User;
            iconPictureBox1.IconColor = Color.Cyan;
            iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconPictureBox1.IconSize = 46;
            iconPictureBox1.Location = new Point(41, 31);
            iconPictureBox1.Name = "iconPictureBox1";
            iconPictureBox1.Size = new Size(46, 46);
            iconPictureBox1.TabIndex = 1;
            iconPictureBox1.TabStop = false;
            // 
            // roundedPanel3
            // 
            roundedPanel3.BackColor = Color.FromArgb(45, 45, 68);
            roundedPanel3.BorderColor = Color.FromArgb(60, 60, 90);
            roundedPanel3.BorderThickness = 1;
            roundedPanel3.Controls.Add(labelOnHold);
            roundedPanel3.Controls.Add(label6);
            roundedPanel3.Controls.Add(iconPictureBox3);
            roundedPanel3.CornerRadius = 16;
            roundedPanel3.Dock = DockStyle.Fill;
            roundedPanel3.Location = new Point(219, 0);
            roundedPanel3.Margin = new Padding(12, 0, 0, 12);
            roundedPanel3.Name = "roundedPanel3";
            roundedPanel3.Size = new Size(195, 108);
            roundedPanel3.TabIndex = 3;
            // 
            // labelOnHold
            // 
            labelOnHold.AutoSize = true;
            labelOnHold.ForeColor = Color.White;
            labelOnHold.Location = new Point(93, 62);
            labelOnHold.Name = "labelOnHold";
            labelOnHold.Size = new Size(12, 15);
            labelOnHold.TabIndex = 2;
            labelOnHold.Text = "-";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.ForeColor = Color.White;
            label6.Location = new Point(93, 31);
            label6.Name = "label6";
            label6.Size = new Size(57, 15);
            label6.TabIndex = 1;
            label6.Text = "On-Hold:";
            // 
            // iconPictureBox3
            // 
            iconPictureBox3.BackColor = Color.FromArgb(45, 45, 68);
            iconPictureBox3.ForeColor = Color.Gold;
            iconPictureBox3.IconChar = FontAwesome.Sharp.IconChar.Hourglass;
            iconPictureBox3.IconColor = Color.Gold;
            iconPictureBox3.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconPictureBox3.IconSize = 45;
            iconPictureBox3.Location = new Point(42, 31);
            iconPictureBox3.Name = "iconPictureBox3";
            iconPictureBox3.Size = new Size(45, 46);
            iconPictureBox3.TabIndex = 1;
            iconPictureBox3.TabStop = false;
            // 
            // roundedPanel2
            // 
            roundedPanel2.BackColor = Color.FromArgb(45, 45, 68);
            roundedPanel2.BorderColor = Color.FromArgb(60, 60, 90);
            roundedPanel2.BorderThickness = 1;
            roundedPanel2.Controls.Add(labelInProgress);
            roundedPanel2.Controls.Add(label4);
            roundedPanel2.Controls.Add(iconPictureBox2);
            roundedPanel2.CornerRadius = 16;
            roundedPanel2.Dock = DockStyle.Fill;
            roundedPanel2.Location = new Point(0, 120);
            roundedPanel2.Margin = new Padding(0, 0, 12, 12);
            roundedPanel2.Name = "roundedPanel2";
            roundedPanel2.Size = new Size(195, 108);
            roundedPanel2.TabIndex = 3;
            // 
            // labelInProgress
            // 
            labelInProgress.AutoSize = true;
            labelInProgress.ForeColor = Color.White;
            labelInProgress.Location = new Point(95, 61);
            labelInProgress.Name = "labelInProgress";
            labelInProgress.Size = new Size(12, 15);
            labelInProgress.TabIndex = 2;
            labelInProgress.Text = "-";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = Color.White;
            label4.Location = new Point(93, 31);
            label4.Name = "label4";
            label4.Size = new Size(70, 15);
            label4.TabIndex = 1;
            label4.Text = "In-Progress:";
            // 
            // iconPictureBox2
            // 
            iconPictureBox2.BackColor = Color.FromArgb(45, 45, 68);
            iconPictureBox2.ForeColor = Color.Yellow;
            iconPictureBox2.IconChar = FontAwesome.Sharp.IconChar.Cog;
            iconPictureBox2.IconColor = Color.Yellow;
            iconPictureBox2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconPictureBox2.IconSize = 45;
            iconPictureBox2.Location = new Point(41, 31);
            iconPictureBox2.Name = "iconPictureBox2";
            iconPictureBox2.Size = new Size(46, 45);
            iconPictureBox2.TabIndex = 1;
            iconPictureBox2.TabStop = false;
            // 
            // roundedPanel4
            // 
            roundedPanel4.BackColor = Color.FromArgb(45, 45, 68);
            roundedPanel4.BorderColor = Color.FromArgb(60, 60, 90);
            roundedPanel4.BorderThickness = 1;
            roundedPanel4.Controls.Add(labelCompleted);
            roundedPanel4.Controls.Add(label8);
            roundedPanel4.Controls.Add(iconPictureBox4);
            roundedPanel4.CornerRadius = 16;
            roundedPanel4.Dock = DockStyle.Fill;
            roundedPanel4.Location = new Point(219, 120);
            roundedPanel4.Margin = new Padding(12, 0, 0, 12);
            roundedPanel4.Name = "roundedPanel4";
            roundedPanel4.Size = new Size(195, 108);
            roundedPanel4.TabIndex = 3;
            // 
            // labelCompleted
            // 
            labelCompleted.AutoSize = true;
            labelCompleted.ForeColor = Color.White;
            labelCompleted.Location = new Point(98, 61);
            labelCompleted.Name = "labelCompleted";
            labelCompleted.Size = new Size(12, 15);
            labelCompleted.TabIndex = 2;
            labelCompleted.Text = "-";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.ForeColor = Color.White;
            label8.Location = new Point(98, 27);
            label8.Name = "label8";
            label8.Size = new Size(69, 15);
            label8.TabIndex = 1;
            label8.Text = "Completed:";
            // 
            // iconPictureBox4
            // 
            iconPictureBox4.BackColor = Color.FromArgb(45, 45, 68);
            iconPictureBox4.ForeColor = Color.Lime;
            iconPictureBox4.IconChar = FontAwesome.Sharp.IconChar.CheckCircle;
            iconPictureBox4.IconColor = Color.Lime;
            iconPictureBox4.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconPictureBox4.IconSize = 45;
            iconPictureBox4.Location = new Point(42, 27);
            iconPictureBox4.Name = "iconPictureBox4";
            iconPictureBox4.Size = new Size(45, 49);
            iconPictureBox4.TabIndex = 1;
            iconPictureBox4.TabStop = false;
            // 
            // panelWeeklyReport
            // 
            panelWeeklyReport.BackColor = Color.FromArgb(45, 45, 68);
            panelWeeklyReport.BorderColor = Color.FromArgb(60, 60, 90);
            panelWeeklyReport.BorderThickness = 1;
            tableLayoutPanelSummary.SetColumnSpan(panelWeeklyReport, 2);
            panelWeeklyReport.Controls.Add(panelWeeklyReportChart);
            panelWeeklyReport.Controls.Add(panelWeeklyReportHeader);
            panelWeeklyReport.CornerRadius = 16;
            panelWeeklyReport.Dock = DockStyle.Fill;
            panelWeeklyReport.Location = new Point(0, 252);
            panelWeeklyReport.Margin = new Padding(0, 12, 0, 0);
            panelWeeklyReport.Name = "panelWeeklyReport";
            panelWeeklyReport.Padding = new Padding(12);
            panelWeeklyReport.Size = new Size(414, 144);
            panelWeeklyReport.TabIndex = 5;
            // 
            // panelWeeklyReportChart
            // 
            panelWeeklyReportChart.BackColor = Color.FromArgb(45, 45, 68);
            panelWeeklyReportChart.Dock = DockStyle.Fill;
            panelWeeklyReportChart.Location = new Point(12, 47);
            panelWeeklyReportChart.Name = "panelWeeklyReportChart";
            panelWeeklyReportChart.Size = new Size(390, 85);
            panelWeeklyReportChart.TabIndex = 1;
            // 
            // panelWeeklyReportHeader
            // 
            panelWeeklyReportHeader.BackColor = Color.FromArgb(45, 45, 68);
            panelWeeklyReportHeader.Controls.Add(panelWeeklyReportButtons);
            panelWeeklyReportHeader.Controls.Add(labelWeeklyReportTitle);
            panelWeeklyReportHeader.Dock = DockStyle.Top;
            panelWeeklyReportHeader.Location = new Point(12, 12);
            panelWeeklyReportHeader.Name = "panelWeeklyReportHeader";
            panelWeeklyReportHeader.Size = new Size(390, 35);
            panelWeeklyReportHeader.TabIndex = 0;
            // 
            // panelWeeklyReportButtons
            // 
            panelWeeklyReportButtons.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            panelWeeklyReportButtons.AutoSize = true;
            panelWeeklyReportButtons.BackColor = Color.FromArgb(45, 45, 68);
            panelWeeklyReportButtons.Controls.Add(buttonWeekly);
            panelWeeklyReportButtons.Controls.Add(buttonMonthly);
            panelWeeklyReportButtons.Controls.Add(buttonYearly);
            panelWeeklyReportButtons.Location = new Point(182, 0);
            panelWeeklyReportButtons.Name = "panelWeeklyReportButtons";
            panelWeeklyReportButtons.Size = new Size(208, 28);
            panelWeeklyReportButtons.TabIndex = 1;
            panelWeeklyReportButtons.WrapContents = false;
            // 
            // buttonWeekly
            // 
            buttonWeekly.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonWeekly.BackColor = Color.FromArgb(60, 60, 90);
            buttonWeekly.FlatAppearance.BorderSize = 0;
            buttonWeekly.FlatStyle = FlatStyle.Flat;
            buttonWeekly.ForeColor = Color.White;
            buttonWeekly.Location = new Point(3, 3);
            buttonWeekly.Name = "buttonWeekly";
            buttonWeekly.Size = new Size(62, 22);
            buttonWeekly.TabIndex = 1;
            buttonWeekly.Text = "Weekly";
            buttonWeekly.UseVisualStyleBackColor = false;
            // 
            // buttonMonthly
            // 
            buttonMonthly.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonMonthly.BackColor = Color.FromArgb(60, 60, 90);
            buttonMonthly.FlatAppearance.BorderSize = 0;
            buttonMonthly.FlatStyle = FlatStyle.Flat;
            buttonMonthly.ForeColor = Color.White;
            buttonMonthly.Location = new Point(71, 3);
            buttonMonthly.Name = "buttonMonthly";
            buttonMonthly.Size = new Size(65, 22);
            buttonMonthly.TabIndex = 2;
            buttonMonthly.Text = "Monthly";
            buttonMonthly.UseVisualStyleBackColor = false;
            // 
            // buttonYearly
            // 
            buttonYearly.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonYearly.BackColor = Color.FromArgb(60, 60, 90);
            buttonYearly.FlatAppearance.BorderSize = 0;
            buttonYearly.FlatStyle = FlatStyle.Flat;
            buttonYearly.ForeColor = Color.White;
            buttonYearly.Location = new Point(142, 3);
            buttonYearly.Name = "buttonYearly";
            buttonYearly.Size = new Size(62, 22);
            buttonYearly.TabIndex = 3;
            buttonYearly.Text = "Yearly";
            buttonYearly.UseVisualStyleBackColor = false;
            // 
            // labelWeeklyReportTitle
            // 
            labelWeeklyReportTitle.AutoSize = true;
            labelWeeklyReportTitle.ForeColor = Color.White;
            labelWeeklyReportTitle.Location = new Point(0, 6);
            labelWeeklyReportTitle.Name = "labelWeeklyReportTitle";
            labelWeeklyReportTitle.Size = new Size(75, 15);
            labelWeeklyReportTitle.TabIndex = 0;
            labelWeeklyReportTitle.Text = "Report Trend";
            // 
            // panelOperatingSystem
            // 
            panelOperatingSystem.BackColor = Color.FromArgb(45, 45, 68);
            panelOperatingSystem.BorderColor = Color.FromArgb(60, 60, 90);
            panelOperatingSystem.BorderThickness = 1;
            panelOperatingSystem.Controls.Add(panelOperatingSystemChart);
            panelOperatingSystem.Controls.Add(panelOperatingSystemLegend);
            panelOperatingSystem.Controls.Add(labelOperatingSystem);
            panelOperatingSystem.CornerRadius = 16;
            panelOperatingSystem.Dock = DockStyle.Fill;
            panelOperatingSystem.Location = new Point(468, 24);
            panelOperatingSystem.Margin = new Padding(0);
            panelOperatingSystem.Name = "panelOperatingSystem";
            panelOperatingSystem.Padding = new Padding(12);
            panelOperatingSystem.Size = new Size(308, 402);
            panelOperatingSystem.TabIndex = 4;
            // 
            // panelOperatingSystemChart
            // 
            panelOperatingSystemChart.BackColor = Color.FromArgb(45, 45, 68);
            panelOperatingSystemChart.Location = new Point(12, 32);
            panelOperatingSystemChart.Name = "panelOperatingSystemChart";
            panelOperatingSystemChart.Size = new Size(284, 237);
            panelOperatingSystemChart.TabIndex = 1;
            // 
            // panelOperatingSystemLegend
            // 
            panelOperatingSystemLegend.AutoScroll = true;
            panelOperatingSystemLegend.BackColor = Color.FromArgb(45, 45, 68);
            panelOperatingSystemLegend.Dock = DockStyle.Bottom;
            panelOperatingSystemLegend.FlowDirection = FlowDirection.TopDown;
            panelOperatingSystemLegend.Location = new Point(12, 205);
            panelOperatingSystemLegend.Name = "panelOperatingSystemLegend";
            panelOperatingSystemLegend.Padding = new Padding(0, 4, 0, 0);
            panelOperatingSystemLegend.Size = new Size(284, 185);
            panelOperatingSystemLegend.TabIndex = 2;
            panelOperatingSystemLegend.WrapContents = false;
            // 
            // labelOperatingSystem
            // 
            labelOperatingSystem.AutoSize = true;
            labelOperatingSystem.Dock = DockStyle.Top;
            labelOperatingSystem.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelOperatingSystem.ForeColor = Color.White;
            labelOperatingSystem.Location = new Point(12, 12);
            labelOperatingSystem.Name = "labelOperatingSystem";
            labelOperatingSystem.Size = new Size(130, 20);
            labelOperatingSystem.TabIndex = 0;
            labelOperatingSystem.Text = "Operating System";
            // 
            // Dashboard_Remake_
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            Name = "Dashboard_Remake_";
            Text = "Dashboard_Remake_";
            panel1.ResumeLayout(false);
            tableLayoutPanelMain.ResumeLayout(false);
            tableLayoutPanelSummary.ResumeLayout(false);
            roundedPanel1.ResumeLayout(false);
            roundedPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox1).EndInit();
            roundedPanel3.ResumeLayout(false);
            roundedPanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox3).EndInit();
            roundedPanel2.ResumeLayout(false);
            roundedPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox2).EndInit();
            roundedPanel4.ResumeLayout(false);
            roundedPanel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox4).EndInit();
            panelWeeklyReport.ResumeLayout(false);
            panelWeeklyReportHeader.ResumeLayout(false);
            panelWeeklyReportHeader.PerformLayout();
            panelWeeklyReportButtons.ResumeLayout(false);
            panelOperatingSystem.ResumeLayout(false);
            panelOperatingSystem.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private TableLayoutPanel tableLayoutPanelMain;
        private TableLayoutPanel tableLayoutPanelSummary;
        private RoundedPanel panelOperatingSystem;
        private Panel panelOperatingSystemChart;
        private FlowLayoutPanel panelOperatingSystemLegend;
        private Label labelOperatingSystem;
        private RoundedPanel roundedPanel1;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private Label label1;
        private RoundedPanel roundedPanel4;
        private Label labelCompleted;
        private Label label8;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox4;
        private RoundedPanel roundedPanel3;
        private Label labelOnHold;
        private Label label6;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox3;
        private RoundedPanel roundedPanel2;
        private Label labelInProgress;
        private Label label4;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox2;
        private Label labelNewToday;
        private RoundedPanel panelWeeklyReport;
        private Panel panelWeeklyReportChart;
        private Panel panelWeeklyReportHeader;
        private FlowLayoutPanel panelWeeklyReportButtons;
        private Button buttonWeekly;
        private Button buttonMonthly;
        private Button buttonYearly;
        private Label labelWeeklyReportTitle;
    }
}