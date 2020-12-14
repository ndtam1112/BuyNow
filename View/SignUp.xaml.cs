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
using System.Windows.Shapes;
using View.Database;

namespace View
{
    /// <summary>
    /// Interaction logic for SignUp.xaml
    /// </summary>
    public partial class SignUp : Window
    {
        public object Userdatabase { get; private set; }

        public SignUp()
        {
            InitializeComponent();
        }
        private void Window_MouseDown(object sender, MouseButtonEventArgs e)
        {
            DragMove();
        }
        private void btnClose_Click(object sender, RoutedEventArgs e)
        {
            System.Windows.Application.Current.Shutdown();
        }
        private void btnMinimized_Click(object sender, RoutedEventArgs e)
        {
            Window.GetWindow(this).WindowState = WindowState.Minimized;
        }

        private void btSkip_Click(object sender, RoutedEventArgs e)
        {
            //Grid1.Opacity = 1;

            //tb1.Opacity = 0;
            //tb2.Opacity = 0;
            //tb3.Opacity = 0;
            //tb4.Opacity = 0;
        }

        private void btnWantSignin_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnSignUp_Click(object sender, RoutedEventArgs e)
        {
            //if (Accountdatabase.insert(phoneSignUp.Text.Trim(), passWordSignUp.Password.Trim()))
            //{

            //    MessageBox.Show("hi");
            //}
            //else
            //{
            //    MessageBox.Show("");

            //}
        }
    }
}
