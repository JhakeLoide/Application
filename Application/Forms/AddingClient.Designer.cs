namespace Application.Forms
{
    partial class formAddingClient
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
            txtBoxAddInfo = new TextBox();
            label6 = new Label();
            txtBoxDeviceModel = new TextBox();
            label5 = new Label();
            txtBoxSummary = new TextBox();
            label4 = new Label();
            dateTimePicker1 = new DateTimePicker();
            label3 = new Label();
            cmbBoxOS = new ComboBox();
            label2 = new Label();
            txtBoxName = new TextBox();
            label1 = new Label();
            btnAdd = new Button();
            btnCancel = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(34, 33, 74);
            panel1.Controls.Add(txtBoxAddInfo);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(txtBoxDeviceModel);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(txtBoxSummary);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(dateTimePicker1);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(cmbBoxOS);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(txtBoxName);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(btnAdd);
            panel1.Controls.Add(btnCancel);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(543, 361);
            panel1.TabIndex = 0;
            // 
            // txtBoxAddInfo
            // 
            txtBoxAddInfo.Location = new Point(188, 207);
            txtBoxAddInfo.Multiline = true;
            txtBoxAddInfo.Name = "txtBoxAddInfo";
            txtBoxAddInfo.Size = new Size(191, 113);
            txtBoxAddInfo.TabIndex = 13;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.ForeColor = Color.White;
            label6.Location = new Point(126, 225);
            label6.Name = "label6";
            label6.Size = new Size(56, 15);
            label6.TabIndex = 12;
            label6.Text = "Add Info:";
            // 
            // txtBoxDeviceModel
            // 
            txtBoxDeviceModel.Location = new Point(188, 93);
            txtBoxDeviceModel.Name = "txtBoxDeviceModel";
            txtBoxDeviceModel.Size = new Size(191, 23);
            txtBoxDeviceModel.TabIndex = 11;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = Color.White;
            label5.Location = new Point(100, 101);
            label5.Name = "label5";
            label5.Size = new Size(82, 15);
            label5.TabIndex = 10;
            label5.Text = "Device Model:";
            // 
            // txtBoxSummary
            // 
            txtBoxSummary.Location = new Point(188, 151);
            txtBoxSummary.Multiline = true;
            txtBoxSummary.Name = "txtBoxSummary";
            txtBoxSummary.Size = new Size(191, 50);
            txtBoxSummary.TabIndex = 9;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = Color.White;
            label4.Location = new Point(92, 166);
            label4.Name = "label4";
            label4.Size = new Size(90, 15);
            label4.TabIndex = 8;
            label4.Text = "Issue Summary:";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(188, 122);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(191, 23);
            dateTimePicker1.TabIndex = 7;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.White;
            label3.Location = new Point(98, 130);
            label3.Name = "label3";
            label3.Size = new Size(84, 15);
            label3.TabIndex = 6;
            label3.Text = "Date Recieved:";
            // 
            // cmbBoxOS
            // 
            cmbBoxOS.FormattingEnabled = true;
            cmbBoxOS.Items.AddRange(new object[] { "Windows 10", "Windows 11", "MacOS", "Linux", "ChromeOS", "Others" });
            cmbBoxOS.Location = new Point(188, 64);
            cmbBoxOS.Name = "cmbBoxOS";
            cmbBoxOS.Size = new Size(191, 23);
            cmbBoxOS.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.White;
            label2.Location = new Point(151, 72);
            label2.Name = "label2";
            label2.Size = new Size(25, 15);
            label2.TabIndex = 4;
            label2.Text = "OS:";
            // 
            // txtBoxName
            // 
            txtBoxName.Location = new Point(188, 35);
            txtBoxName.Name = "txtBoxName";
            txtBoxName.Size = new Size(191, 23);
            txtBoxName.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.White;
            label1.Location = new Point(134, 43);
            label1.Name = "label1";
            label1.Size = new Size(42, 15);
            label1.TabIndex = 2;
            label1.Text = "Name:";
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(202, 326);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(75, 23);
            btnAdd.TabIndex = 1;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(283, 326);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(75, 23);
            btnCancel.TabIndex = 0;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // formAddingClient
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(543, 361);
            Controls.Add(panel1);
            Name = "formAddingClient";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AddingClient";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button btnAdd;
        private Button btnCancel;
        private Label label2;
        private TextBox txtBoxName;
        private Label label1;
        private ComboBox cmbBoxOS;
        private TextBox txtBoxSummary;
        private Label label4;
        private DateTimePicker dateTimePicker1;
        private Label label3;
        private TextBox txtBoxDeviceModel;
        private Label label5;
        private TextBox txtBoxAddInfo;
        private Label label6;
    }
}