using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace View.Classess
{
    class Product
    {
        private string nameproduct;
        private string typeproduct;
        private string sizeproduct;
        private byte[] imageproduct;

        public string NameProduct { get => nameproduct; set => nameproduct = value; }
        public string TypeProduct { get => typeproduct; set => typeproduct = value; }
        public string SizeProduct { get => sizeproduct; set => sizeproduct = value; }
        public string ImageProduct { get => sizeproduct; set => sizeproduct = value; }

        public Product(string nameproduct, string typeproduct, string sizeproduct, string imageproduct)
        {
            NameProduct = nameproduct;
            TypeProduct = typeproduct;
            SizeProduct = sizeproduct;
            ImageProduct = imageproduct;

        }
        public Product()
        {
        }
    }
}
