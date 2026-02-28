namespace Application.Forms
{
    partial class formClientList
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
            components = new System.ComponentModel.Container();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            panel1 = new Panel();
            panel3 = new Panel();
            labelCriticalIssues = new Label();
            iconPictureBox2 = new FontAwesome.Sharp.IconPictureBox();
            label2 = new Label();
            panelTotalClient = new Panel();
            labelTotalClients = new Label();
            iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            label1 = new Label();
            searchBoxClientList = new TextBox();
            iconAddClient = new FontAwesome.Sharp.IconButton();
            dataGridViewClientList = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            ColumnMoreInfo = new DataGridViewButtonColumn();
            damageReportsBindingSource = new BindingSource(components);
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox2).BeginInit();
            panelTotalClient.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewClientList).BeginInit();
            ((System.ComponentModel.ISupportInitialize)damageReportsBindingSource).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(34, 33, 74);
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(panelTotalClient);
            panel1.Controls.Add(searchBoxClientList);
            panel1.Controls.Add(iconAddClient);
            panel1.Controls.Add(dataGridViewClientList);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 450);
            panel1.TabIndex = 0;
            // 
            // panel3
            // 
            panel3.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            panel3.BackColor = Color.FromArgb(110, 110, 149);
            panel3.Controls.Add(labelCriticalIssues);
            panel3.Controls.Add(iconPictureBox2);
            panel3.Controls.Add(label2);
            panel3.Location = new Point(574, 28);
            panel3.Name = "panel3";
            panel3.RightToLeft = RightToLeft.No;
            panel3.Size = new Size(214, 59);
            panel3.TabIndex = 4;
            // 
            // labelCriticalIssues
            // 
            labelCriticalIssues.AutoSize = true;
            labelCriticalIssues.Font = new Font("Consolas", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelCriticalIssues.ForeColor = Color.Red;
            labelCriticalIssues.Location = new Point(67, 30);
            labelCriticalIssues.Name = "labelCriticalIssues";
            labelCriticalIssues.Size = new Size(28, 14);
            labelCriticalIssues.TabIndex = 1;
            labelCriticalIssues.Text = "...";
            labelCriticalIssues.TextAlign = ContentAlignment.TopCenter;
            // 
            // iconPictureBox2
            // 
            iconPictureBox2.BackColor = Color.FromArgb(110, 110, 149);
            iconPictureBox2.ForeColor = Color.Red;
            iconPictureBox2.IconChar = FontAwesome.Sharp.IconChar.Exclamation;
            iconPictureBox2.IconColor = Color.Red;
            iconPictureBox2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconPictureBox2.Location = new Point(20, 12);
            iconPictureBox2.Name = "iconPictureBox2";
            iconPictureBox2.Size = new Size(32, 32);
            iconPictureBox2.TabIndex = 6;
            iconPictureBox2.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Consolas", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(67, 11);
            label2.Name = "label2";
            label2.Size = new Size(144, 19);
            label2.TabIndex = 0;
            label2.Text = "Critical Issues";
            label2.TextAlign = ContentAlignment.TopCenter;
            // 
            // panelTotalClient
            // 
            panelTotalClient.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            panelTotalClient.BackColor = Color.FromArgb(110, 110, 149);
            panelTotalClient.Controls.Add(labelTotalClients);
            panelTotalClient.Controls.Add(iconPictureBox1);
            panelTotalClient.Controls.Add(label1);
            panelTotalClient.Location = new Point(354, 28);
            panelTotalClient.Name = "panelTotalClient";
            panelTotalClient.Size = new Size(214, 59);
            panelTotalClient.TabIndex = 3;
            panelTotalClient.Paint += panel2_Paint;
            // 
            // labelTotalClients
            // 
            labelTotalClients.AutoSize = true;
            labelTotalClients.Font = new Font("Consolas", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelTotalClients.ForeColor = Color.Lime;
            labelTotalClients.Location = new Point(69, 30);
            labelTotalClients.Name = "labelTotalClients";
            labelTotalClients.Size = new Size(40, 22);
            labelTotalClients.TabIndex = 1;
            labelTotalClients.Text = "...";
            labelTotalClients.TextAlign = ContentAlignment.TopCenter;
            // 
            // iconPictureBox1
            // 
            iconPictureBox1.BackColor = Color.FromArgb(110, 110, 149);
            iconPictureBox1.ForeColor = Color.DeepSkyBlue;
            iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.Computer;
            iconPictureBox1.IconColor = Color.DeepSkyBlue;
            iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconPictureBox1.Location = new Point(16, 12);
            iconPictureBox1.Name = "iconPictureBox1";
            iconPictureBox1.Size = new Size(32, 32);
            iconPictureBox1.TabIndex = 5;
            iconPictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Consolas", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(69, 11);
            label1.Name = "label1";
            label1.Size = new Size(126, 19);
            label1.TabIndex = 0;
            label1.Text = "Total Clients";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // searchBoxClientList
            // 
            searchBoxClientList.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            searchBoxClientList.ForeColor = SystemColors.InactiveCaption;
            searchBoxClientList.Location = new Point(12, 412);
            searchBoxClientList.Multiline = true;
            searchBoxClientList.Name = "searchBoxClientList";
            searchBoxClientList.Size = new Size(236, 17);
            searchBoxClientList.TabIndex = 2;
            searchBoxClientList.TextChanged += searchBoxClientList_TextChanged;
            // 
            // iconAddClient
            // 
            iconAddClient.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            iconAddClient.BackColor = Color.DeepSkyBlue;
            iconAddClient.FlatAppearance.BorderSize = 0;
            iconAddClient.FlatStyle = FlatStyle.Flat;
            iconAddClient.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            iconAddClient.ForeColor = Color.White;
            iconAddClient.IconChar = FontAwesome.Sharp.IconChar.Add;
            iconAddClient.IconColor = Color.White;
            iconAddClient.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconAddClient.IconSize = 32;
            iconAddClient.ImageAlign = ContentAlignment.MiddleLeft;
            iconAddClient.Location = new Point(254, 402);
            iconAddClient.Name = "iconAddClient";
            iconAddClient.Size = new Size(81, 36);
            iconAddClient.TabIndex = 1;
            iconAddClient.Text = "Add";
            iconAddClient.TextImageRelation = TextImageRelation.ImageBeforeText;
            iconAddClient.UseVisualStyleBackColor = false;
            iconAddClient.Click += iconAddClient_Click;
            // 
            // dataGridViewClientList
            // 
            dataGridViewClientList.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridViewClientList.BackgroundColor = Color.FromArgb(69, 68, 119);
            dataGridViewClientList.BorderStyle = BorderStyle.None;
            dataGridViewClientList.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dataGridViewClientList.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(69, 68, 119);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = Color.Snow;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(41, 40, 71);
            dataGridViewCellStyle1.SelectionForeColor = Color.Black;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridViewClientList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewClientList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewClientList.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4, ColumnMoreInfo });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.Transparent;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = Color.CornflowerBlue;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dataGridViewClientList.DefaultCellStyle = dataGridViewCellStyle2;
            dataGridViewClientList.EnableHeadersVisualStyles = false;
            dataGridViewClientList.GridColor = Color.FromArgb(69, 68, 119);
            dataGridViewClientList.Location = new Point(12, 130);
            dataGridViewClientList.MultiSelect = false;
            dataGridViewClientList.Name = "dataGridViewClientList";
            dataGridViewClientList.RowHeadersVisible = false;
            dataGridViewClientList.RowHeadersWidth = 25;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(69, 68, 119);
            dataGridViewClientList.RowsDefaultCellStyle = dataGridViewCellStyle3;
            dataGridViewClientList.Size = new Size(776, 253);
            dataGridViewClientList.TabIndex = 0;
            dataGridViewClientList.CellContentClick += dataGridViewClientList_CellContentClick;
            // 
            // Column1
            // 
            Column1.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Column1.DataPropertyName = "ClientName";
            Column1.FillWeight = 150F;
            Column1.HeaderText = "Client Name/ID";
            Column1.Name = "Column1";
            // 
            // Column2
            // 
            Column2.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Column2.DataPropertyName = "Status";
            Column2.FillWeight = 125F;
            Column2.HeaderText = "Status";
            Column2.Name = "Column2";
            // 
            // Column3
            // 
            Column3.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Column3.DataPropertyName = "OperatingSystem";
            Column3.FillWeight = 200F;
            Column3.HeaderText = "Operating System";
            Column3.Name = "Column3";
            // 
            // Column4
            // 
            Column4.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Column4.DataPropertyName = "DamageSummary";
            Column4.FillWeight = 150F;
            Column4.HeaderText = "Damage Summary";
            Column4.Name = "Column4";
            // 
            // ColumnMoreInfo
            // 
            ColumnMoreInfo.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            ColumnMoreInfo.HeaderText = "";
            ColumnMoreInfo.Name = "ColumnMoreInfo";
            ColumnMoreInfo.Text = "More Info";
            ColumnMoreInfo.UseColumnTextForButtonValue = true;
            ColumnMoreInfo.Width = 20;
            // 
            // damageReportsBindingSource
            // 
            damageReportsBindingSource.DataSource = typeof(App.Domain.Entities.DamageReports);
            // 
            // formClientList
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            Name = "formClientList";
            Text = "Client List";
            Load += formClientList_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox2).EndInit();
            panelTotalClient.ResumeLayout(false);
            panelTotalClient.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewClientList).EndInit();
            ((System.ComponentModel.ISupportInitialize)damageReportsBindingSource).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private DataGridView dataGridViewClientList;
        private FontAwesome.Sharp.IconButton iconAddClient;
        private TextBox searchBoxClientList;
        private Panel panelTotalClient;
        private Label label1;
        private Panel panel3;
        private Label label2;
        private Label labelCriticalIssues;
        private Label labelTotalClients;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox2;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private BindingSource damageReportsBindingSource;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewButtonColumn ColumnMoreInfo;
    }
}