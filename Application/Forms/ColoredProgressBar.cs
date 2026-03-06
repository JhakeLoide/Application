using System.Drawing;
using System.Windows.Forms;

namespace Application.Forms
{
    public class ColoredProgressBar : ProgressBar
    {
        public Color ProgressColor { get; set; } = Color.Crimson;

        public ColoredProgressBar()
        {
            SetStyle(ControlStyles.UserPaint, true);
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            var rect = ClientRectangle;
            if (rect.Width <= 0 || rect.Height <= 0)
            {
                return;
            }

            using var backgroundBrush = new SolidBrush(BackColor);
            e.Graphics.FillRectangle(backgroundBrush, rect);

            var percent = Maximum > Minimum
                ? (float)(Value - Minimum) / (Maximum - Minimum)
                : 0f;
            var width = (int)(rect.Width * percent);
            if (width > 0)
            {
                using var progressBrush = new SolidBrush(ProgressColor);
                e.Graphics.FillRectangle(progressBrush, new Rectangle(rect.X, rect.Y, width, rect.Height));
            }
        }
    }
}
