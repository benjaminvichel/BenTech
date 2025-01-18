using FontAwesome.Sharp;
using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace BenTech.Forms
{
    public partial class FormTestResponsive : Form
    {

        private IconButton currentBtn;
        private Panel leftBorderBtn;
        private Form _currentChildForm;
        private LoginForm loginForm;
        public FormTestResponsive(LoginForm loginForm)
        {
            InitializeComponent();
            this.loginForm = loginForm;

            //cria painel para aparecer na esquerda do menu quando selecionar botao.
            leftBorderBtn = new Panel();
            leftBorderBtn.Size = new Size(7, 60);
            panelMenu.Controls.Add(leftBorderBtn);
            if (!SessionManager.Instance.CurrentUser.Is_admin) { ibtnEmployees.Hide(); ibtnDataBase.Hide(); }
            RemoveTaskBar();
        }
        private void RemoveTaskBar()
        {
            this.Text = string.Empty;
            this.ControlBox = false;
            this.DoubleBuffered = true;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
        }
        //left panel logic for buttons
        private struct RGBColors
        {
            //base colors

            public static Color color1 = Color.FromArgb(23, 178, 237); //blue light #17B2ED
            public static Color color2 = Color.FromArgb(248, 249, 250);//white seasalt
            public static Color color3 = Color.FromArgb(255, 255, 255); //#ffffff white color
            public static Color color4 = Color.FromArgb(240, 240, 240);//  #f0f0f0 anti-flash white


            public static Color color5 = Color.FromArgb(187, 113, 84); //#bb7154
            public static Color color6 = Color.FromArgb(102, 51, 0);//#663300 brown dark
            public static Color color7 = Color.FromArgb(19, 100, 131); //blue dark #136483F2

        }
        private void ActivateButton(object SenderBtn, Color color)
        {
            DisableButton();
            if (SenderBtn != null)
            {
                currentBtn = (IconButton)SenderBtn;
                currentBtn.BackColor = color;
                currentBtn.ForeColor = RGBColors.color1;
                currentBtn.TextAlign = ContentAlignment.MiddleCenter;
                currentBtn.IconColor = RGBColors.color1;
                currentBtn.TextImageRelation = TextImageRelation.TextBeforeImage;
                currentBtn.ImageAlign = ContentAlignment.MiddleRight;
                //left border button
                leftBorderBtn.BackColor = RGBColors.color1;
                leftBorderBtn.Location = new Point(0, currentBtn.Location.Y);
                leftBorderBtn.Visible = true;
                leftBorderBtn.BringToFront();
                //Icon current Child Form
                iconCurrentChildForm.IconChar = currentBtn.IconChar;
                iconCurrentChildForm.IconColor = RGBColors.color1;
            }
        }

        private void DisableButton()
        {
            if (currentBtn != null)
            {
                currentBtn.BackColor = RGBColors.color3;
                currentBtn.ForeColor = RGBColors.color7;
                currentBtn.TextAlign = ContentAlignment.MiddleLeft;
                currentBtn.IconColor = RGBColors.color7;
                currentBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
                currentBtn.ImageAlign = ContentAlignment.MiddleLeft;
            }
        }
        private void ibtnPricesCalculator_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color3);
            OpenChildForm(new DailyPricesForm());
        }
        private void ibtnEmployees_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color3);
            OpenChildForm(new EmployeeForm());
        }
        private void ibtnDataBase_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color3);
            OpenChildForm(new CalendarForm());
        }
        private void Reset()
        {
            DisableButton();
            leftBorderBtn.Visible = false;
            //Icon current Child Form
            iconCurrentChildForm.IconChar = IconChar.Home;
            iconCurrentChildForm.IconColor = RGBColors.color1;
            lblTitleChildForm.Text = "Home";
        }
        //left panel logic for buttons END


        //Drag Form. Serve para arrastar a aplicacao segurando o mouse no panelTitleBar_MouseDown();
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void panelTitleBar_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        private void OpenChildForm(Form childForm)
        {
            if (_currentChildForm != null)
            {
                _currentChildForm?.Hide();
            }
            _currentChildForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelDesktop.Controls.Add(childForm);
            panelDesktop.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            lblTitleChildForm.Text = childForm.Text;
        }

        private void ibLogout_Click(object sender, EventArgs e)
        {
            SessionManager.Instance.Logout();
            this.Hide();
            loginForm.Show();
        }

        private void ibMaximize_Click(object sender, EventArgs e)
        {
            WindowState = WindowState == FormWindowState.Normal ? FormWindowState.Maximized : FormWindowState.Normal;
        }

        private void ibMinimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void ibExitApp_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }



        private void label1_Click(object sender, EventArgs e)
        {
            Reset();
            _currentChildForm?.Hide();
        }

        private void pictureBoxLogo_Click(object sender, EventArgs e)
        {
            Reset();
            _currentChildForm?.Hide();
        }

        private void ibtnPricesCalculator_MouseEnter(object sender, EventArgs e)
        {
            currentBtn = (IconButton)sender;
            currentBtn.BackColor = RGBColors.color4;
        }

        private void ibtnPricesCalculator_MouseLeave(object sender, EventArgs e)
        {
            currentBtn = (IconButton)sender;
            currentBtn.BackColor = RGBColors.color3;
        }

        private void ibtnDataBase_MouseEnter(object sender, EventArgs e)
        {
            if (currentBtn != (IconButton)sender)
            {
                IconButton currentButton = (IconButton)sender;
                currentButton.ForeColor = RGBColors.color1;
                currentButton.IconColor = RGBColors.color1;
            }
        }

        private void ibtnDataBase_MouseLeave(object sender, EventArgs e)
        {
            if (currentBtn != (IconButton)sender)
            {
                IconButton currentButton = (IconButton)sender;
                currentButton.ForeColor = RGBColors.color7;
                currentButton.IconColor = RGBColors.color7;
            }
        }
    }
}


