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
    public class OrderedDrinkTests
    {
        OrderedDrink _orderedDrink;
        [TestInitialize()]
        public void Initialize()
        {
             _orderedDrink = new OrderedDrink();
        }
        [TestMethod()]
        public void OrderedDrinkTest()
        {
            Assert.AreEqual(_orderedDrink.Sugar, "");
            Assert.AreEqual(_orderedDrink.Temperature, "");
        }

        [TestMethod()]
        public void SetDrinkTest()
        {
            _orderedDrink.SetDrink(new Drink("DD", 100));
            Assert.AreEqual(_orderedDrink.GetDrinkName(), "DD");
            Assert.AreEqual(_orderedDrink.GetTotalPrice(), 100);
        }

        [TestMethod()]
        public void AddAdditionTest()
        {
            Assert.AreEqual(_orderedDrink.AddAddition(new DrinkAddition("aa")), true);
            Assert.AreEqual(_orderedDrink.AddAddition(new DrinkAddition("aa")), false);
            Assert.AreEqual(_orderedDrink.GetAdditionName(), "aa,");
            _orderedDrink.AddAddition(new DrinkAddition("dddd", 2222));
            Assert.AreEqual(_orderedDrink.GetAdditionName(), "aa,dddd,");
            Assert.AreEqual(_orderedDrink.GetTotalPrice(), 2222);
            _orderedDrink.SetDrink(new Drink("DD", 100));
            Assert.AreEqual(_orderedDrink.GetTotalPrice(), 2322);
        }
        [TestMethod()]
        public void SugarTest()
        {
            _orderedDrink.Sugar = "SSSS";
            Assert.AreEqual(_orderedDrink.Sugar, "SSSS");
        }
        [TestMethod()]
        public void TemperatureTest()
        {
            _orderedDrink.Temperature = "TTTT";
            Assert.AreEqual(_orderedDrink.Temperature, "TTTT");
        }
    }
}