using System;
using System.Windows.Forms;

namespace BenTech.Forms.EmailsForms
{
    public partial class FormChangeReservation : Form
    {
        public FormChangeReservation()
        {
            InitializeComponent();
        }

        private void ibtnCreateEmail_Click(object sender, EventArgs e)
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

            string reservationNumber = ctbReservationNumber.GetTextBoxText();

            string startTimeBefore = dtpStartBefore.Value.Date.ToString("dd/MM/yyy");
            string endTimeBefore = dtpEndBefore.Value.Date.ToString("dd/MM/yyy");
            string startTimeAfter = dtpStartAfter.Value.Date.ToString("dd/MM/yyy");
            string endTimeAfter = dtpEndAfter.Value.Date.ToString("dd/MM/yyy");

            string dailyRateBefore = ctbDailyRateBefore.GetTextBoxText();
            string dailyRateAfter = ctbDailyRateAfter.GetTextBoxText();

            string roomTypeBefore = ctbRoomTypeBefore.GetTextBoxText();
            string roomTypeAfter = ctbRoomTypeAfter.GetTextBoxText();

            string emailAdress = ctbEmailAdress.GetTextBoxText();

            //--------------------------------------------------------------------------------------     
            emailBody += "<p class='texto-calibri'>" + EmailBodyContent(
                personName, reservationNumber, startTimeBefore, startTimeAfter, endTimeBefore,
                endTimeAfter, dailyRateBefore, dailyRateAfter, roomTypeBefore, roomTypeAfter
                ) + "</p>";

            // Finaliza o corpo do email
            emailBody += "</body></html>";

            // Cria o email no Outlook
            Microsoft.Office.Interop.Outlook.Application outlook = new Microsoft.Office.Interop.Outlook.Application();
            Microsoft.Office.Interop.Outlook.MailItem mailItem = (Microsoft.Office.Interop.Outlook.MailItem)outlook.CreateItem(Microsoft.Office.Interop.Outlook.OlItemType.olMailItem);

            mailItem.To = emailAdress;
            mailItem.Subject = "Reservation";
            mailItem.HTMLBody = emailBody;
            mailItem.Display();
        }
        private string EmailBodyContent(
            string personName, string reservationNumber, string startTimeBefore, string startTimeAfter, string endTimeBefore,
            string endTimeAfter, string dailyRateBefore, string dailyRateAfter, string roomTypeBefore, string roomTypeAfter
            )
        {

            return
                    "Olá!" +

                    $"<br><br>Guest name: {personName}" +
                    $"<br>Reservation number: {reservationNumber}" +

                    $"<br><br>Check-in before: {startTimeBefore}" +
                    $"<br>Check-in after: {startTimeAfter}" +

                    $"<br><br>Check-out before: {endTimeBefore}" +
                    $"<br>Check-out after: {endTimeAfter} " +

                    $"<br><br>Daily rate before: R$ {dailyRateBefore} " +
                    $"<br>Daily rate after:: R$ {dailyRateAfter}" +

                    $"<br><br>Room type before: {roomTypeBefore}" +
                    $"<br>Room type after: {roomTypeAfter}";
        }
    }
}
