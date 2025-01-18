using BenTech.Managers;
using BenTech.Models;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace BenTech.Forms
{

    public partial class PredefinedPricesForm : Form
    {
        //events
        public static event Action OnPricesUpdated;

        private PredefinedPricesManager _predefinedPricesManager;
        private Color _newSelectedColor;
        private Color _oldColor;
        internal PredefinedPricesForm()
        {
            InitializeComponent();

        }



        internal PredefinedPricesForm(PredefinedPricesManager predefinedPricesManager)
        {
            _predefinedPricesManager = predefinedPricesManager;
            InitializeComponent();
            panelColor.BackColor = Color.Gray;
        }


        private void PredefinedPricesForm_Load(object sender, EventArgs e)
        {

        }
        public static void NotifyPricesUpdated()
        {
            OnPricesUpdated?.Invoke();
        }
        private void btnColor_Click(object sender, EventArgs e)
        {
            var color = colorDialogPredefinedPrices.ShowDialog();
            if (color == DialogResult.OK)
            {
                _newSelectedColor = colorDialogPredefinedPrices.Color;
                panelColor.BackColor = colorDialogPredefinedPrices.Color;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                // Converte as cores para formato hexadecimal
                string oldColor = $"#{_oldColor.R:X2}{_oldColor.G:X2}{_oldColor.B:X2}";
                string newSelectedColor = $"#{_newSelectedColor.R:X2}{_newSelectedColor.G:X2}{_newSelectedColor.B:X2}";

                var predefinedPrices = new PredefinedPrices
                {
                    Name = ctbName.GetTextBoxText().ToString(),
                    Couple = Convert.ToDouble(ctbCouple.GetTextBoxText()),
                    //Couple = Convert.ToDouble(txtCouple.Text),
                    Single = Convert.ToDouble(ctbSingle.GetTextBoxText()),
                    Triple = Convert.ToDouble(ctbTriple.GetTextBoxText()),
                    Quadruple = Convert.ToDouble(ctbQuadruple.GetTextBoxText()),
                    Quintuple = Convert.ToDouble(ctbQuintuple.GetTextBoxText()),
                    Child03To06 = Convert.ToDouble(ctbChild03To06.GetTextBoxText()),
                    Child07To10 = Convert.ToDouble(ctbChild07To10.GetTextBoxText()),
                    ColorCode = newSelectedColor,
                    OldColorCode = oldColor,
                };
                _predefinedPricesManager.CreateOrUpdatePredefinedPriceDatabase(predefinedPrices);
                this.Close();
                NotifyPricesUpdated();
            }
            catch (Exception)
            {
                Console.WriteLine($"Campos em branco ou incorretos!");
            }
        }

        internal void DisplayToEdit(PredefinedPrices predefinedPrices, PredefinedPricesManager predefinedPricesManager)
        {
            btnDelete.Show();
            panelColor.BackColor = ColorTranslator.FromHtml(predefinedPrices.ColorCode);
            _newSelectedColor = panelColor.BackColor;//same color as oldColor so there's no bug where the _newSelectedColor gets the default color value;
            _oldColor = panelColor.BackColor;
            ctbName.SetTextBoxText(predefinedPrices.Name.ToString());
            ctbCouple.SetTextBoxText(predefinedPrices.Couple.ToString());
            ctbSingle.SetTextBoxText(predefinedPrices.Single.ToString());
            ctbTriple.SetTextBoxText(predefinedPrices.Triple.ToString());
            ctbQuadruple.SetTextBoxText(predefinedPrices.Quadruple.ToString());
            ctbQuintuple.SetTextBoxText(predefinedPrices.Quintuple.ToString());
            ctbChild03To06.SetTextBoxText(predefinedPrices.Child03To06.ToString());
            ctbChild07To10.SetTextBoxText(predefinedPrices.Child07To10.ToString());
            //txtName.Text = predefinedPrices.Name.ToString();
            //txtCouple.Text = predefinedPrices.Couple.ToString();
            //txtSingle.Text = predefinedPrices.Single.ToString();
            //txtTriple.Text = predefinedPrices.Triple.ToString();
            //txtQuadruple.Text = predefinedPrices.Quadruple.ToString();
            //txtQuintuple.Text = predefinedPrices.Quintuple.ToString();
            // txtChild03To06.Text = predefinedPrices.Child03To06.ToString();
            //txtChild07To10.Text = predefinedPrices.Child07To10.ToString();
            _predefinedPricesManager = predefinedPricesManager;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja continuar?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No) return;

            _predefinedPricesManager.DeletePredefinedPrice(ColorTranslator.ToHtml(panelColor.BackColor));
            this.Close();
            NotifyPricesUpdated();
        }

    }
}

