using System;
using System.Collections.Generic;
using System.Text;
using System.Net;
using System.Net.Mail;
using Microsoft.Win32;
using System.Windows.Controls;


namespace Office_Post
{
    class EmailSender
    {
        private string senderEmail;
        private string name;
        private string password;
        private string domain = "";
        private ListBox listbox;
        public List<string> report  { get; set; }

        public EmailSender(string senderEmail, string password, string name, ListBox listbox)
        {
            this.senderEmail = senderEmail;
            this.name = name;
            this.password = password;
            this.listbox = listbox;
            report = new List<string>();
        }
        public void SendEmail(string header, string message, List<string> members,List<string> attachList)
        {
            try
            {
                MailAddress Sender = new MailAddress(senderEmail, name);
                var abc = Sender.User;
                int pos = senderEmail.IndexOf('@');
                for (int i = pos + 1; i < senderEmail.Length; i++)
                    domain += senderEmail[i];
                SmtpClient smtp = new SmtpClient("smtp." + domain, 587);
                smtp.Credentials = new NetworkCredential(senderEmail, password);
                smtp.EnableSsl = true;
                for (int j = 0; j < members.Count; j++)
                {
                    try { 
                        MailAddress Receiver = new MailAddress(members[j]);
                        MailMessage messageObject = new MailMessage(Sender, Receiver);
                        messageObject.Subject = header;
                        messageObject.Body = message;
                        foreach (string item in attachList)
                            messageObject.Attachments.Add(new Attachment(item));
                        smtp.Send(messageObject);
                        CheckBox ll = listbox.Items[j] as CheckBox;
                        ll.IsChecked = true;
                        report.Add($"{members[j]} : доставлено\n");
                    }
                    catch (Exception ex)
                    {
                        report.Add($"{members[j]} : " + ex.Message+'\n');
                    }
                }
            }catch (Exception ex)
            {
                report.Add(ex.Message);
            }
        }
    }
}
