using BenTech.Managers;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace BenTech.Forms
{
    public partial class DailyPricesForm : Form
    {
        private readonly PricesManager _pricesManager;
        private readonly DatabaseRepository _databaseRepository;

        public DailyPricesForm()
        {
            InitializeComponent();
            _databaseRepository = new DatabaseRepository();
            _pricesManager = new PricesManager(_databaseRepository);

        }

        private void btnCalculatePrices_Click(object sender, EventArgs e)
        {
            PassValuesToEmailForm();
            //Show/hide buttons
            ibtnShowEmail.Visible = true;

            //transform yyyy-MM-dd 00:00:00 to yyyy-MM-dd
            string dateStart = dateTimePicker1.Value.Date.ToString("yyyy-MM-dd");
            string dateEnd = dateTimePicker2.Value.Date.ToString("yyyy-MM-dd");


            var prices = _pricesManager.GetValidatedSumPrices(dateStart, dateEnd);
            if (prices == null) return;
            TimeSpan interval = dateTimePicker2.Value.Date - dateTimePicker1.Value.Date;

            //number of days
            txtNumbOfDays.Text = (interval.Days).ToString();

            //Discount 

            //daily rates
            ctbDailyRateCouple.SetTextBoxText(CalculateTotalPrices(prices.TotalCouple, interval.Days).ToString("c"));
            ctbDailyRateLuxuryCouple.SetTextBoxText(CalculateTotalPrices(prices.TotalCouple, interval.Days, true).ToString("c"));
            ctbDailyRateSingle.SetTextBoxText(CalculateTotalPrices(prices.TotalSingle, interval.Days).ToString("c"));
            ctbDailyRateTriple.SetTextBoxText(CalculateTotalPrices(prices.TotalTriple, interval.Days).ToString("c"));
            ctbDailyRateQuadruple.SetTextBoxText(CalculateTotalPrices(prices.TotalQuadruple, interval.Days).ToString("c"));
            ctbDailyRateQuintuple.SetTextBoxText(CalculateTotalPrices(prices.TotalQuintuple, interval.Days).ToString("c"));

            // txtDailyRateCouple.Text = CalculateTotalPrices(prices.TotalCouple, interval.Days).ToString("c");
            //txtDailyRateLuxuryCouple.Text = CalculateTotalPrices(prices.TotalCouple, interval.Days, true).ToString("c");
            //txtDailyRateSingle.Text = CalculateTotalPrices(prices.TotalSingle, interval.Days).ToString("c");
            //txtDailyRateTriple.Text = CalculateTotalPrices(prices.TotalTriple, interval.Days).ToString("c");
            //txtDailyRateQuadruple.Text = CalculateTotalPrices(prices.TotalQuadruple, interval.Days).ToString("c");
            //txtDailyRateQuintuple.Text = CalculateTotalPrices(prices.TotalQuintuple, interval.Days).ToString("c");

            //total values
            ctbTotalValueCouple.SetTextBoxText(CalculateTotalPrices(prices.TotalCouple).ToString("c"));
            ctbTotalValueLuxuryCouple.SetTextBoxText(CalculateTotalPrices(prices.TotalCouple, 1, true).ToString("c"));
            ctbTotalValueSingle.SetTextBoxText(CalculateTotalPrices(prices.TotalSingle).ToString("c"));
            ctbTotalValueTriple.SetTextBoxText(CalculateTotalPrices(prices.TotalTriple).ToString("c"));
            ctbTotalValueQuadruple.SetTextBoxText(CalculateTotalPrices(prices.TotalQuadruple).ToString("c"));
            ctbTotalValueQuintuple.SetTextBoxText(CalculateTotalPrices(prices.TotalQuintuple).ToString("c"));

            // txtTotalValueCouple.Text = CalculateTotalPrices(prices.TotalCouple).ToString("c");
            // txtTotalRateLuxuryCouple.Text = CalculateTotalPrices(prices.TotalCouple, 1, true).ToString("c");
            // txtTotalValueSingle.Text = CalculateTotalPrices(prices.TotalSingle).ToString("c");
            // txtTotalValueTriple.Text = CalculateTotalPrices(prices.TotalTriple).ToString("c");
            // txtTotalValueQuadruple.Text = CalculateTotalPrices(prices.TotalQuadruple).ToString("c");
            // txtTotalValueQuintuple.Text = CalculateTotalPrices(prices.TotalQuintuple).ToString("c");

            //custom values

            int child03To06 = Int32.Parse(String.IsNullOrEmpty(cbChild03To06.Text) ? "0" : cbChild03To06.Text);
            int child07To10 = Int32.Parse(String.IsNullOrEmpty(cbChild07To10.Text) ? "0" : cbChild07To10.Text);
            int singleCustom = Int32.Parse(String.IsNullOrEmpty(cbSingleCustom.Text) ? "0" : cbSingleCustom.Text);

            double sumChild03To06 = child03To06 * prices.TotalChild03To06;
            double sumChild07To10 = child07To10 * prices.TotalChild07To10;
            double sumSingleCustom = singleCustom * prices.TotalSingle;
            double totalPriceCustom = prices.TotalCouple + sumChild03To06 + sumChild07To10 + sumSingleCustom;

            ctbDailyPriceCustom.SetTextBoxText(CalculateTotalPrices(totalPriceCustom, interval.Days).ToString("c"));
            ctbTotalPriceCustom.SetTextBoxText(CalculateTotalPrices(totalPriceCustom).ToString("c"));

            //txbDailyPriceCustom.Text = CalculateTotalPrices(totalPriceCustom, interval.Days).ToString("c");
            //txbTotalPriceCustom.Text = CalculateTotalPrices(totalPriceCustom).ToString("c");



        }
        private double CalculateTotalPrices(double price, int days = 1, bool luxuryCouple = false)
        {
            double discount = 0.0;
            if (!double.TryParse(txbDiscount.Text, out discount) && !string.IsNullOrEmpty(txbDiscount.Text))
            {
                MessageBox.Show("Desconto inválido. Insira um valor numérico.");
                return price;
            }
            discount *= 0.01;
            double finalPrice = price * (1 - discount);
            return luxuryCouple ? (finalPrice * 1.15) / days : finalPrice / days;
        }
        private void ShowEmail_Click(object sender, EventArgs e)
        {
            ibtnShowEmail.Visible = true;
            PanelPrices.Visible = false;
            DisplayEmailForm();
        }

        private void PassValuesToEmailForm()
        {
            EmailForm emailForm = EmailForm.Instance;

            emailForm.SetDateValues(dateTimePicker1.Value.Date, dateTimePicker2.Value.Date, txtNumbOfDays.Text);

            emailForm.SetRatesValues(
            ctbDailyRateCouple,
            ctbTotalValueCouple,
            ctbDailyRateLuxuryCouple,
            ctbTotalValueLuxuryCouple,
            ctbDailyRateTriple,
            ctbTotalValueTriple,
            ctbDailyRateQuadruple,
            ctbTotalValueQuadruple,
            ctbDailyRateQuintuple,
            ctbTotalValueQuintuple,
            ctbDailyPriceCustom,
            ctbTotalPriceCustom
           );

            emailForm.SetComboBoxValues(cbSingleCustom, cbChild03To06, cbChild07To10);
        }
        public void DisplayEmailForm()
        {
            EmailForm emailForm = EmailForm.Instance;
            emailForm.TopLevel = false;
            emailForm.FormBorderStyle = FormBorderStyle.None;
            emailForm.Dock = DockStyle.Fill;
            this.Controls.Clear();
            this.Controls.Add(emailForm);
            emailForm.Show();
        }

        private void ShowEmail_MouseEnter(object sender, EventArgs e)
        {
            Button currentButton = (Button)sender;
            currentButton.FlatAppearance.BorderColor = Color.FromArgb(23, 178, 237);
            currentButton.ForeColor = Color.FromArgb(23, 178, 237);
        }

        private void ShowEmail_MouseLeave(object sender, EventArgs e)
        {
            Button currentButton = (Button)sender;
            currentButton.FlatAppearance.BorderColor = Color.FromArgb(19, 100, 131);
            currentButton.ForeColor = Color.FromArgb(19, 100, 131);
        }
    }
}


