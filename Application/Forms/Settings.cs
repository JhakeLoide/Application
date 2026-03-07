using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using Final_Project.Configuration;
using System.Windows.Forms;

namespace Application.Forms
{
    public partial class formSettings : Form
    {
        public formSettings()
        {
            InitializeComponent();
            Load += FormSettings_Load;
            cmbStartupPage.SelectedIndexChanged += CmbStartupPage_SelectedIndexChanged;
        }

        private void FormSettings_Load(object? sender, EventArgs e)
        {
            cmbStartupPage.SelectedItem = AppSettings.StartupPage;
            if (cmbStartupPage.SelectedIndex < 0)
            {
                cmbStartupPage.SelectedIndex = 0;
            }
        }

        private void CmbStartupPage_SelectedIndexChanged(object? sender, EventArgs e)
        {
            if (cmbStartupPage.SelectedItem is string selection)
            {
                AppSettings.StartupPage = selection;
                AppSettings.Save();
            }
        }
    }
}
