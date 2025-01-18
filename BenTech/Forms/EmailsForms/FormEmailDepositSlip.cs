using System;
using System.Windows.Forms;

namespace BenTech.Forms.EmailsForms
{
    public partial class FormEmailDepositSlip : Form
    {
        public FormEmailDepositSlip()
        {
            InitializeComponent();
        }
        public void CreateDepositSlipEmail()
        {

            string depositPersonName = ctbDepositPersonName.GetTextBoxText();
            string depositReservationNumber = ctbDepositReservationNumber.GetTextBoxText();
            string depositValue = ctbDepositValue.GetTextBoxText();


            string emailBody = "<p class='texto-calibri'>" + EmailBodyContent(depositPersonName, depositValue, depositReservationNumber) + "</p>";

            // Cria o email no Outlook
            Microsoft.Office.Interop.Outlook.Application outlook = new Microsoft.Office.Interop.Outlook.Application();
            Microsoft.Office.Interop.Outlook.MailItem mailItem = (Microsoft.Office.Interop.Outlook.MailItem)outlook.CreateItem(Microsoft.Office.Interop.Outlook.OlItemType.olMailItem);

            mailItem.Subject = "Reservation";
            mailItem.HTMLBody = emailBody;
            mailItem.Display();
        }

        private string EmailBodyContent(string personName, string depositValue, string reservationNumber)
        {
            return
       $"<br> {personName}," +

       $"<br><br> {depositValue}, {reservationNumber}.";
        }

        private void ibtnCreateQuoteEmail_Click(object sender, EventArgs e)
        {
            CreateDepositSlipEmail();
        }
    }
}
