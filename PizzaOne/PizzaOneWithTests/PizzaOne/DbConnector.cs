﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace PizzaOne
{
    public class DbConnector
    {
        private int port;
        private string server = "localhost";
        private string iud;
        private string password;
        private string database;
        private string charset = "utf8";
        private string sslMode = "None";
        private string dbConnector;
        private string connect;

        public DbConnector(string user, string password, string query, string dbname, int port = 3306)
        {
            iud = user;
            this.password = password;
            database = dbname;
            this.port = port;
            connect = ConnectedTodb(query);

        }
        private string ConnectedTodb(string query)
        {
            string con = Login;
            Console.WriteLine("connexion tu mysql database :");
            try
            {

                //conncting to database 
                MySqlConnection connect = new MySqlConnection(con);

                //open database connected 
                connect.Open();
                
                //create new objet script line for write script
                MySqlCommand command = connect.CreateCommand();
                //Diplay data
                command.CommandType = System.Data.CommandType.Text;
                //writing script
                command.CommandText = query;
                //execute query and get query result 
                MySqlDataReader reader = command.ExecuteReader();
               
                string showResult = "";
                //Show in console the script result
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        //pick up result of script and input it in the string var
                        showResult = reader.GetString(0);
                    }
                    reader.Close();
                }
                
                
                //Close and deconnect database
                connect.Close();
                return showResult;
                

            }
            catch (MySql.Data.MySqlClient.MySqlException ex)

            {
                Console.WriteLine("Erreur : " + ex.Message.ToString());
                return null;
            }

            
        }
        public string Result
        {
            get
            {
                return connect;
            }
        }

        private string Login
        {

            get
            {
                return dbConnector = $"server={server};port={port};uid={iud};pwd={password};database={database};charset={charset};sslMode={sslMode}"; ;
            }

           
        }
    }
}
