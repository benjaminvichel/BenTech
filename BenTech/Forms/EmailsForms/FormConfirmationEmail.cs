using System;
using System.Globalization;
using System.Windows.Forms;

namespace BenTech.Forms.EmailsForms
{
    public partial class FormConfirmationEmail : Form
    {
        EmailForm emailForm = EmailForm.Instance;
        public FormConfirmationEmail()
        {
            InitializeComponent();
        }

        private void ibtnCreateQuoteEmail_Click(object sender, EventArgs e)
        {
            string emailBody = "<html><body>";

            // Formatação do título e cabeçalho
            emailBody += "<style>"
              + "body {font-family: Arial, sans-serif; font-size: 14px; color: #333333;}" // Formatação global
              + "h1 {font-size: 18px; color: #0066cc;}" // Exemplo de formatação para um título
              + "p {font-size: 14px; color: #000000;}" // Formatação de parágrafos
              + ".texto-calibri {" // Classe personalizada
              + "font-family: Calibri; "
              + "font-size: 16px; "
              + "color: rgb(131, 60, 11);"
              + "}"
              + "</style>";


            string personName = ctbPersonName.GetTextBoxText();
            string numberOfDays = emailForm.NumberOfDays;

            string municipalTax = ctbTax.GetTextBoxText();

            DateTime startDate = emailForm.StartDate;
            DateTime endDate = emailForm.EndDate;
            string startDay = startDate.Day.ToString();
            string endDay = startDate.Date == endDate.Date ? endDate.AddDays(1).Day.ToString() : endDate.Day.ToString();
            string month = emailForm.EndDate.Month.ToString();
            string year = emailForm.EndDate.Year.ToString();
            int monthNumber = int.Parse(month);
            string monthName = CultureInfo.CurrentCulture.DateTimeFormat.GetMonthName(monthNumber);

            //reservation number values
            string reservationNumberString = ctbReservationNumber.GetTextBoxText(); ;

            //DepositReceipt values
            string depositReceipt = dtpDeposit.Value.Date.ToString("dd/MM/yyyy");

            //couple
            string roomTypeCouple = emailForm.CtbDailyRateCouple.customText;
            string dailyRateCouple = emailForm.CtbDailyRateCouple.GetTextBoxText() == "∞" ? emailForm.CtbTotalValueCouple.GetTextBoxText() : emailForm.CtbDailyRateCouple.GetTextBoxText();
            string totalValueCouple = emailForm.CtbTotalValueCouple.GetTextBoxText();
            string fiftyPercentTotalValueCouple = GetFiftyPercentValue(emailForm.CtbTotalValueCouple.GetTextBoxText());
            //couple Luxury
            string roomTypeLuxuryCouple = emailForm.CtbDailyRateLuxuryCouple.customText;
            string dailyRateLuxuryCouple = emailForm.CtbDailyRateLuxuryCouple.GetTextBoxText() == "∞" ? emailForm.CtbTotalValueLuxuryCouple.GetTextBoxText() : emailForm.CtbDailyRateLuxuryCouple.GetTextBoxText();
            string totalValueLuxuryCouple = emailForm.CtbTotalValueLuxuryCouple.GetTextBoxText();
            string fiftyPercentTotalValueLuxuryCouple = GetFiftyPercentValue(emailForm.CtbTotalValueLuxuryCouple.GetTextBoxText());
            //Triple
            string roomTypeTriple = emailForm.CtbDailyRateTriple.customText;
            string dailyRateCTriple = emailForm.CtbDailyRateTriple.GetTextBoxText() == "∞" ? emailForm.CtbTotalValueTriple.GetTextBoxText() : emailForm.CtbDailyRateTriple.GetTextBoxText();
            string totalValueTriple = emailForm.CtbTotalValueTriple.GetTextBoxText();
            string fiftyPercentTotalValueTriple = GetFiftyPercentValue(emailForm.CtbTotalValueTriple.GetTextBoxText());
            //Quadruple
            string roomTypeQuadruple = emailForm.CtbDailyRateQuadruple.customText;
            string dailyRateQuadruple = emailForm.CtbDailyRateQuadruple.GetTextBoxText() == "∞" ? emailForm.CtbTotalValueQuadruple.GetTextBoxText() : emailForm.CtbDailyRateQuadruple.GetTextBoxText();
            string totalValueQuadruple = emailForm.CtbTotalValueQuadruple.GetTextBoxText();
            string fiftyPercentTotalValueQuadruple = GetFiftyPercentValue(emailForm.CtbTotalValueQuadruple.GetTextBoxText());
            //Quintuple
            string roomTypeQuintuple = emailForm.CtbDailyRateQuintuple.customText;
            string dailyRateQuintuple = emailForm.CtbDailyRateQuintuple.GetTextBoxText() == "∞" ? emailForm.CtbTotalValueQuintuple.GetTextBoxText() : emailForm.CtbDailyRateQuintuple.GetTextBoxText();
            string totalValueQuintuple = emailForm.CtbTotalValueQuintuple.GetTextBoxText();
            string fiftyPercentTotalValueQuintuple = GetFiftyPercentValue(emailForm.CtbTotalValueQuintuple.GetTextBoxText());

            //roomTypes
            string roomType = "";

            if (checkBoxCouple.Checked)
            {
                roomType += EmailRoomTypeContent(roomTypeCouple, startDay, endDay, monthName, year, totalValueCouple, fiftyPercentTotalValueCouple, municipalTax);
            }
            if (checkBoxLuxuryCouple.Checked)
            {
                roomType += EmailRoomTypeContent(roomTypeLuxuryCouple, startDay, endDay, monthName, year, totalValueCouple, fiftyPercentTotalValueCouple, municipalTax);
            }
            if (checkBoxTriple.Checked)
            {
                roomType += EmailRoomTypeContent(roomTypeTriple, startDay, endDay, monthName, year, totalValueCouple, fiftyPercentTotalValueCouple, municipalTax);
            }
            if (checkBoxQuadruple.Checked)
            {
                roomType += EmailRoomTypeContent(roomTypeQuadruple, startDay, endDay, monthName, year, totalValueCouple, fiftyPercentTotalValueCouple, municipalTax);
            }
            if (checkBoxQuintuple.Checked)
            {
                roomType += EmailRoomTypeContent(roomTypeQuintuple, startDay, endDay, monthName, year, totalValueQuintuple, fiftyPercentTotalValueQuintuple, municipalTax);
            }

            emailBody += "<p class='texto-calibri'>" + EmailBodyContent(personName, roomType, reservationNumberString, depositReceipt) + "</p>";


            emailBody += "</body></html>";

            // Cria o email no Outlook
            Microsoft.Office.Interop.Outlook.Application outlook = new Microsoft.Office.Interop.Outlook.Application();
            Microsoft.Office.Interop.Outlook.MailItem mailItem = (Microsoft.Office.Interop.Outlook.MailItem)outlook.CreateItem(Microsoft.Office.Interop.Outlook.OlItemType.olMailItem);

            mailItem.Subject = "Reservation";
            mailItem.HTMLBody = emailBody;
            mailItem.Display();

        }
        private string GetFiftyPercentValue(string value)
        {
            value = value.Replace("R$", "").Trim();

            return (double.Parse(value) * 0.5).ToString("F2");
        }
        private string EmailRoomTypeContent(string roomType, string dateStart, string dateEnd, string month, string year,
           string totalValue, string fiftyPercent, string municipalTax)
        {
            return $"<br><br> <b>Reservation for { roomType}. Check-in: { dateStart} and check-out in { dateEnd}/{ month}/{ year}.</b>" +
                $"<br><br>Total price: R$: {totalValue}. Deposito R$: {fiftyPercent}." +
                $"<br><br> Municiapl Tax: R$ {municipalTax}";
        }
        private string EmailBodyContent(string personName, string roomType, string reservationNumber, string depositReceipt)
        {

            return $"Olá!" +

                $"<br><br>{personName}," +

                $"{roomType}" +

                $"<br><br> {reservationNumber}"+

                $"<br><br> {depositReceipt}";


        }
    }
}
