namespace Application.Forms
{
    partial class LoadingScreen
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
            panelLoadingScreen = new Panel();
            labelPercentage = new Label();
            progressBar1 = new ColoredProgressBar();
            iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            label1 = new Label();
            panelLoadingScreen.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panelLoadingScreen
            // 
            panelLoadingScreen.BackColor = Color.FromArgb(34, 33, 74);
            panelLoadingScreen.Controls.Add(labelPercentage);
            panelLoadingScreen.Controls.Add(progressBar1);
            panelLoadingScreen.Controls.Add(iconPictureBox1);
            panelLoadingScreen.Controls.Add(label1);
            panelLoadingScreen.Dock = DockStyle.Fill;
            panelLoadingScreen.Location = new Point(0, 0);
            panelLoadingScreen.Name = "panelLoadingScreen";
            panelLoadingScreen.Size = new Size(800, 350);
            panelLoadingScreen.TabIndex = 0;
            // 
            // labelPercentage
            // 
            labelPercentage.AutoSize = true;
            labelPercentage.Font = new Font("Bahnschrift Condensed", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelPercentage.ForeColor = Color.Crimson;
            labelPercentage.Location = new Point(376, 315);
            labelPercentage.Name = "labelPercentage";
            labelPercentage.Size = new Size(42, 19);
            labelPercentage.TabIndex = 3;
            labelPercentage.Text = "label2";
            // 
            // progressBar1
            // 
            progressBar1.Dock = DockStyle.Bottom;
            progressBar1.ForeColor = Color.Crimson;
            progressBar1.Location = new Point(0, 337);
            progressBar1.Name = "progressBar1";
            progressBar1.ProgressColor = Color.Crimson;
            progressBar1.Size = new Size(800, 13);
            progressBar1.TabIndex = 2;
            // 
            // iconPictureBox1
            // 
            iconPictureBox1.BackColor = Color.FromArgb(34, 33, 74);
            iconPictureBox1.ForeColor = Color.Crimson;
            iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.Computer;
            iconPictureBox1.IconColor = Color.Crimson;
            iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconPictureBox1.IconSize = 110;
            iconPictureBox1.Location = new Point(235, 109);
            iconPictureBox1.Name = "iconPictureBox1";
            iconPictureBox1.Size = new Size(111, 110);
            iconPictureBox1.TabIndex = 1;
            iconPictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Bahnschrift SemiBold SemiConden", 48F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Crimson;
            label1.Location = new Point(333, 119);
            label1.Name = "label1";
            label1.Size = new Size(212, 77);
            label1.TabIndex = 0;
            label1.Text = "Display";
            // 
            // LoadingScreen
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 350);
            Controls.Add(panelLoadingScreen);
            FormBorderStyle = FormBorderStyle.None;
            Name = "LoadingScreen";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "LoadingScreen";
            panelLoadingScreen.ResumeLayout(false);
            panelLoadingScreen.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelLoadingScreen;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private Label label1;
        private Label labelPercentage;
        private ColoredProgressBar progressBar1;
    }
}