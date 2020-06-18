using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Mail;
using System.Net;
using System.Windows.Forms;

namespace Logic
{
    public static class Emailer
    {
        private const string smtpClient = "smtp.gmail.com";
        private const string smtpPort = "587";
        private const string mailfrom = "basbrak123@gmail.com"; // Set sender GMAIL address

        public static void SendMail(string recipient, string subject, string message)
        {
            try
            {
                MailMessage mail = new MailMessage();
                mail.From = new MailAddress(mailfrom);
                mail.To.Add(new MailAddress(recipient)); // Email address you are sending to (recipient)
                mail.Subject = subject; // Email subject 
                mail.Body = message; // Email message (body)

                SmtpClient Smtp_Client = new SmtpClient(smtpClient, Convert.ToInt32(smtpPort));
                Smtp_Client.EnableSsl = true;
                Smtp_Client.Credentials = new NetworkCredential(mailfrom, "itpvafepdhsupfjo"); // Set GMAIL password (account)

                Smtp_Client.SendCompleted += new SendCompletedEventHandler(smtp_SendCompleted);
                Smtp_Client.SendAsync(mail, null);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private static void smtp_SendCompleted(object sender, System.ComponentModel.AsyncCompletedEventArgs e)
        {
            if (e.Error != null) { }
            else if (e.Cancelled) { }
            else
            { }
        }
    }
}
