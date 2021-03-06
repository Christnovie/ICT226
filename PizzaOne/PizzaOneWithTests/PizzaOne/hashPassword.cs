﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Policy;
using System.Security.Cryptography;
using Microsoft.AspNetCore.Cryptography.KeyDerivation;


namespace PizzaOne
{
    public class hashPassword
    {
        private string password;
        private byte[] salt;
        public hashPassword(string password)
        {
            hashing(password);
        }
        private void hashing(string password)
        {
            byte[] salt = new byte[128 / 8];
            using (var rng = RandomNumberGenerator.Create())
            {
                rng.GetBytes(salt);
            }
            this.password = Convert.ToBase64String(KeyDerivation.Pbkdf2(
            password: password,
            salt: salt,
            prf: KeyDerivationPrf.HMACSHA1,
            iterationCount: 10000,
            numBytesRequested: 256 / 8));
            this.salt = salt;
        }

        public  string Pwd_hashed
        {
            get
            {
                return password;
            }
        }
        public string Pwd_Salt
        {
            get
            {
                string saltPath = "";
                foreach(byte item in salt)
                {
                    saltPath += $"{item}-";
                }
                return saltPath;
            }
        }
    }
}
