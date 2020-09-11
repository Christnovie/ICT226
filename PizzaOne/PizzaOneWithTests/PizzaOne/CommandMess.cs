using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace PizzaOne
{
    public class CommandMess
    {
        public CommandMess(TextBox txtName,List<Pizza> pizzaList)
        {
            Command totalPrice = new Command(pizzaList);
            string commandList = "List \n";
            foreach (Pizza Item in pizzaList)
            {
                commandList += $"{Item.SizeName} {Item} pour {Math.Round(Item.Price, 2)}.-CHF \n";
            }
            commandList += $"Prix total de: {Math.Round(totalPrice.TotalPrice,2)}.-CHF";
            if (txtName.Text == "")
            {
                MessageBox.Show("Veuillez mettre votre nom");

            }
            else
            {
                MessageBox.Show("Votre commande \n" +
                    txtName.Text + "\n" + commandList);

            }
            commandList = "";
            pizzaList = new List<Pizza>();
            
        }

    }
}
