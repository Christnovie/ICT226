using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using PizzaOne;

namespace PizzaOneTests
{
    [TestClass]
    public class SizedPizzaPrice
    {
        [TestMethod]
        public void Small_Pizza_Has_Lower_Price()
        {
            Pizza pizza = new Pizza(10.0);
            Pizza smallPizza = new Pizza(10.0, 20);

            Assert.IsTrue(smallPizza.Price < pizza.Price);
        }

        [TestMethod]
        public void Regular_Pizza_Has_Same_Price()
        {
            Pizza pizza = new Pizza(10.0);
            Pizza regularPizza = new Pizza(10.0, 30);

            Assert.AreEqual(regularPizza.Price, pizza.Price);
        }

        [TestMethod]
        public void Big_Pizza_Has_Greater_Price()
        {
            Pizza pizza = new Pizza(10.0);
            Pizza bigPizza = new Pizza(10.0, 40);

            Assert.IsTrue(bigPizza.Price > pizza.Price);
        }
        [TestMethod]
        public void Familial_Pizza_Has_Greater_Price()
        {
            Pizza pizza = new Pizza(10.0);
            Pizza bigPizza = new Pizza(10.0, 40);
            Pizza familialPizza =  new Pizza(10.0,50);

            Assert.IsTrue(bigPizza.Price > pizza.Price);
            Assert.IsTrue(familialPizza.Price > bigPizza.Price);
        }

    }
}
