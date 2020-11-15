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
    /// Interaction logic for SanPhamChiTiet.xaml
    /// </summary>
    public partial class SanPhamChiTiet : Window
    {
        private SolidColorBrush color
        {
            get;set;
        }

        private String content { get; set; }
        public SanPhamChiTiet()
        {
            InitializeComponent();
         
            color = new SolidColorBrush(Colors.Red);
            content = "Kho chiu";
        }
        private void Window_MouseDown(object sender, MouseButtonEventArgs e)
        {
            DragMove();
        }

    }
}
