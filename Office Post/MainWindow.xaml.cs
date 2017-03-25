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
        private bool passwordCheck = false;
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
                    //string[] perFr = new string[20];
                    //int i = 0;
                    while ((line = sr.ReadLine()) != null)
                    {
                        members.Add(line);
                        emailsListBox.Items.Add(new CheckBox { Content = line, IsChecked =true, IsEnabled=false});
                        //perFr[i] = line;
                        //i++;
                    }
                    CheckBox ll = emailsListBox.Items[0] as CheckBox;
                    ll.IsChecked = false;
                     //= new string[] { "111", "222", "333", "444" };
                    //List<string> itemsArray = new List<string>();
                    //itemsArray.AddRange(perFr);
                    //   listView.ItemsSource = members;
                    //emailsListBox.ItemsSource = members;
                    
                    // ListBoxItem li = emailsListBox.Items[0] as ListBoxItem;
                   // ListBoxItem lbi = emailsListBox.Items[0] as ListBoxItem;
                    //emailsListBox.ItemContainerStyle =  new SolidColorBrush(Colors.Red);
                    //lbi.Foreground = Brushes.Green;
                    // emailsListBox.Items[0] = lbi;
                }
            }
        }

        private void submit_Click(object sender, RoutedEventArgs e)
        {
            string title;
            string message;
            title = titleBox.Text;
            message = messageBox.Text;
            EmailSender emailSender = new EmailSender(emailBox.Text, passwordBox.Password, nameBox.Text);
            emailSender.SendEmail(title,message,members);
        }

        private void passwordBox_TextChanged(object sender, TextChangedEventArgs e)
        {
        }

        private void passwordBox_MouseEnter(object sender, MouseEventArgs e)
        {
                       
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

        private void entryButton_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
