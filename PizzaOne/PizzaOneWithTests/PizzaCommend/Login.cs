using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PizzaOne;
namespace PizzaCommend
{
    public partial class wnd_Login2 : Form
    {
        private string username;
        public wnd_Login2()
        {
            InitializeComponent();
        }

        private void cmd_login_Click(object sender, EventArgs e)
        {
            string name = txt_name.Text;
            string password = txt_password.Text;

            string query = $"SELECT password FROM users where name ='{name}';";

            DbConnectorParam loginCheck = new DbConnectorParam(query);
            if (loginCheck.Result != null)
            {
                if (password == loginCheck.Result)
                {
                    Console.WriteLine("Connexion reussi");
                    DialogResult = DialogResult.OK;
                    username = txt_name.Text;
                    Close();
                }
                else
                {
                    MessageBox.Show("Connexion fail your username or password is incorrect");
                    txt_name.Text = "";
                    txt_password.Text = "";
                }

                

            }
            else
            {

                MessageBox.Show("Not data found");

            }
        }
        public string User
        {
            get
            {
                return username;
            }
        }
    }
}
