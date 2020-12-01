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

namespace View
{
    /// <summary>
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        private void Window_MouseDown(object sender, MouseButtonEventArgs e)
        {
            DragMove();
        }
        #region Close, Minimize and 4 Button Mặc Định
        private void btnClose_Click(object sender, RoutedEventArgs e)
        {
            System.Windows.Application.Current.Shutdown();
        }
        private void btnMinimized_Click(object sender, RoutedEventArgs e)
        {
            Window.GetWindow(this).WindowState = WindowState.Minimized;
        }
        private void btnCategory_Click(object sender, RoutedEventArgs e)
        {
            Category category = new Category();
            this.Visibility = Visibility.Hidden;
            category.Show();
        }
        private void btnHome_Click(object sender, RoutedEventArgs e)
        {

        }
        private void btnSearch_Click(object sender, RoutedEventArgs e)
        {

        }
        private void btnMe_Click(object sender, RoutedEventArgs e)
        {

        }
        private void btnCart_Click(object sender, RoutedEventArgs e)
        {

        }
        #endregion
    }
}
