using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace Application.Forms
{
    public class RoundedPanel : Panel
    {
        private int _cornerRadius = 16;

        public int CornerRadius
        {
            get => _cornerRadius;
            set
            {
                _cornerRadius = Math.Max(0, value);
                UpdateRegion();
                Invalidate();
            }
        }

        public Color BorderColor { get; set; } = Color.FromArgb(60, 60, 90);

        public int BorderThickness { get; set; } = 1;

        public RoundedPanel()
        {
            SetStyle(ControlStyles.UserPaint | ControlStyles.AllPaintingInWmPaint | ControlStyles.OptimizedDoubleBuffer | ControlStyles.ResizeRedraw, true);
            BackColor = Color.FromArgb(45, 45, 68);
        }

        protected override void OnSizeChanged(EventArgs e)
        {
            base.OnSizeChanged(e);
            UpdateRegion();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;

            using var path = GetRoundedPath(ClientRectangle, _cornerRadius);
            using var brush = new SolidBrush(BackColor);

            e.Graphics.FillPath(brush, path);

            if (BorderThickness > 0)
            {
                using var pen = new Pen(BorderColor, BorderThickness);
                var borderRect = ClientRectangle;
                borderRect.Inflate(-BorderThickness / 2, -BorderThickness / 2);
                using var borderPath = GetRoundedPath(borderRect, Math.Max(0, _cornerRadius - BorderThickness));
                e.Graphics.DrawPath(pen, borderPath);
            }

            base.OnPaint(e);
        }

        private void UpdateRegion()
        {
            using var path = GetRoundedPath(ClientRectangle, _cornerRadius);
            Region = new Region(path);
        }

        private static GraphicsPath GetRoundedPath(Rectangle bounds, int radius)
        {
            var path = new GraphicsPath();
            if (radius <= 0)
            {
                path.AddRectangle(bounds);
                return path;
            }

            var diameter = radius * 2;
            var arc = new Rectangle(bounds.Location, new Size(diameter, diameter));

            path.AddArc(arc, 180, 90);
            arc.X = bounds.Right - diameter;
            path.AddArc(arc, 270, 90);
            arc.Y = bounds.Bottom - diameter;
            path.AddArc(arc, 0, 90);
            arc.X = bounds.Left;
            path.AddArc(arc, 90, 90);
            path.CloseFigure();

            return path;
        }
    }
}
