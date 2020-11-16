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
    /// Interaction logic for Category.xaml
    /// </summary>
    public partial class Category : Window
    {
        public Category()
        {
            InitializeComponent();
        }
        private void Window_MouseDown(object sender, MouseButtonEventArgs e)
        {
            DragMove();
        }

        private void btnMinimize_Click(object sender, RoutedEventArgs e)
        {
            System.Windows.Application.Current.Shutdown();
        }

        private void btnClose_Click(object sender, RoutedEventArgs e)
        {
            Window.GetWindow(this).WindowState = WindowState.Minimized;
        }

        private void TShirt_Click(object sender, RoutedEventArgs e)
        {
            TheLoai theloai = new TheLoai();
            this.Visibility = Visibility.Hidden;
            theloai.Show();
        }

        private void btnHome_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mw = new MainWindow();
            this.Visibility = Visibility.Hidden;
            mw.Show();
        }
    }
}
