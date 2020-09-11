using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaOne
{
    public class Pizza
    {
        private double basePrice;
        private string sizeName;
        
        private List<Ingredient> ingredients;
        

        public Pizza(double basePrice,double size = 30,string sizes = "normal")
        {
            this.sizeName = sizes;

            this.basePrice = basePrice*size/30;           
            
            ingredients = new List<Ingredient>();
        }

        public void AddIngredient(Ingredient ingredient)
        {
            
            ingredients.Add(ingredient);
        }
        public string SizeName
        {
            get
            {
                return sizeName;
            }
        }

        public double Price
        {
                 

            get {
                double basePrice = this.basePrice;
                foreach (Ingredient Item in ingredients) basePrice += Item.Price;
                return basePrice  ;
            }
          

        }
        public List<Ingredient> Ingredients
        {
            get
            {
                return ingredients;
            }
        } 

        public override string ToString()
        {
            string sum = "Pizza avec ";

            foreach (Ingredient Item in ingredients)
            {
                sum += $" {Item},";

            }
            return sum;
        }
    }


}
