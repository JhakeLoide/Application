using Application.Forms;
using FontAwesome.Sharp;
using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;
namespace Final_Project
{
    public partial class Menu : Form
    {
        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        private static extern bool ReleaseCapture();

        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        private static extern IntPtr SendMessage(IntPtr hWnd, int msg, int wParam, int lParam);

        private const int WmNclButtonDown = 0xA1;
        private const int HtCaption = 0x2;

        //Fields
        private IconButton? currentBtn;
        private Panel leftBorderBtn;
        private bool menuCollapsed = false;
        private const int menuExpandedWidth = 220;
        private const int menuCollapsedWidth = 60;
        private System.Windows.Forms.Timer? menuAnimationTimer;
        private int animationStep = 10;
        private Form? currentChildForm;
        private Rectangle restoreBounds;
        private bool isSnapped;
        private const int SnapThreshold = 5;

        //Constructor
        public Menu()
        {
            InitializeComponent();
            FormBorderStyle = FormBorderStyle.None;
            ControlBox = false;
            MinimizeBox = false;
            MaximizeBox = false;
            leftBorderBtn = new Panel();
            leftBorderBtn.Size = new Size(7, 60);

            leftBorderBtn.Visible = false;
            leftBorderBtn.Enabled = false;
            panelMenu.Controls.Add(leftBorderBtn);

            iconButtonHome.Dock = DockStyle.Top;
            iconButtonHome.Height = btnDashboard.Height;

            btnDashboard.Click += iconButton1_Click;
            btnClientList.Click += iconButton2_Click;
            btnSettings.Click += iconButton3_Click;
            btnReports.Click += btnReports_Click;
            iconButton10.Click += iconButton10_Click;
            iconButtonHome.Click += iconButtonHome_Click;
            panelTitle.MouseDown += Menu_MouseDown;
            panelTitle.MouseUp += Menu_MouseUp;
            MouseUp += Menu_MouseUp;

            // Initialize animation timer
            menuAnimationTimer = new System.Windows.Forms.Timer();
            menuAnimationTimer.Interval = 10;
            menuAnimationTimer.Tick += MenuAnimationTimer_Tick;
        }

        private struct RGBColors
        {
            public static Color color1 = Color.FromArgb(172, 126, 241);
            public static Color color2 = Color.FromArgb(249, 118, 176);
            public static Color color3 = Color.FromArgb(253, 138, 114);
            public static Color color4 = Color.SpringGreen;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void panelLogo_Paint(object? sender, PaintEventArgs e)
        {

        }
        private void ActivateButton(object senderBtn, Color color)
        {
            if (senderBtn != null)
            {

                DisableButton();

                //Button - only change colors so layout (icon/text positions) stays constant
                currentBtn = (IconButton)senderBtn;
                currentBtn.BackColor = Color.FromArgb(37, 36, 81);
                currentBtn.ForeColor = color;
                currentBtn.IconColor = color;

                //Left border button
                leftBorderBtn.BackColor = color;
                leftBorderBtn.Location = new Point(0, currentBtn.Location.Y);
                leftBorderBtn.Visible = true;
                leftBorderBtn.BringToFront();

                //Icon Static
                iconStatic.IconChar = currentBtn.IconChar;
                iconStatic.IconColor = color;

                //Label Static
                lblStatic.ForeColor = color;

            }
        }

        private void DisableButton()
        {
            if (currentBtn != null)
            {

                // restore original colors only; keep alignment/layout as designed
                currentBtn.BackColor = Color.FromArgb(31, 30, 68);
                currentBtn.ForeColor = Color.Gainsboro;
                currentBtn.IconColor = Color.Gainsboro;

            }
        }

        private void OpenChildForm(Form childForm)
        {
            if (currentChildForm != null)
            {
                //open only form 
                currentChildForm.Close();
            }
            currentChildForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelDesktop.Controls.Add(childForm);
            panelDesktop.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            lblStatic.Text = childForm.Text;
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color1);
            OpenChildForm(new formDashboard());
        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color2);
            OpenChildForm(new formClientList());
        }
        private void iconButton3_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color3);
            OpenChildForm(new formSettings());
        }

        private void btnReports_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color4);
            OpenChildForm(new Reports());
        }

        private void iconButtonHome_Click(object sender, EventArgs e)
        {
            if (currentChildForm != null)
            {
                currentChildForm.Close();
                currentChildForm = null;
            }

            panelDesktop.Controls.Clear();
            Reset();
            iconStatic.IconColor = iconButtonHome.IconColor;
            lblStatic.ForeColor = iconButtonHome.IconColor;
        }
        private void Reset()
        {
            DisableButton();
            leftBorderBtn.Visible = false;
            iconStatic.IconChar = IconChar.Home;
            iconStatic.IconColor = Color.MediumPurple;
            lblStatic.Text = "Home";

        }

        private void iconButton9_Click(object? sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void iconButton8_Click_1(object? sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
                WindowState = FormWindowState.Maximized;
            else
                WindowState = FormWindowState.Normal;
        }

        private void iconButton7_Click_1(object? sender, EventArgs e)
        {
            var result = MessageBox.Show(
                "Are you sure you want to exit?",
                "Exit",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                System.Windows.Forms.Application.Exit();
            }
        }

        private void Menu_MouseDown(object? sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left)
            {
                return;
            }

            if (isSnapped)
            {
                RestoreFromSnap();
            }

            ReleaseCapture();
            SendMessage(Handle, WmNclButtonDown, HtCaption, 0);
        }

        private void Menu_MouseUp(object? sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left)
            {
                return;
            }

            SnapToScreenEdges();
        }

        private void SnapToScreenEdges()
        {
            var workingArea = Screen.FromControl(this).WorkingArea;
            var bounds = Bounds;

            var nearLeft = bounds.Left <= workingArea.Left + SnapThreshold;
            var nearTop = bounds.Top <= workingArea.Top + SnapThreshold;
            var nearRight = bounds.Right >= workingArea.Right - SnapThreshold;
            var nearBottom = bounds.Bottom >= workingArea.Bottom - SnapThreshold;

            if (nearLeft || nearTop || nearRight || nearBottom)
            {
                if (!isSnapped)
                {
                    restoreBounds = bounds;
                }

                Bounds = workingArea;
                isSnapped = true;
            }
        }

        private void RestoreFromSnap()
        {
            if (restoreBounds == Rectangle.Empty)
            {
                restoreBounds = new Rectangle(Location, Size);
            }

            var cursor = Cursor.Position;
            var workingArea = Screen.FromControl(this).WorkingArea;
            var relativeX = (double)(cursor.X - workingArea.Left) / workingArea.Width;
            var newX = cursor.X - (int)(restoreBounds.Width * relativeX);
            var newY = cursor.Y - (int)(restoreBounds.Height * 0.1);

            Bounds = new Rectangle(newX, newY, restoreBounds.Width, restoreBounds.Height);
            isSnapped = false;
        }

        private void iconButton10_Click(object? sender, EventArgs e)
        {
            menuAnimationTimer?.Start();
        }

        private void MenuAnimationTimer_Tick(object? sender, EventArgs e)
        {
            if (menuCollapsed)
            {
                // Expanding
                panelMenu.Width += animationStep;
                if (panelMenu.Width >= menuExpandedWidth)
                {
                    panelMenu.Width = menuExpandedWidth;
                    menuAnimationTimer?.Stop();
                    menuCollapsed = false;
                    ShowMenuText();
                }
            }
            else
            {
                // Collapsing
                panelMenu.Width -= animationStep;
                if (panelMenu.Width <= menuCollapsedWidth)
                {
                    panelMenu.Width = menuCollapsedWidth;
                    menuAnimationTimer?.Stop();
                    menuCollapsed = true;
                    HideMenuText();
                }
            }
        }

        private void HideMenuText()
        {
            btnDashboard.Text = "";
            btnClientList.Text = "";
            btnSettings.Text = "";
            btnReports.Text = "";
            iconButtonHome.Text = "";
            SetMenuButtonLayout(isCollapsed: true);
        }

        private void ShowMenuText()
        {
            btnDashboard.Text = "Dashboard";
            btnClientList.Text = "Client List";
            btnSettings.Text = "Settings";
            btnReports.Text = "Reports";
            iconButtonHome.Text = "PC Monitor";
            SetMenuButtonLayout(isCollapsed: false);
        }

        private void SetMenuButtonLayout(bool isCollapsed)
        {
            var imageAlign = isCollapsed ? ContentAlignment.MiddleCenter : ContentAlignment.MiddleLeft;
            var textAlign = isCollapsed ? ContentAlignment.MiddleCenter : ContentAlignment.MiddleLeft;
            var textImageRelation = isCollapsed ? TextImageRelation.Overlay : TextImageRelation.ImageBeforeText;

            btnDashboard.ImageAlign = imageAlign;
            btnClientList.ImageAlign = imageAlign;
            btnSettings.ImageAlign = imageAlign;
            btnReports.ImageAlign = imageAlign;
            iconButtonHome.ImageAlign = imageAlign;
            iconButton10.ImageAlign = imageAlign;

            btnDashboard.TextAlign = textAlign;
            btnClientList.TextAlign = textAlign;
            btnSettings.TextAlign = textAlign;
            btnReports.TextAlign = textAlign;
            iconButtonHome.TextAlign = textAlign;

            btnDashboard.TextImageRelation = textImageRelation;
            btnClientList.TextImageRelation = textImageRelation;
            btnSettings.TextImageRelation = textImageRelation;
            btnReports.TextImageRelation = textImageRelation;
            iconButtonHome.TextImageRelation = textImageRelation;
        }

        private void lblStatic_Click(object sender, EventArgs e)
        {

        }
    }
}


