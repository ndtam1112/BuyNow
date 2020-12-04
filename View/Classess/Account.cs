using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace View.Classess
{
    public class Account
    {
        private string phone;
        private string password;
        private int permission;

        public string Phone { get => phone; set => phone = value; }
        public string Password { get => password; set => password = value; }
        public int Permission { get => permission; set => permission = value; }

        public Account(string phone, string password, int permission)
        {
            Phone = phone;
            Password = password;
            Permission = permission;
        }

        public Account()
        {
        }
    }
}
