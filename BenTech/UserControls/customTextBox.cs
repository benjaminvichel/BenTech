using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace BenTech.UserControls
{
    public partial class customTextBox : UserControl
    {
   

        bool isFocused = false;
        private string text = "Text";
        private bool pass = false;
        private TextAlign textAlignment = TextAlign.Left;

        public customTextBox()
        {
            InitializeComponent();
        }
        public enum TextAlign
        {
            Left,
            Center,
            Right
        }

        [Category("Custom Properties")]
        [Description("Give a name to your textBox")]
        public string customText
        {
            get { return text; }
            set
            {
                text = value;
                this.Invalidate();
            }
        }
        private void customTextBox_Paint(object sender, PaintEventArgs e)
        {
            label1.Text = customText;
        }
        [Category("Custom Properties")]
        [Description("Defines the text alignment.")]
        public TextAlign CustomTextAlign
        {
            get { return textAlignment; }
            set
            {
                textAlignment = value;
                UpdateTextAlign();
                this.Invalidate(); // Redesenha o controle
            }
        }

        private void UpdateTextAlign()
        {
            switch (textAlignment)
            {
                case TextAlign.Left:
                    textBox1.TextAlign = HorizontalAlignment.Left;

                    break;
                case TextAlign.Center:
                    textBox1.TextAlign = HorizontalAlignment.Center;

                    break;
                case TextAlign.Right:
                    textBox1.TextAlign = HorizontalAlignment.Right;
                    break;
            }
        }

        private bool textBoxSize = false;
        [Category("Custom Properties")]
        [Description("Changes textBox Size and Point to the Right")]

        public bool changeTextBoxSize
        {
            get { return textBoxSize; }
            set
            {
                textBoxSize = value;
                ChangeTextBoxSize();
                this.Invalidate();
            }
        }



        private void ChangeTextBoxSize()
        {
            if (!textBoxSize)
            {
                textBox1.Location = new Point(19, 19);
                textBox1.Size = new Size(256, 18);
                return;
            }
            textBox1.Size = new Size(185, 18);
            textBox1.Location = new Point(97, 19);
        }



        [Category("Custom Properties")]
        [Description("Changes display to *.")]
        public bool password
        {
            get { return pass; }
            set
            {
                pass = value;
                UpdatePasswordChar(); // Atualiza o estado do campo de senha
                this.Invalidate();
            }
        }

        private void customTextBox_Load(object sender, EventArgs e)
        {
            UpdatePasswordChar(); // Garantir que o campo de senha esteja configurado corretamente ao carregar
        }
        private void UpdatePasswordChar()
        {
            textBox1.UseSystemPasswordChar = password;  //Does not work with Multiline Property = True
        }

        private void lblTimer_Tick(object sender, EventArgs e)
        {
            int y = label1.Location.Y;
            if (!isFocused)
            {
                y -= 2;
                label1.Location = new Point(label1.Location.X, y);
                if (y <= 6)
                {
                    isFocused = true;
                    lblTimer.Stop();

                    y = 6;
                    label1.ForeColor = Color.Silver;
                }
            }
            else
            {
                y += 2;
                label1.Location = new Point(label1.Location.X, y);
                if (y >= 19)
                {
                    isFocused = false;
                    lblTimer.Stop();

                    y = 19;
                    label1.ForeColor = Color.Black;
                }
            }
        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            changeTextBoxSize = string.IsNullOrEmpty(textBox1.Text) ? false : true;
            lblTimer.Start();
        }


        private void textBox1_Leave(object sender, EventArgs e)
        {
            changeTextBoxSize = string.IsNullOrEmpty(textBox1.Text) ? false : true;
            lblTimer.Start();
        }

        public string GetTextBoxText()
        {
            return textBox1.Text;
        }
        public void SetTextBoxText(string text)
        {
            textBox1.Text = text;
        }
    }
}