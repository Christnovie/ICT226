using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using PizzaOne;

namespace PizzaOneTests
{
    [TestClass]
    public class PizzaPrice
    {
        [TestMethod]
        public void Empty_Pizza_Has_Base_Price()
        {
            Pizza pizza = new Pizza(10.0);

            Assert.AreEqual(10.0, pizza.Price);
        }

        [TestMethod]
        public void Pizza_With_One_Ingredient_Has_Correct_Price()
        {
            Pizza pizza = new Pizza(10.0);
            Ingredient ingredient = new Ingredient("Ham", 2.5);
            pizza.AddIngredient(ingredient);

            Assert.AreEqual(12.5, pizza.Price);
        }

        [TestMethod]
        public void Pizza_With_One_Ingredient_Contains_Ingredient_Name()
        {
            Pizza pizza = new Pizza(10.0);
            Ingredient ingredient = new Ingredient("Ham", 2.5);
            pizza.AddIngredient(ingredient);

            StringAssert.Contains(pizza.ToString(), "Ham");
        }

        [TestMethod]
        public void Pizza_With_Two_Ingredients_Has_Correct_Price()
        {
            Pizza pizza = new Pizza(10.0);
            Ingredient ingredient = new Ingredient("Ham", 2.5);
            Ingredient other = new Ingredient("Mushroom", 1.0);
            pizza.AddIngredient(ingredient);
            pizza.AddIngredient(other);

            Assert.AreEqual(13.5, pizza.Price);
        }

        [TestMethod]
        public void Pizza_With_Two_Ingredients_Contains_Ingredients_Name()
        {
            Pizza pizza = new Pizza(10.0);
            Ingredient ingredient = new Ingredient("Ham", 2.5);
            Ingredient other = new Ingredient("Mushroom", 1.0);
            pizza.AddIngredient(ingredient);
            pizza.AddIngredient(other);

            StringAssert.Contains(pizza.ToString(), "Ham");
            StringAssert.Contains(pizza.ToString(), "Mushroom");
        }
    }
}
