using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Security.Cryptography;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Forms.Integration;

using PizzaOne;

namespace PizzaCommend
{
    /// <summary>
    /// Logique d'interaction pour UserControl1.xaml
    /// </summary>
    public partial class Login : UserControl
    {

        public Login()
        {
            InitializeComponent();
        }

        private int cmd_Submit_Click(object sender, RoutedEventArgs e)
        {
            string name = txt_Name.Text;
            string password = txt_password.Text;
           
            string query = $"SELECT password FROM users where name ='{name}';";
            
            DbConnectorParam loginCheck = new DbConnectorParam(query);
            if (loginCheck.Result != null)
            {
                if (password == loginCheck.Result)
                    Console.WriteLine("Connexion reussi");
                else
                    Console.WriteLine("Connexion fail");
                return 0;
            }
            else
            {

                return 0;
            }

        }


    }
}
