using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Mail;


namespace Office_Post
{
    class EmailSender
    {
        private string senderEmail;
        private string name;
        private string receiverEmail;
        private string password;
        private string domain = "";

        public EmailSender(string senderEmail, string password, string name, string receiverEmail)
        {
            this.senderEmail = senderEmail;
            this.name = name;
            //this.receiverEmail = receiverEmail;
            this.password = password;
        }
        public void SendEmail(string header, string message,List<string> members)
        {
            MailAddress Sender = new MailAddress(senderEmail, name);

            int pos = senderEmail.IndexOf('@');
            for (int i = pos + 1; i < senderEmail.Length; i++)
                domain += senderEmail[i];
            SmtpClient smtp = new SmtpClient("smtp." + domain, 587);
            smtp.Credentials = new NetworkCredential(senderEmail, password);
            smtp.EnableSsl = true;
            for (int j = 0; j < members.Count; j++)
            {
                MailAddress Receiver = new MailAddress(members[j]);
                MailMessage messageObject = new MailMessage(Sender, Receiver);

                messageObject.Subject = header;
                messageObject.Body = message;
               
            
            smtp.Send(messageObject);

            }
        }
    }
}
