using System;
using System.Windows.Forms;

namespace BenTech.Forms.EmailsForms
{
    public partial class FormCancellations : Form
    {
        public FormCancellations()
        {
            InitializeComponent();
        }

        private void iconButton2_Click(object sender, EventArgs e)
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
            string emailAdress = ctbEmailAdress.GetTextBoxText();
            string reservationNumber = ctbReservationNumber.GetTextBoxText();
            string startDate = dtpStart.Value.Date.ToString("dd/MM/yyy");
            string endDate = dtpEnd.Value.Date.ToString("dd/MM/yyy");

            //--------------------------------------------------------------------------------------     
            emailBody += "<p class='texto-calibri'>" + EmailBodyContentCancellationRequest(personName, reservationNumber, startDate, endDate) + "</p>";
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

        private string EmailBodyContentCancellationRequest(string personName, string reservationNumber, string startDate, string endDate)
        {
            return
                "Olá!" +
                $"<br><br>Name: {personName}," +
                $"<br>Reservation Number: {reservationNumber}" +
                $"<br>Start date: {startDate} End date: {endDate}";
        }


        private void ibtnCancellationNoDeposit_Click(object sender, EventArgs e)
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

            string emailAdress = ctbEmailAdress.GetTextBoxText();

            //--------------------------------------------------------------------------------------     
            emailBody += "<p class='texto-calibri'>" + EmailBodyContentCancellationNoDeposit() + "</p>";
            // Finaliza o corpo do email
            emailBody += "</body></html>";

            // Cria o email no Outlook
            Microsoft.Office.Interop.Outlook.Application outlook = new Microsoft.Office.Interop.Outlook.Application();
            Microsoft.Office.Interop.Outlook.MailItem mailItem = (Microsoft.Office.Interop.Outlook.MailItem)outlook.CreateItem(Microsoft.Office.Interop.Outlook.OlItemType.olMailItem);

            mailItem.To = emailAdress;
            mailItem.Subject = "Reserva Pousada Betânia";
            mailItem.HTMLBody = emailBody;
            mailItem.Display();
        }
        private string EmailBodyContentCancellationNoDeposit()
        {
            return
         "Your email body here.";
        }
    }
}

