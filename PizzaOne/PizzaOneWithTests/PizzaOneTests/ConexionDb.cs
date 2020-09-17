using System;using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PizzaOne;
using Microsoft.AspNetCore.Cryptography.KeyDerivation;
using MySql.Data.MySqlClient;

namespace PizzaOneTests
{
    /// <summary>
    /// Description résumée pour connexionDB
    /// </summary>
    [TestClass]
    public class ConexionDb
    {


        [TestMethod]
        public void connexion_has_db_is_success()
        {
            string query = "SELECT * FROM users;";
           
                DbConnector loginCheck = new DbConnector("cmysql", "password", query,"cdatabase");
            string result = loginCheck.Result;

            Assert.IsNotNull(result);
        }
        [TestMethod]
        public void connexion_has_db_is_unsuccess()
        {
            string query = "SELECT * FROM users;";

            DbConnector loginCheck = new DbConnector("test", "password", query, "cdatabase");
            string result = loginCheck.Result;

            Assert.IsNull(result);
        }
    }
}
