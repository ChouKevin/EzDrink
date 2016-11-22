using Microsoft.VisualStudio.TestTools.UnitTesting;
using EzDrink;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EzDrink.Tests
{
    [TestClass()]
    public class DrinkTests
    {
        [TestMethod()]
        public void DrinkTest()
        {
            Drink drink = new Drink("dd", 10);
            Assert.AreEqual(drink.Name, "dd");
            Assert.AreEqual(drink.Price, 10);
            Assert.AreEqual(drink.IsDrink, true);
        }
    }
}