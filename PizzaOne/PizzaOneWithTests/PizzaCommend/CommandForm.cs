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
    public partial class wndPizzaCommend : Form
    {
        
        private List<Pizza> commande;
        public wndPizzaCommend()
        {
            InitializeComponent();
            commande = new List<Pizza>();
        }

        private void lblName_Click(object sender, EventArgs e)
        {

        }
        private void cmdTerminer_Click(object sender, EventArgs e)
        {
            new CommandMess(txtName, commande);
            
        }
        private void cmdAddPizza_Click(object sender, EventArgs e)
        {
            IngredientForm newPizza = new IngredientForm();
            if(newPizza.ShowDialog() == DialogResult.OK)
            {
                commande.Add(newPizza.Pizza);
            }
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {
            lblName.Text = txtName.Text;
            if (txtName.Text == "") 
            {
                lblName.Text = "Nom du client";
            }
        }

        private void cmdAdress_Click(object sender, EventArgs e)
        {
            if (cmdAdress.Text == "Deconnection")
            {
                cmdAdress.Text = "Connexion";
            }
            else
            {
                wnd_Login2 login = new wnd_Login2();
                if (login.ShowDialog() == DialogResult.OK)
                {
                    
                    MessageBox.Show("connection reussi");
                    lblName.Text = login.User;
                    txtName.Text = login.User;
                    cmdAdress.Text = "Deconnection";
                }
            }
        }
    }
}
