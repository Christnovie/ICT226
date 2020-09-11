using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Windows.Forms;
using PizzaOne;
using System.Security.Cryptography.X509Certificates;
using PizzaCommend;

namespace PizzaOneTests
{
    [TestClass]
    public class Command
    {
        public List<CheckBox> garniture;
        [TestMethod]
        public void pizza_is_create_with_ingredient()
        {           
           
           
            CheckBox chkPoivron = new CheckBox();
            chkPoivron.Text = "Poivron";
            chkPoivron.Checked = true;
            
            garniture = new List<CheckBox>();
            garniture.Add( new CheckBox());
            garniture.Add(chkPoivron);
            garniture.Add(new CheckBox());

            CommandG pizzaChosen = new CommandG(garniture);
            Assert.IsTrue(pizzaChosen.Pizza_configured.Ingredients.Count > 0);
            
        }


    }
}
