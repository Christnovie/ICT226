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
        public Password_Verfy(string password, string saltVChar, string pwd_hashed)
        {
            byte[] salt = new byte[128 / 8];
            salt = SaltPassword(saltVChar, salt);
            this.pwd_hashed = pwd_hashed;
            password_verfy = Convert.ToBase64String(KeyDerivation.Pbkdf2(
                password: password,
                salt: salt,
                prf: KeyDerivationPrf.HMACSHA1,
                iterationCount: 10000,
                numBytesRequested: 256 / 8
                 ));


        }
        private byte[] SaltPassword(string charPwd,byte[] salt)
        {
            int index = 0;
            char separateur = '-';
            string result = "";
            foreach(char item in charPwd)
            {
                if (item == separateur )
                {
                    salt[index] += Convert.ToByte(result);
                    index++;
                    result = "";
                }
                else   result += item;                 
            }
            return salt;
        }

        public bool result
        {
            get
            {
                if (password_verfy == pwd_hashed)return true;
                else return false;
            } 
        
        }
        
    }
}
