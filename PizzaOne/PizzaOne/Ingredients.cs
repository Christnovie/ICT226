using NPOI.SS.Formula.Functions;
using NPOI.SS.UserModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaOne
{
    public class Ingredient
    {
        private string name;
        private double price;

        public void Ingredients(string name,double price)
        {
            this.name = name;
            this.price = price;
        }

        public double Price
        {
            get{ return price; }

        }
        public override string ToString()
        {
            return $"{price}";
        }



    }
}
