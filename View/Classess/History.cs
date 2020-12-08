using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace View.Classess
{
    public class History
    {
        private string datebuy;

        public History(string datebuy)
        {
            DateBuy = datebuy;
        }
        public History()
        {

        }
        public string DateBuy { get => datebuy; set => datebuy = value; }
    }
}
