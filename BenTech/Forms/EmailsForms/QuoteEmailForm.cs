using System;
using System.Globalization;
using System.Windows.Forms;

namespace BenTech.Forms.EmailsForms
{
    public partial class QuoteEmailForm : Form
    {
        EmailForm emailForm = EmailForm.Instance;
        public QuoteEmailForm()
        {
            InitializeComponent();
        }
        private void ibtnCreateQuoteEmail_Click(object sender, EventArgs e)
        {
            string emailBody = "<html><body>";

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
            string numberOfDays = emailForm.PersonName;
            string municipalTax = ctbTax.GetTextBoxText();

            DateTime startDate = emailForm.StartDate;
            DateTime endDate = emailForm.EndDate;
            string startDay = startDate.Day.ToString();
            string endDay = startDate.Date == endDate.Date ? endDate.AddDays(1).Day.ToString() : endDate.Day.ToString();
            string month = emailForm.EndDate.Month.ToString();
            string year = emailForm.EndDate.Year.ToString();
            int monthNumber = int.Parse(month);
            string monthName = CultureInfo.CurrentCulture.DateTimeFormat.GetMonthName(monthNumber);

            //couple
            string roomTypeCouple = emailForm.CtbDailyRateCouple.customText;
            string dailyRateCouple = emailForm.CtbDailyRateCouple.GetTextBoxText() == "∞" ? emailForm.CtbTotalValueCouple.GetTextBoxText() : emailForm.CtbDailyRateCouple.GetTextBoxText();
            string totalValueCouple = emailForm.CtbTotalValueCouple.GetTextBoxText();
            //LuxuryCouple
            string roomTypeLuxuryCouple = emailForm.CtbDailyRateLuxuryCouple.customText;
            string dailyRateLuxuryCouple = emailForm.CtbDailyRateLuxuryCouple.GetTextBoxText() == "∞" ? emailForm.CtbTotalValueLuxuryCouple.GetTextBoxText() : emailForm.CtbDailyRateLuxuryCouple.GetTextBoxText();
            string totalValueLuxuryCouple = emailForm.CtbTotalValueLuxuryCouple.GetTextBoxText();
            //triple
            string roomTypeTriple = emailForm.CtbDailyRateTriple.customText;
            string dailyRateTriple = emailForm.CtbDailyRateTriple.GetTextBoxText() == "∞" ? emailForm.CtbTotalValueTriple.GetTextBoxText() : emailForm.CtbDailyRateTriple.GetTextBoxText();
            string totalValueTriple = emailForm.CtbTotalValueTriple.GetTextBoxText();
            //Quadruple
            string roomTypeQuadruple = emailForm.CtbDailyRateQuadruple.customText;
            string dailyRateQuadruple = emailForm.CtbDailyRateQuadruple.GetTextBoxText() == "∞" ? emailForm.CtbTotalValueQuadruple.GetTextBoxText() : emailForm.CtbDailyRateQuadruple.GetTextBoxText();
            string totalValueQuadruple = emailForm.CtbTotalValueQuadruple.GetTextBoxText();
            //Quintuple
            string roomTypeQuintuple = emailForm.CtbDailyRateQuintuple.customText;
            string dailyRateQuintuple = emailForm.CtbDailyRateQuintuple.GetTextBoxText() == "∞" ? emailForm.CtbTotalValueQuintuple.GetTextBoxText() : emailForm.CtbDailyRateQuintuple.GetTextBoxText();
            string totalValueQuintuple = emailForm.CtbTotalValueQuintuple.GetTextBoxText();
            //Custom
            string NumberOfSingles = emailForm.CbSingleCustom.Text;
            string NumberOfChild03To06 = emailForm.CbChild03To06.Text;
            string NumberOfChild07To10 = emailForm.CbChild07To10.Text;
            string dailyRateCustom = emailForm.CtbDailyPriceCustom.GetTextBoxText() == "∞" ? emailForm.CtbTotalPriceCustom.GetTextBoxText() : emailForm.CtbDailyPriceCustom.GetTextBoxText();
            string totalValueCustom = emailForm.CtbTotalPriceCustom.GetTextBoxText();
            NumberOfSingles = !string.IsNullOrEmpty(NumberOfSingles) ? $" + {NumberOfSingles} solteiro(s)" : "";
            NumberOfChild03To06 = !string.IsNullOrEmpty(NumberOfChild03To06) ? $" + {NumberOfChild03To06} criança(s) de 03 a 06 anos" : "";
            NumberOfChild07To10 = !string.IsNullOrEmpty(NumberOfChild07To10) ? $" + {NumberOfChild07To10} criança(s) de 07 a 10 anos" : "";


            //roomTypes
            string roomType = "";

            if (checkBoxCouple.Checked)
            {
                roomType += EmailRoomTypeContent(roomTypeCouple, dailyRateCouple, totalValueCouple, municipalTax, numberOfDays);
            }
            if (checkBoxLuxuryCouple.Checked)
            {
                roomType += EmailRoomTypeContent(roomTypeLuxuryCouple, dailyRateLuxuryCouple, totalValueLuxuryCouple, municipalTax, numberOfDays);
            }
            if (checkBoxTriple.Checked)
            {
                roomType += EmailRoomTypeContent(roomTypeTriple, dailyRateTriple, totalValueTriple, municipalTax, numberOfDays);
            }
            if (checkBoxQuadruple.Checked)
            {
                roomType += EmailRoomTypeContent(roomTypeQuadruple, dailyRateQuadruple, totalValueQuadruple, municipalTax, numberOfDays);
            }
            if (checkBoxQuintuple.Checked)
            {
                roomType += EmailRoomTypeContent(roomTypeQuintuple, dailyRateQuintuple, totalValueQuintuple, municipalTax, numberOfDays);
            }
            if (checkBoxCustom.Checked)
            {
                string customype = roomTypeCouple + NumberOfSingles + NumberOfChild03To06 + NumberOfChild07To10;//custom will always have Couple.
                roomType += EmailRoomTypeContent(customype, dailyRateCustom, totalValueCustom, municipalTax, numberOfDays);
            }


            //--------------------------------------------------------------------------------------     
            emailBody += "<p class='texto-calibri'>" + EmailBodyContent(personName, startDay, endDay, monthName, year, roomType) + "</p>";
            // Finaliza o corpo do email
            emailBody += "</body></html>";

            // Cria o email no Outlook
            Microsoft.Office.Interop.Outlook.Application outlook = new Microsoft.Office.Interop.Outlook.Application();
            Microsoft.Office.Interop.Outlook.MailItem mailItem = (Microsoft.Office.Interop.Outlook.MailItem)outlook.CreateItem(Microsoft.Office.Interop.Outlook.OlItemType.olMailItem);

            mailItem.Subject = "Reserva";
            mailItem.HTMLBody = emailBody;
            mailItem.Display();
        }

        private string EmailRoomTypeContent(string roomType, string dailyRate, string totalValue, string municipalTax, string numberOfDays)
        {
            return $"<br><br>{roomType}, R$ {dailyRate}, R$ {dailyRate}, {numberOfDays}. " +
                   $"<br>(a única taxa extra cobrada é de R$ {municipalTax}";
        }
        private string EmailBodyContent(string personName, string startDay, string endDay, string monthName, string year, string roomType)
        {
            return $"<br>{personName}," +

                    $"<br> {startDay}, {endDay}/{monthName}/{year}." +
                    $"{roomType}";

        }
    }
}
