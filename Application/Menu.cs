using FontAwesome.Sharp;
using System;
using System.Drawing;
using System.Windows.Forms;
namespace Final_Project
{
    public partial class Menu : Form
    {
        //Fields
        private IconButton? currentBtn;
        private Panel leftBorderBtn;
        private bool menuCollapsed = false;
        private const int menuExpandedWidth = 220;
        private const int menuCollapsedWidth = 60;
        private System.Windows.Forms.Timer? menuAnimationTimer;
        private int animationStep = 10;

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

            iconButton1.Click += iconButton1_Click;
            iconButton2.Click += iconButton2_Click;
            iconButton3.Click += iconButton3_Click;
            iconButton4.Click += iconButton4_Click;
            iconButton5.Click += iconButton5_Click;
            iconButton6.Click += iconButton6_Click;
            iconButton10.Click += iconButton10_Click;

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
            public static Color color4 = Color.FromArgb(95, 77, 221);
            public static Color color5 = Color.FromArgb(249, 88, 155);
            public static Color color6 = Color.FromArgb(24, 161, 251);
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

        private void iconButton1_Click(object? sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color1);
        }

        private void iconButton2_Click(object? sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color2);
        }
        private void iconButton3_Click(object? sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color3);
        }
        private void iconButton4_Click(object? sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color4);
        }

        private void iconButton5_Click(object? sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color5);
        }
        private void iconButton6_Click(object? sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color6);

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
                Application.Exit();
            }
        }

        private void Menu_MouseDown(object? sender, MouseEventArgs e)
        {

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
            iconButton1.Text = "";
            iconButton2.Text = "";
            iconButton3.Text = "";
            iconButton4.Text = "";
            iconButton5.Text = "";
            iconButton6.Text = "";
            label1.Visible = false;
            SetMenuButtonLayout(isCollapsed: true);
        }

        private void ShowMenuText()
        {
            iconButton1.Text = "Dashboard";
            iconButton2.Text = "suggestion?";
            iconButton3.Text = "suggestion?";
            iconButton4.Text = "Client List";
            iconButton5.Text = "suggestion?";
            iconButton6.Text = "Settings";
            label1.Visible = true;
            SetMenuButtonLayout(isCollapsed: false);
        }

        private void SetMenuButtonLayout(bool isCollapsed)
        {
            var imageAlign = isCollapsed ? ContentAlignment.MiddleCenter : ContentAlignment.MiddleLeft;
            var textAlign = isCollapsed ? ContentAlignment.MiddleCenter : ContentAlignment.MiddleLeft;
            var textImageRelation = isCollapsed ? TextImageRelation.Overlay : TextImageRelation.ImageBeforeText;

            iconButton1.ImageAlign = imageAlign;
            iconButton2.ImageAlign = imageAlign;
            iconButton3.ImageAlign = imageAlign;
            iconButton4.ImageAlign = imageAlign;
            iconButton5.ImageAlign = imageAlign;
            iconButton6.ImageAlign = imageAlign;

            iconButton1.TextAlign = textAlign;
            iconButton2.TextAlign = textAlign;
            iconButton3.TextAlign = textAlign;
            iconButton4.TextAlign = textAlign;
            iconButton5.TextAlign = textAlign;
            iconButton6.TextAlign = textAlign;

            iconButton1.TextImageRelation = textImageRelation;
            iconButton2.TextImageRelation = textImageRelation;
            iconButton3.TextImageRelation = textImageRelation;
            iconButton4.TextImageRelation = textImageRelation;
            iconButton5.TextImageRelation = textImageRelation;
            iconButton6.TextImageRelation = textImageRelation;
        }


    }
}


