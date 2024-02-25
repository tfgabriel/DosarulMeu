using System;
using System.Collections.Generic;
using System.Net.Mail;

namespace DosarulMeu
{
    public class SendEmail
    {
        public int randomcode()
        {
            Random random = new Random();
            int code = random.Next(99999, 1000000);

            return code;
        }
        public void Email(string email)
        {
            MailAddress from = new MailAddress("sprinky66@gmail.com", "Dosarul Meu");
            MailAddress to = new MailAddress(email, "Name");
            List<MailAddress> cc = new List<MailAddress>
            {
                new MailAddress(email, "Name")
            };
            EmailStructure("Codul tau", from, to, cc);
        }




        public void EmailStructure(string _subject, MailAddress _from, MailAddress _to, List<MailAddress> _cc)
        {
            int x = randomcode();
            string Text = "Codul tau este: " + randomcode().ToString();
            SmtpClient mailClient = new SmtpClient("smtp.mail.yahoo.com");
            MailMessage msgMail;
            msgMail = new MailMessage();
            msgMail.From = _from;
            msgMail.To.Add(_to);
            foreach (MailAddress addr in _cc)
            {
                msgMail.CC.Add(addr);
            }
            
            msgMail.Subject = _subject;
            msgMail.Body = Text;
            msgMail.IsBodyHtml = true;
            mailClient.Send(msgMail);
            msgMail.Dispose();
        }

    }

}