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
    public class DrinkAdditionTests
    {
        [TestMethod()]
        public void DrinkAdditionTest()
        {
            DrinkAddition addition = new DrinkAddition("aa", 1111);
            Assert.AreEqual(addition.Name, "aa");
            Assert.AreEqual(addition.Price, 1111);
            Assert.AreEqual(addition.IsDrink, false);
        }
    }
}