using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace FootballData
{
    public class MailSender
    {
        public string sSmtpClient = "smtp.office365.com";
        public string sUsername = "duro.belacic@vsmti.hr";
        public string sPassword = "Alpha0851";
        public int nPort = 587;
        public void SendEmail(string sEmail, string sSubject, string sBody)
        {
            MailMessage mail = new MailMessage();
            SmtpClient SmtpServer = new SmtpClient(sSmtpClient);

            mail.From = new MailAddress(sUsername);
            mail.To.Add(new MailAddress(sEmail));
            mail.Subject = sSubject;
            mail.IsBodyHtml = true;
            SmtpServer.Port = nPort;
            SmtpServer.Credentials = new System.Net.NetworkCredential(sUsername, sPassword);
            SmtpServer.EnableSsl = true;
            string mailBody = "<table>";
            SmtpServer.Send(mail);
        }
    }
}
