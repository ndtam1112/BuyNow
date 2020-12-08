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
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using View.Classess;
using View.Database;

namespace View
{
    /// <summary>
    /// Interaction logic for Login.xaml
    /// </summary>
    public partial class Login : Window
    {
        public Login()
        {
            InitializeComponent();
        }
        private void Window_MouseDown(object sender, MouseButtonEventArgs e)
        {
            DragMove();
        }
        private void btnMinimize_Click(object sender, RoutedEventArgs e)
        {
            Window.GetWindow(this).WindowState = WindowState.Minimized;

        }

        private void btnClose_Click(object sender, RoutedEventArgs e)
        {
            System.Windows.Application.Current.Shutdown();
        }

        private void btSkip_Click(object sender, RoutedEventArgs e)
        {
           
        }

        private void btnLogin_Click(object sender, RoutedEventArgs e)
        {
            Account account = new Account(tbPhone.Text.Trim(), pbPassword.Password.Trim(),0);
            if (Accountdatabase.CheckAccount(account.Phone, account.Password))
            {
                MainWindow m = new MainWindow();
                Window.GetWindow(this).Hide();
                m.Show();
                MessageBox.Show("dang nhap...");
            }
            else
            {
                MessageBox.Show("Error join app");
            }
        }

        private void btnSignUp_Click(object sender, RoutedEventArgs e)
        {
            SignUp signUp = new SignUp();
            signUp.Show();
            Window.GetWindow(this).Close();
        }
    }
}
