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
using PizzaCommend;


namespace PizzaCommend
{
    public partial class IngredientForm : Form
    {
        public string choice = "normal";
        public Pizza pizza;
        
        public List<CheckBox> garniture;
        


        public Pizza Pizza
        {
            get
            {
                return pizza;
            }
        }
        public string Taille
        {
            get { return choice; }
        }
        public IngredientForm()
        {
            InitializeComponent();
        }

        private void rdbPetite_CheckedChanged(object sender, EventArgs e)
        {
            if(rdbPetite.Checked == true)
            {
                choice = "petite";
                
            }
        }

        private void rdbNormal_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbNormal.Checked == true)
            {
                choice = "normal";
                
            }
        }

        private void rdbGrande_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbGrande.Checked == true)
            {
                choice = "grand";
               
            }
        }

        private void rdbFamiliale_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbFamiliale.Checked == true)
            {
                choice = "familiale";
                
            }
        }



        private void cmdValidate_Click(object sender, EventArgs e)
        {
            garniture = new List<CheckBox>();
            garniture.Add(chkJambon);
            garniture.Add(chkChorizo);
            garniture.Add(chkPoivron);
            
            CommandG pizzaChosen = new CommandG(garniture,choice);
            pizza = pizzaChosen.Pizza_configured;
            DialogResult = DialogResult.OK;
            Close();
           
        }


    }
}
