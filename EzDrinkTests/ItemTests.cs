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
    public class ItemTests
    {

        [TestMethod()]
        public void ItemTest()
        {
            Item item = new Item();
            Assert.AreEqual(item.Name = "11", "11");
            Assert.AreEqual(item.Name, "11");
            Assert.AreEqual(item.Price, 0);
            Assert.AreEqual(item.Price = 10, 10);
            Assert.AreEqual(item.IsDrink, true);
        }
    }
}