using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;


namespace PizzaOne
{
    public class Command
    {
        public double totalPrice;
      

        public double TotalPrice
        {
            get
            {
                return totalPrice;
            }
        }
        public Command(List<Pizza> pizzas)
        {
            foreach(Pizza Item in pizzas)
            {
                totalPrice += Item.Price;
            }
            
        }
       
    }
}
