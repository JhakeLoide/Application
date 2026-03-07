using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Application.Forms
{
    public partial class LoadingScreen : Form
    {
        private readonly System.Windows.Forms.Timer _loadingTimer = new();
        private int _progress;

        public event EventHandler? LoadingCompleted;

        public LoadingScreen()
        {
            InitializeComponent();
            labelPercentage.Text = "0%";
            progressBar1.Value = 0;

            _loadingTimer.Interval = 25;
            _loadingTimer.Tick += LoadingTimer_Tick;
            Shown += (_, __) => _loadingTimer.Start();
            FormClosed += (_, __) => _loadingTimer.Dispose();
        }

        private void LoadingTimer_Tick(object? sender, EventArgs e)
        {
            _progress = Math.Min(100, _progress + 2);
            progressBar1.Value = _progress;
            labelPercentage.Text = $"{_progress}%";

            if (_progress >= 100)
            {
                _loadingTimer.Stop();
                LoadingCompleted?.Invoke(this, EventArgs.Empty);
            }
        }

        
    }
}
