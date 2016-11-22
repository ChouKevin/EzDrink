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
    public class OrderListTests
    {
        OrderList _orderList;
        [TestInitialize()]
        public void Initialize()
        {
            _orderList = new OrderList();
        }
        [TestMethod()]
        public void OrderListTest()
        {
            Assert.AreEqual(_orderList.GetList().Count, 0);
        }

        [TestMethod()]
        public void OrderDrinkTest()
        {
            Assert.AreEqual(_orderList.GetDrinkCount(), 0);
            _orderList.OrderDrink(new Drink("D"));
            Assert.AreEqual(_orderList.GetDrinkCount(), 1);
            _orderList.OrderDrink(new Drink("DD", 22));
            Assert.AreEqual(_orderList.GetDrinkCount(), 2);
        }

        [TestMethod()]
        public void AddDrinkAdditionTest()
        {
            Assert.AreEqual(_orderList.GetDrinkCount(), 0);
            _orderList.AddDrinkAddition(-1, new DrinkAddition("A"));
            Assert.AreEqual(_orderList.GetDrinkCount(), 0);
            _orderList.AddDrinkAddition(0, new DrinkAddition("A"));
            Assert.AreEqual(_orderList.GetDrinkCount(), 0);
            _orderList.AddDrinkAddition(1, new DrinkAddition("A"));
            Assert.AreEqual(_orderList.GetDrinkCount(), 0);
            _orderList.OrderDrink(new Drink("DD"));
            Assert.AreEqual(_orderList.GetDrinkCount(), 1);
            _orderList.AddDrinkAddition(-1, new DrinkAddition("A"));
            Assert.AreEqual(_orderList.GetDrinkCount(), 1);
            _orderList.AddDrinkAddition(0, new DrinkAddition("A"));
            Assert.AreEqual(_orderList.GetDrinkCount(), 1);
            _orderList.AddDrinkAddition(1, new DrinkAddition("A"));
            Assert.AreEqual(_orderList.GetDrinkCount(), 1);
        }

        [TestMethod()]
        public void DeleteDrinkTest()
        {
            Assert.AreEqual(_orderList.GetDrinkCount(), 0);
            _orderList.DeleteDrink(0);
            Assert.AreEqual(_orderList.GetDrinkCount(), 0);
            _orderList.OrderDrink(new Drink("D", 110));
            Assert.AreEqual(_orderList.GetDrinkCount(), 1);
            _orderList.DeleteDrink(-1);
            Assert.AreEqual(_orderList.GetDrinkCount(), 1);
            _orderList.DeleteDrink(1);
            Assert.AreEqual(_orderList.GetDrinkCount(), 1);
            _orderList.DeleteDrink(0);
            Assert.AreEqual(_orderList.GetDrinkCount(), 0);
        }

        [TestMethod()]
        public void CountMoneyTest()
        {
            Assert.AreEqual(_orderList.CountMoney(), 0);
            _orderList.OrderDrink(new Drink("D", 100));
            Assert.AreEqual(_orderList.CountMoney(), 100);
            _orderList.AddDrinkAddition(0, new DrinkAddition("A", 5));
            Assert.AreEqual(_orderList.CountMoney(), 105);
        }
        [TestMethod()]
        public void GetOrderedDrinkTest()
        {
            Assert.AreEqual(_orderList.GetOrderedDrink(-1), null);
            Assert.AreEqual(_orderList.GetOrderedDrink(0), null);
            Assert.AreEqual(_orderList.GetOrderedDrink(1), null);
            _orderList.OrderDrink(new Drink("D", 55));
            Assert.AreEqual(_orderList.GetOrderedDrink(-1), null);
            Assert.AreNotEqual(_orderList.GetOrderedDrink(0), null);
            Assert.AreEqual(_orderList.GetOrderedDrink(1), null);
        }
    }
}