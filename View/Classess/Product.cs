using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Imaging;

namespace View.Classess
{
    class Product
    {
        private string _name_product;
        private string _size_product;
        private BitmapImage _image_product;
        private string _price_product;
        private string _amount_product;
        private string _id_product;

        public Product(string name_product, string size_product, BitmapImage image_product, 
            string price_product, string amount_product, string id_product)
        {
            Name_product = name_product;
            Size_product = size_product;
            Image_product = image_product;
            Price_product = price_product;
            Amount_product = amount_product;
            Id_product = id_product;
        }

        public string Name_product { get => _name_product; set => _name_product = value; }
        public string Size_product { get => _size_product; set => _size_product = value; }
        public BitmapImage Image_product { get => _image_product; set => _image_product = value; }
        public string Price_product { get => _price_product; set => _price_product = value; }
        public string Amount_product { get => _amount_product; set => _amount_product = value; }
        public string Id_product { get => _id_product; set => _id_product = value; }
    }
}
