using BenTech.Forms.EmailsForms;
using BenTech.UserControls;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace BenTech.Forms
{
    public partial class EmailForm : Form
    {
        // Usando Lazy<T> para garantir inicialização preguiçosa e thread-safe
        private static readonly Lazy<EmailForm> _instance = new Lazy<EmailForm>(() => new EmailForm());

        // Propriedade estática para acessar a instância do singleton
        public static EmailForm Instance => _instance.Value;

        private Button currentBtn;
        // Construtor privado para evitar a criação de múltiplas instâncias
        private EmailForm()
        {
            InitializeComponent();
        }

        // Propriedades em vez de variáveis de campo
        public DateTime DepositReceipt { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public string NumberOfDays { get; set; }
        public string PersonName { get; set; }
        public string ReservationNumber { get; set; }
        public customTextBox CtbDailyRateCouple { get; set; }
        public customTextBox CtbTotalValueCouple { get; set; }
        public customTextBox CtbDailyRateLuxuryCouple { get; set; }
        public customTextBox CtbTotalValueLuxuryCouple { get; set; }
        public customTextBox CtbDailyRateTriple { get; set; }
        public customTextBox CtbTotalValueTriple { get; set; }
        public customTextBox CtbDailyRateQuadruple { get; set; }
        public customTextBox CtbTotalValueQuadruple { get; set; }
        public customTextBox CtbDailyRateQuintuple { get; set; }
        public customTextBox CtbTotalValueQuintuple { get; set; }
        public customTextBox CtbDailyPriceCustom { get; set; }
        public customTextBox CtbTotalPriceCustom { get; set; }
        public ComboBox CbSingleCustom { get; set; }
        public ComboBox CbChild03To06 { get; set; }
        public ComboBox CbChild07To10 { get; set; }

        // Para configurar as propriedades relacionadas a Datas
        public void SetDateValues(DateTime startDate, DateTime endDate, string numberOfDays)
        {
            StartDate = startDate;
            EndDate = endDate;
            NumberOfDays = numberOfDays;
        }

        // Para configurar as propriedades de valores diários e totais
        public void SetRatesValues(
            customTextBox dailyRateCouple, customTextBox totalValueCouple,
            customTextBox dailyRateLuxuryCouple, customTextBox totalValueLuxuryCouple,
            customTextBox dailyRateTriple, customTextBox totalValueTriple,
            customTextBox dailyRateQuadruple, customTextBox totalValueQuadruple,
            customTextBox dailyRateQuintuple, customTextBox totalValueQuintuple,
            customTextBox dailyPriceCustom, customTextBox totalPriceCustom)
        {
            CtbDailyRateCouple = dailyRateCouple;
            CtbTotalValueCouple = totalValueCouple;
            CtbDailyRateLuxuryCouple = dailyRateLuxuryCouple;
            CtbTotalValueLuxuryCouple = totalValueLuxuryCouple;
            CtbDailyRateTriple = dailyRateTriple;
            CtbTotalValueTriple = totalValueTriple;
            CtbDailyRateQuadruple = dailyRateQuadruple;
            CtbTotalValueQuadruple = totalValueQuadruple;
            CtbDailyRateQuintuple = dailyRateQuintuple;
            CtbTotalValueQuintuple = totalValueQuintuple;
            CtbDailyPriceCustom = dailyPriceCustom;
            CtbTotalPriceCustom = totalPriceCustom;
        }

        // Para configurar as ComboBoxes
        public void SetComboBoxValues(ComboBox cbSingleCustom, ComboBox cbChild03To06, ComboBox cbChild07To10)
        {
            CbSingleCustom = cbSingleCustom;
            CbChild03To06 = cbChild03To06;
            CbChild07To10 = cbChild07To10;
        }
        private struct RGBColors
        {
            //base colors
            public static Color color1 = Color.FromArgb(19, 100, 131); //blue dark #136483F2
            public static Color color2 = Color.FromArgb(23, 178, 237);//light blue
        }

        private void ActivateButton(object SenderBtn)
        {
            DisableButton();
            if (SenderBtn != null)
            {
                currentBtn = (Button)SenderBtn;
                currentBtn.ForeColor = RGBColors.color2;
            }
        }

        private void DisableButton()
        {
            if (currentBtn != null)
            {
                currentBtn.ForeColor = RGBColors.color1;
            }
        }
        private void btnQuoteEmail_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            ShowFormInPanel(new QuoteEmailForm());
        }

        private void btnConfirmation_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);          
            ShowFormInPanel(new FormConfirmationEmail());
        }

        private void btnDeposit_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            ShowFormInPanel(new FormEmailDepositSlip());
        }

        private void btnCancellation_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            ShowFormInPanel(new FormCancellations());
        }

        private void button5_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            ShowFormInPanel(new FormChangeReservation());
        }
        private void ShowFormInPanel(Form form)
        {
            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;
            PanelDisplayEmailForms.Controls.Clear();
            PanelDisplayEmailForms.Controls.Add(form);
            form.Show();
        }

        private void btnQuoteEmail_MouseEnter(object sender, EventArgs e)
        {
            if (currentBtn != (Button)sender)
            {
                Button currentButton = (Button)sender;
                currentButton.ForeColor = RGBColors.color2;
            }
        }

     
        private void btnQuoteEmail_MouseLeave(object sender, EventArgs e)
        {
            if (currentBtn != (Button)sender)
            {
                Button currentButton = (Button)sender;
                currentButton.ForeColor = RGBColors.color1;
            }
        }
    }
}
