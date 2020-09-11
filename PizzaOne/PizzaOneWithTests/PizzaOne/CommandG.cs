using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PizzaOne;
using System.Windows.Forms;


namespace PizzaCommend
{

    public class CommandG
    {
        private Pizza pizza;
        
        public Pizza Pizza_configured
        {
            get
            {
               return pizza;
            }
        }
        public CommandG(List<CheckBox> ingredient,string taille = "normal")
        {
            
            if (taille == "petite")
            {
                 pizza = new Pizza(10.0, 20, taille);
                Garnison(pizza, ingredient);


            }
            else
            {
                if (taille == "normal")
                {
                    pizza = new Pizza(10.0);
                    Garnison(pizza,ingredient);
                }
                else
                {
                    if (taille == "grand")
                    {
                      pizza = new Pizza(10.0, 40, taille);
                        Garnison(pizza, ingredient);

                    }
                    else
                    {
                        pizza = new Pizza(10.0, 50, taille);
                        Garnison(pizza, ingredient);
                    }
                }
            }

        }


    
        private void Garnison(Pizza pizzaChosen,List<CheckBox>ingredient)
        {
            foreach (CheckBox Item in ingredient)
            {
                if (Item.Checked)
                {
                    if (Item.Text == "Jambon")
                    {
                        pizzaChosen.AddIngredient(new Ingredient("jambon", 3.50));
                    }
                    if (Item.Text == "Chorizo")
                    {
                        pizzaChosen.AddIngredient(new Ingredient("chorizo", 2.50));
                    }
                    if (Item.Text == "Poivron")
                    {
                        pizzaChosen.AddIngredient(new Ingredient("poivron", 1.50));
                    }
                }
                
            }         
            
        }

    }
}
