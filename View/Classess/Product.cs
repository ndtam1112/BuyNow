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
        private string nameproduct;
        private string typeproduct;
        private string sizeproduct;
        private BitmapImage imageproduct;
        private string priceproduct;

        public string NameProduct { get => nameproduct; set => nameproduct = value; }
        public string TypeProduct { get => typeproduct; set => typeproduct = value; }
        public string SizeProduct { get => sizeproduct; set => sizeproduct = value; }
        public BitmapImage ImageProduct { get => imageproduct; set => imageproduct = value; }
        public string PriceProduct { get => priceproduct; set => priceproduct = value; }

        public Product(string nameproduct, string typeproduct, string sizeproduct, BitmapImage imageproduct)
        {
            NameProduct = nameproduct;
            TypeProduct = typeproduct;
            SizeProduct = sizeproduct;
            ImageProduct = imageproduct;
            PriceProduct = priceproduct;

        }
        public Product()
        {
        }
    }
}
