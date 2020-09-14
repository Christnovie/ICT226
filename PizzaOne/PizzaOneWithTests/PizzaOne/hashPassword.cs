using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Policy;
using System.Security.Cryptography;

namespace PizzaOne
{
    public class hashPassword
    {
        private string password;
        public hashPassword(string password)
        {
            hashing(password);
        }
        private void hashing(string password)
        {
            byte bite[] = new byte { 128 / 8 };
            this.password = password;
        }

        public  string Pwd_hashed
        {
            get
            {
                return password;
            }
        }
    }
}
