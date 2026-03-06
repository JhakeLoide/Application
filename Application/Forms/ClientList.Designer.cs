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
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            panel1 = new Panel();
            labelSortByAll = new Label();
            labelSortByCompleted = new Label();
            labelSortByInProgress = new Label();
            labelSortByOnHold = new Label();
            label3 = new Label();
            label2 = new Label();
            panelTotalClient = new Panel();
            labelTotalClients = new Label();
            iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            label1 = new Label();
            searchBoxClientList = new TextBox();
            iconAddClient = new FontAwesome.Sharp.IconButton();
            dataGridViewClientList = new DataGridView();
            damageReportsBindingSource = new BindingSource(components);
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            ColumnMoreInfo = new DataGridViewButtonColumn();
            panel1.SuspendLayout();
            panelTotalClient.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewClientList).BeginInit();
            ((System.ComponentModel.ISupportInitialize)damageReportsBindingSource).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(24, 24, 38);
            panel1.Controls.Add(labelSortByAll);
            panel1.Controls.Add(labelSortByCompleted);
            panel1.Controls.Add(labelSortByInProgress);
            panel1.Controls.Add(labelSortByOnHold);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
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
            // labelSortByAll
            // 
            labelSortByAll.AutoSize = true;
            labelSortByAll.Cursor = Cursors.Hand;
            labelSortByAll.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelSortByAll.ForeColor = Color.White;
            labelSortByAll.Location = new Point(510, 100);
            labelSortByAll.Name = "labelSortByAll";
            labelSortByAll.Size = new Size(21, 15);
            labelSortByAll.TabIndex = 9;
            labelSortByAll.Text = "All";
            labelSortByAll.Click += labelSortByAll_Click;
            // 
            // labelSortByCompleted
            // 
            labelSortByCompleted.AutoSize = true;
            labelSortByCompleted.Cursor = Cursors.Hand;
            labelSortByCompleted.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelSortByCompleted.ForeColor = Color.White;
            labelSortByCompleted.Location = new Point(439, 101);
            labelSortByCompleted.Name = "labelSortByCompleted";
            labelSortByCompleted.Size = new Size(65, 15);
            labelSortByCompleted.TabIndex = 8;
            labelSortByCompleted.Text = "Completed";
            labelSortByCompleted.Click += labelSortByCompleted_Click;
            // 
            // labelSortByInProgress
            // 
            labelSortByInProgress.AutoSize = true;
            labelSortByInProgress.Cursor = Cursors.Hand;
            labelSortByInProgress.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelSortByInProgress.ForeColor = Color.White;
            labelSortByInProgress.Location = new Point(365, 100);
            labelSortByInProgress.Name = "labelSortByInProgress";
            labelSortByInProgress.Size = new Size(68, 15);
            labelSortByInProgress.TabIndex = 7;
            labelSortByInProgress.Text = "In-Progress";
            labelSortByInProgress.Click += labelSortByInProgress_Click;
            // 
            // labelSortByOnHold
            // 
            labelSortByOnHold.AutoSize = true;
            labelSortByOnHold.Cursor = Cursors.Hand;
            labelSortByOnHold.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelSortByOnHold.ForeColor = Color.White;
            labelSortByOnHold.Location = new Point(305, 100);
            labelSortByOnHold.Name = "labelSortByOnHold";
            labelSortByOnHold.Size = new Size(54, 15);
            labelSortByOnHold.TabIndex = 6;
            labelSortByOnHold.Text = "On-Hold";
            labelSortByOnHold.Click += labelSortByOnHold_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(232, 95);
            label3.Name = "label3";
            label3.Size = new Size(67, 21);
            label3.TabIndex = 5;
            label3.Text = "Sort By:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Consolas", 14F, FontStyle.Bold);
            label2.ForeColor = Color.White;
            label2.Location = new Point(12, 9);
            label2.Name = "label2";
            label2.Size = new Size(100, 22);
            label2.TabIndex = 4;
            label2.Text = "Overview:";
            // 
            // panelTotalClient
            // 
            panelTotalClient.BackColor = Color.FromArgb(48, 47, 86);
            panelTotalClient.Controls.Add(labelTotalClients);
            panelTotalClient.Controls.Add(iconPictureBox1);
            panelTotalClient.Controls.Add(label1);
            panelTotalClient.Location = new Point(12, 57);
            panelTotalClient.Name = "panelTotalClient";
            panelTotalClient.Padding = new Padding(10, 6, 10, 6);
            panelTotalClient.Size = new Size(214, 59);
            panelTotalClient.TabIndex = 3;
            panelTotalClient.Paint += panel2_Paint;
            // 
            // labelTotalClients
            // 
            labelTotalClients.AutoSize = true;
            labelTotalClients.Font = new Font("Consolas", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelTotalClients.ForeColor = Color.WhiteSmoke;
            labelTotalClients.Location = new Point(69, 30);
            labelTotalClients.Name = "labelTotalClients";
            labelTotalClients.Size = new Size(40, 22);
            labelTotalClients.TabIndex = 1;
            labelTotalClients.Text = "...";
            labelTotalClients.TextAlign = ContentAlignment.TopCenter;
            // 
            // iconPictureBox1
            // 
            iconPictureBox1.BackColor = Color.FromArgb(48, 47, 86);
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
            label1.ForeColor = Color.Gainsboro;
            label1.Location = new Point(69, 11);
            label1.Name = "label1";
            label1.Size = new Size(63, 19);
            label1.TabIndex = 0;
            label1.Text = "Total:";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // searchBoxClientList
            // 
            searchBoxClientList.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            searchBoxClientList.BackColor = Color.FromArgb(88, 86, 147);
            searchBoxClientList.BorderStyle = BorderStyle.FixedSingle;
            searchBoxClientList.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            searchBoxClientList.ForeColor = Color.White;
            searchBoxClientList.Location = new Point(12, 402);
            searchBoxClientList.Multiline = true;
            searchBoxClientList.Name = "searchBoxClientList";
            searchBoxClientList.Size = new Size(236, 26);
            searchBoxClientList.TabIndex = 2;
            searchBoxClientList.TextChanged += searchBoxClientList_TextChanged;
            // 
            // iconAddClient
            // 
            iconAddClient.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            iconAddClient.BackColor = Color.FromArgb(60, 59, 100);
            iconAddClient.FlatAppearance.BorderSize = 0;
            iconAddClient.FlatStyle = FlatStyle.Flat;
            iconAddClient.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            iconAddClient.ForeColor = Color.White;
            iconAddClient.IconChar = FontAwesome.Sharp.IconChar.Add;
            iconAddClient.IconColor = Color.White;
            iconAddClient.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconAddClient.IconSize = 32;
            iconAddClient.ImageAlign = ContentAlignment.MiddleLeft;
            iconAddClient.Location = new Point(702, 57);
            iconAddClient.Name = "iconAddClient";
            iconAddClient.Size = new Size(86, 36);
            iconAddClient.TabIndex = 1;
            iconAddClient.Text = "Add";
            iconAddClient.TextImageRelation = TextImageRelation.ImageBeforeText;
            iconAddClient.UseVisualStyleBackColor = false;
            iconAddClient.Click += iconAddClient_Click;
            // 
            // dataGridViewClientList
            // 
            dataGridViewClientList.AllowUserToAddRows = false;
            dataGridViewClientList.AllowUserToResizeColumns = false;
            dataGridViewClientList.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(50, 49, 90);
            dataGridViewClientList.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewClientList.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridViewClientList.BackgroundColor = Color.FromArgb(54, 53, 97);
            dataGridViewClientList.BorderStyle = BorderStyle.None;
            dataGridViewClientList.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewClientList.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(48, 47, 86);
            dataGridViewCellStyle2.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = Color.Snow;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(48, 47, 86);
            dataGridViewCellStyle2.SelectionForeColor = Color.Snow;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dataGridViewClientList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataGridViewClientList.ColumnHeadersHeight = 40;
            dataGridViewClientList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewClientList.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4, ColumnMoreInfo });
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(60, 59, 100);
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 10F);
            dataGridViewCellStyle3.ForeColor = Color.WhiteSmoke;
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(88, 86, 147);
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dataGridViewClientList.DefaultCellStyle = dataGridViewCellStyle3;
            dataGridViewClientList.EnableHeadersVisualStyles = false;
            dataGridViewClientList.GridColor = Color.FromArgb(48, 47, 86);
            dataGridViewClientList.Location = new Point(12, 130);
            dataGridViewClientList.MultiSelect = false;
            dataGridViewClientList.Name = "dataGridViewClientList";
            dataGridViewClientList.ReadOnly = true;
            dataGridViewClientList.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewClientList.RowHeadersVisible = false;
            dataGridViewClientList.RowHeadersWidth = 25;
            dataGridViewCellStyle4.BackColor = Color.FromArgb(54, 53, 97);
            dataGridViewClientList.RowsDefaultCellStyle = dataGridViewCellStyle4;
            dataGridViewClientList.RowTemplate.Height = 36;
            dataGridViewClientList.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewClientList.Size = new Size(776, 253);
            dataGridViewClientList.TabIndex = 0;
            dataGridViewClientList.CellContentClick += dataGridViewClientList_CellContentClick;
            // 
            // damageReportsBindingSource
            // 
            damageReportsBindingSource.DataSource = typeof(App.Domain.Entities.DamageReports);
            // 
            // Column1
            // 
            Column1.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Column1.DataPropertyName = "ClientName";
            Column1.FillWeight = 150F;
            Column1.HeaderText = "Client Name";
            Column1.Name = "Column1";
            Column1.ReadOnly = true;
            // 
            // Column2
            // 
            Column2.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Column2.DataPropertyName = "Status";
            Column2.FillWeight = 125F;
            Column2.HeaderText = "Status";
            Column2.Name = "Column2";
            Column2.ReadOnly = true;
            // 
            // Column3
            // 
            Column3.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Column3.DataPropertyName = "OperatingSystem";
            Column3.FillWeight = 200F;
            Column3.HeaderText = "Operating System";
            Column3.Name = "Column3";
            Column3.ReadOnly = true;
            // 
            // Column4
            // 
            Column4.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Column4.DataPropertyName = "DamageSummary";
            Column4.FillWeight = 150F;
            Column4.HeaderText = "Damage Summary";
            Column4.Name = "Column4";
            Column4.ReadOnly = true;
            // 
            // ColumnMoreInfo
            // 
            ColumnMoreInfo.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            ColumnMoreInfo.FlatStyle = FlatStyle.Flat;
            ColumnMoreInfo.HeaderText = "";
            ColumnMoreInfo.Name = "ColumnMoreInfo";
            ColumnMoreInfo.ReadOnly = true;
            ColumnMoreInfo.Text = "More Info";
            ColumnMoreInfo.UseColumnTextForButtonValue = true;
            ColumnMoreInfo.Width = 5;
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
        private Label labelTotalClients;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private BindingSource damageReportsBindingSource;
        private Label label2;
        private Label label3;
        private Label labelSortByAll;
        private Label labelSortByCompleted;
        private Label labelSortByInProgress;
        private Label labelSortByOnHold;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewButtonColumn ColumnMoreInfo;
    }
}