using System;
using System.Collections.Generic;
using System.Text;
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
using System.Globalization;

namespace Office_Post
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        Byte[] info = new byte[1000];
        List<string> attachList = new List<string>();
        List<string> members = new List<string>();
        private bool passwordCheck = false;
        string reportWay;
        string signatureWay;
        string fullPath;
        EmailSender emailSender;

        public MainWindow()
        {
            InitializeComponent();
            fullPath = AppDomain.CurrentDomain.BaseDirectory;
            //using (BinaryReader reader = new BinaryReader(File.Open("report.bin", FileMode.Open)))
            //{
            //    reportWay = reader.ReadString();
            //}
        }

        private void loadEmailsListButton_Click(object sender, RoutedEventArgs e)
        {
            progressBar.Value = 0;
            members.Clear();
            emailsListBox.Items.Clear();
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
                        if (line != "")
                        {
                            members.Add(line.Trim(' ','*','-','.'));
                            emailsListBox.Items.Add(new CheckBox { Content = line.Trim(' ', '*', '-', '.'), IsChecked = false, IsEnabled = false });
                        }
                    }
                    
                }
            }
            if (CheckFieldsToSubmit())
                submit.IsEnabled = true;
            else
                submit.IsEnabled = false;
        }

        private void submit_Click(object sender, RoutedEventArgs e)
        {
            string title;
            string message;
            title = titleBox.Text;
            message = messageBox.Text;
            progressBar.Value = 0;
            emailSender = new EmailSender(emailBox.Text, passwordBox.Password, nameBox.Text,emailsListBox,progressBar, title, message, members, attachList);
            System.Threading.Thread secThread = new System.Threading.Thread(new System.Threading.ThreadStart(emailSender.SendEmail));
            //emailSender.SendEmail(title,message,members,attachList);
            secThread.Start();
            reportBox.IsEnabled = true;
        }

        private void checkButton_Click(object sender, RoutedEventArgs e)
        {
            if (!passwordCheck)
            {
                passwordVisibleTextBox.Text = passwordBox.Password;
                passwordBox.Visibility = Visibility.Hidden;
                passwordVisibleTextBox.Visibility = Visibility.Visible;
                passwordCheck = true;
            }
            else
            {
                passwordBox.Password = passwordVisibleTextBox.Text;
                passwordBox.Visibility = Visibility.Visible;
                passwordVisibleTextBox.Visibility = Visibility.Hidden;
                passwordCheck = false;
            }

        }

        private void AttachButton_Click(object sender, RoutedEventArgs e)
        {
            AttachFiles();
            foreach (string item in attachList)
                attachListBox.Items.Add(System.IO.Path.GetFileName(item));
        }

        private void AttachFiles()
        {
            OpenFileDialog myDialog = new OpenFileDialog();
            myDialog.Filter = "Все файлы(*.*)|*.*";
            myDialog.CheckFileExists = true;
            myDialog.Multiselect = true;
            if (myDialog.ShowDialog() == true)
            {
                foreach (string file in myDialog.FileNames)
                    attachList.Add(file);
            }
        }

        private bool CheckFieldsToSubmit()
        {
            if (emailBox.Text != "" && passwordBox.Password != "" && passwordVisibleTextBox.Text != "" && nameBox.Text != "" && titleBox.Text != "" && messageBox.Text != "" && emailsListBox.Items.Count != 0)
            {
                return true;
            }
            else return false;
        }

        private void attachListBox_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.Key == Key.Delete)
                {
                    int index = attachListBox.SelectedIndex;
                    attachListBox.Items.Remove(attachListBox.Items[index]);
                    attachList.Remove(attachList[index]);
                }
            }
            catch { };
        }

        private void emailBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (CheckFieldsToSubmit())
                submit.IsEnabled = true;
            else
                submit.IsEnabled = false;
        }

        private void nameBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (CheckFieldsToSubmit())
                submit.IsEnabled = true;
            else
                submit.IsEnabled = false;
        }

        private void titleBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (CheckFieldsToSubmit())
                submit.IsEnabled = true;
            else
                submit.IsEnabled = false;
        }

        private void messageBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (CheckFieldsToSubmit())
                submit.IsEnabled = true;
            else
                submit.IsEnabled = false;
        }

        private void passwordVisibleTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (CheckFieldsToSubmit())
                submit.IsEnabled = true;
            else
                submit.IsEnabled = false;
        }

        private void passwordBox_PasswordChanged(object sender, RoutedEventArgs e)
        {
            if (CheckFieldsToSubmit())
                submit.IsEnabled = true;
            else
                submit.IsEnabled = false;
        }

        private void reportWay_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog myDialog = new OpenFileDialog();
            myDialog.Filter = "Текстовый файл(*.txt)|*.txt";
            myDialog.CheckFileExists = true;
            if (myDialog.ShowDialog() == true)
            {
                reportWay = myDialog.FileName;
                using (BinaryWriter writer = new BinaryWriter(File.Open(fullPath+"\\report.bin", FileMode.Create)))
                {
                    writer.Write(reportWay);
                }
            }
        }
        private void signatureWay_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                OpenFileDialog myDialog = new OpenFileDialog();
                myDialog.Filter = "Текстовый файл(*.txt)|*.txt";
                myDialog.CheckFileExists = true;
                if (myDialog.ShowDialog() == true)
                {
                    signatureWay = myDialog.FileName;
                    using (BinaryWriter writer = new BinaryWriter(File.Open(fullPath + "\\signature.bin", FileMode.Create)))
                    {
                        writer.Write(signatureWay);
                    }
                }
            }
            catch { }
        }

        private void signatureButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                using (BinaryReader reader = new BinaryReader(File.Open(fullPath + "\\signature.bin", FileMode.Open)))
                {
                    signatureWay = reader.ReadString();
                }

                using (StreamReader sr = new StreamReader(signatureWay, System.Text.Encoding.Default))
                {
                    string line;
                    line = sr.ReadToEnd();
                    messageBox.AppendText('\n'+line);
                }
            }
            catch { }

        }
        private void help_click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Список адресов: загрузка потенциальных получателей " + (char)10 + (char)13 + "Отправить: отправить сообщение" + (char)10+(char)13+ "Прикрепить: прикрепить файлы (любое количество и любое расширение); удалить прикрепленный файл можно выбрав его и нажав на кнопку DEL" + (char)10 + (char)13 + "Подпись: добавить подпись в сообщение " + (char)10 + (char)13 + "Отчет: отчет об отправке(произошедшие ошибки)", "Помощь",
               MessageBoxButton.OK, MessageBoxImage.Information);
            
        }
        private void exit_click(object sender, RoutedEventArgs e)
        {
            Environment.Exit(0);

        }
        private void reportBox_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                using (BinaryReader reader = new BinaryReader(File.Open(fullPath + "\\report.bin", FileMode.Open)))
                {
                    reportWay = reader.ReadString();
                }
                using (StreamWriter sw = new StreamWriter(reportWay))
                {
                    if (emailSender != null)
                    {
                        foreach (string rep in emailSender.report)
                        {
                            sw.WriteLine(rep);
                        }
                    }
                }
                System.Diagnostics.Process.Start(reportWay);
            }
            catch { }
        }
    }
}
