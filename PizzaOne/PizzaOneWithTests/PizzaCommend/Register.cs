using PizzaOne;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PizzaCommend
{
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }

        private void cmd_cancel_Click(object sender, EventArgs e)
        {
            txt_confirmPwd.Text = "";
            txt_name.Text = "";
            txt_pwd.Text = "";
        }

        private void cmd_submit_Click(object sender, EventArgs e)
        {
            if (txt_pwd.Text == txt_confirmPwd.Text)
            {
                
                hashPassword hashPassword = new hashPassword(txt_pwd.Text);
                
                string query = $"SELECT password FROM users where name ='{txt_name.Text}';";
                DbConnectorParam userCheck = new DbConnectorParam(query);
                if (userCheck.Result == "") {

                    string squery = $"INSERT INTO users(name,password,salt)VALUE('{txt_name.Text}','{hashPassword.Pwd_hashed}','{hashPassword.Pwd_Salt}');";
                    DbConnectorParam registring = new DbConnectorParam(squery);
                    DbConnectorParam registryCheck = new DbConnectorParam(query);
                    if (registryCheck.Result == hashPassword.Pwd_hashed )
                    {
                        DialogResult = DialogResult.OK;
                        Close();
                    }
                    else
                    {
                        MessageBox.Show("Register fail");
                    }

                     
                }
                else
                {
                    MessageBox.Show("Le nom d'utilisateur fourni est déjà utilisé\n Veuillez inserer un autre nom");
                }
            }
            else
            {
                MessageBox.Show("password not match");
            }
        }
    }
}
