using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Microsoft.Win32;
using System.IO;

namespace Office_Post
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        Byte[] info = new byte[1000];
        List<string> members = new List<string>(); 
        public MainWindow()
        {
            InitializeComponent();
        }

        private void loadEmailsListButton_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog myDialog = new OpenFileDialog();
            myDialog.Filter = "Текстовый файл(*.txt)|*.txt";
            myDialog.CheckFileExists = true;
            myDialog.Multiselect = true;
            if (myDialog.ShowDialog() == true)
            {
                using (StreamReader sr = new StreamReader(myDialog.FileName, System.Text.Encoding.Default))
                {
                    string line;
                    while ((line = sr.ReadLine()) != null)
                    {
                        members.Add(line);
                    }
                }
            }
        }

        private void submit_Click(object sender, RoutedEventArgs e)
        {
            string title;
            string message;
            title = titleBox.Text;
            message = messageBox.Text;
            EmailSender emailSender = new EmailSender(emailBox.Text, passwordBox.Text, nameBox.Text, receiverEmailBox.Text);
            emailSender.SendEmail(title,message,members);
        }
    }
}
