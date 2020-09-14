using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaOne
{
    public class DbConnectorParam
    {
        private string user ="cmysql";
        private string password ="password";
        private int ports=default;
        private string database=default;
        private string result;

        public DbConnectorParam(string query)
        {
            DbConnector loginCheck = new DbConnector(user,password,query);
            result = loginCheck.Result;

        }
        public string Result
        {
            get
            {
                return result; 
            }
            
        }
    }
}
