﻿using System;
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

namespace View.User_Control
{
    /// <summary>
    /// Interaction logic for ItemProduct.xaml
    /// </summary>
    public partial class ItemProduct : UserControl
    {
        public ItemProduct()
        {
            InitializeComponent();
        }

        private void ItemProduct_MouseLeave(object sender, MouseEventArgs e)
        {
            twobutton.Opacity = 0;
        }

        private void ItemProduct_PreviewMouseMove(object sender, MouseEventArgs e)
        {
            twobutton.Opacity = 1;
        }
    }
}