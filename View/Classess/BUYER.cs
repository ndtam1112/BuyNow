using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace View.Classess
{
    public class BUYER
    {
        private string phone;
        
        public string Phone { get => phone; set => phone = value; }
        

        public BUYER(string phone)
        {
            Phone = phone;
        }
        public BUYER()
        {
        }
    }
}
