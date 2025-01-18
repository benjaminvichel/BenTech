using BenTech.Forms;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace BenTech
{
    public partial class LoginForm : Form
    {
        DatabaseRepository databaseRepository;
        public LoginForm()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            databaseRepository = new DatabaseRepository();
        }

        private void buttonConnect_Click(object sender, EventArgs e)
        {
            //pega informações de login do user
            string username = customTextBoxUsername.GetTextBoxText();
            string password = customTextBoxPassword.GetTextBoxText();

            if (SessionManager.Instance.Login(username, password))
            {
                // textBoxPassword.Text = null;
                FormTestResponsive formTestResponsive = new FormTestResponsive(this);
                formTestResponsive.Show();
                this.Hide();
            }
        }

        private void labelExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void labelExit_MouseEnter(object sender, EventArgs e)
        {
            Label currentLabel = (Label)sender;
            currentLabel.ForeColor = Color.FromArgb(33, 34, 39);
        }

        private void labelExit_MouseLeave(object sender, EventArgs e)
        {
            Label currentLabel = (Label)sender;
            currentLabel.ForeColor = Color.FromArgb(19, 100, 131);
        }
    }
}
