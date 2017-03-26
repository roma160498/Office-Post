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
        string header;
        string message;
        List<string> members;
        List<string> attachList;
        private ListBox listbox;
        private ProgressBar progBar;
        public List<string> report  { get; set; }

        private delegate void UpdateLogCallback(ProgressBar progBar,int cur,int all);
        private delegate void UpdateCheckBoxes(ListBox listbox,int cur);

        public EmailSender(string senderEmail, string password, string name, ListBox listbox, ProgressBar progBar, string header, string message, List<string> members, List<string> attachList)
        {
            this.senderEmail = senderEmail;
            this.name = name;
            this.password = password;
            this.listbox = listbox;
            this.progBar = progBar;
            this.header = header;
            this.message = message;
            this.members = members.GetRange(0,members.Count);
            this.attachList = attachList.GetRange(0, attachList.Count);
            this.progBar = progBar;
            report = new List<string>();
        }
        private void UpdateLog(ProgressBar progBar,int cur,int all)
        {
            progBar.Value = (double)cur * 100 / all;
        }
        private void UpdateBoxes(ListBox listbox, int cur)
        {
            CheckBox ll = listbox.Items[cur] as CheckBox;
            ll.IsChecked = true;
        }
        public void SendEmail()
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
                        listbox.Dispatcher.Invoke(new UpdateCheckBoxes(this.UpdateBoxes), new object[] { listbox, j });
                        report.Add($"{members[j]} : доставлено\n");
                        progBar.Dispatcher.Invoke(new UpdateLogCallback(this.UpdateLog), new object[] { progBar,j+1,members.Count });
                    }
                    catch (Exception ex)
                    {
                        report.Add($"{members[j]} : " + ex.Message+'\n');
                        progBar.Dispatcher.Invoke(new UpdateLogCallback(this.UpdateLog), new object[] { progBar, 0, 1 });
                    }
                }
            }
            catch (Exception ex)
            {
                report.Add(ex.Message);
            }
        }
    }
}
