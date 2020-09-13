using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using ConnexionDatabase;


namespace ConnexionDatabase
{
    class ProgramDbConnect
    {
        private Int16 port = 3306;
        private string server = "localhost";
        private string iud;
        private string password;
        private string database;
        private string charset = "utf8";
        private string sslMode = "None";
        private string dbConnector;

        static void Main(string[] args)
        {
            Int16 port = 3306;
            string server = "localhost";
            string iud = "cmysql";
            string password="password";
            string database = "Cdatabase";
            string charset = "utf8";
            string sslMode = "None";
         

        
            string dbConnector = $"server={server};port={port};uid={iud};pwd={password};database={database};charset={charset};sslMode={sslMode}"; 

            Console.WriteLine("connexion tu mysql database :");
            try
            {

                MySqlConnection connect = new MySqlConnection(dbConnector);
                connect.Open();
                Console.WriteLine("Connection is " + connect.State.ToString() + Environment.NewLine);
                MySqlCommand command = connect.CreateCommand();
                connect.Close();
                Console.WriteLine("Connection is " + connect.State.ToString() + Environment.NewLine);

            }
            catch (MySql.Data.MySqlClient.MySqlException ex)

            {
                Console.WriteLine("Erreur : " + ex.Message.ToString());
            }

            Console.WriteLine("Press any key to exit...");
            Console.Read();



        }
        public  ProgramDbConnect(string user, string password,string dbname)
        {
            iud = user;
            this.password = password;
            database = dbname;
            string con = Login;
            
            Console.WriteLine("connexion tu mysql database :");
            try
            {

                MySqlConnection connect = new MySqlConnection(con);
                connect.Open();
                Console.WriteLine("Connection is " + connect.State.ToString() + Environment.NewLine);

                connect.Close();
                Console.WriteLine("Connection is " + connect.State.ToString() + Environment.NewLine);

            }
            catch (MySql.Data.MySqlClient.MySqlException ex)

            {
                Console.WriteLine("Erreur : " + ex.Message.ToString());
            }

            Console.WriteLine("Press any key to exit...");
            Console.Read();
        }
        private string Login
        {
            
            get
            {
                return dbConnector;
            }

            set
            {
               
                dbConnector = $"server={server};port={port};uid={iud};pwd={password};database={database};charset={charset};sslMode={sslMode}";
            }
        }
        
    }
}
