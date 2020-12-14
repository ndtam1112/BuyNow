using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Imaging;

namespace View.Classess
{
    public class Product
    {
        private string _name_product;
        private string _size_product;
        private BitmapImage _image_product;
        private double _price_product;
        private int _amount_product;
        private string _id_product;
        public string Name_product { get => _name_product; set => _name_product = value; }
        public string Size_product { get => _size_product; set => _size_product = value; }
        public BitmapImage Image_product { get => _image_product; set => _image_product = value; }
        public double Price_product { get => _price_product; set => _price_product = value; }
        public int Amount_product { get => _amount_product; set => _amount_product = value; }
        public string Id_product { get => _id_product; set => _id_product = value; }
        public Product()
        {


        }   
    }
}
