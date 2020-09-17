using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;
using Microsoft.AspNetCore.Cryptography.KeyDerivation;

namespace PizzaOne
{
    public class Password_Verfy
    {
        private string password_verfy;
        private string pwd_hashed;
        public Password_Verfy(string password,byte[] salt,string pwd_hashed)
        {
            this.pwd_hashed = pwd_hashed;
                password_verfy = Convert.ToBase64String(KeyDerivation.Pbkdf2(
                    password: password,
                    salt: salt,
                    prf: KeyDerivationPrf.HMACSHA1,
                    iterationCount: 10000,
                    numBytesRequested: 256 / 8
                     ));
            
           
        }
        public bool result
        {
            get
            {
                if (password_verfy == pwd_hashed)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }
        
    }
}
