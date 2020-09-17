using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySqlX.XDevAPI;
using PizzaOne;
namespace PizzaCommend
{
    public partial class wnd_Login2 : Form
    {
        private string username;
        public Session session;
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
            query = $"SELECT salt FROM users where name ='{name}';";
            DbConnectorParam loginSalt = new DbConnectorParam(query);
            if (loginCheck.Result != null)
            {
                if (new Password_Verfy(txt_password.Text, loginSalt.Result, loginCheck.Result).result)
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

        private void cmd_register_Click(object sender, EventArgs e)
        {
            Register form = new Register();
            if(form.ShowDialog() == DialogResult.OK)
            {
                MessageBox.Show("Inscription reussi avec succes");  
            }
            else
            {
                MessageBox.Show("Un probleme est survenue lors de l'enregistrement veuillez réessayer ulterieument");
            }
        }
    }
}
