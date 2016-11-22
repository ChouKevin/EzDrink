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
    public class PageListTests
    {
        PageList _pageList;
        PrivateObject _PageObject;
        [TestInitialize()]
        public void Initialize()
        {
            _pageList = new PageList();
            _PageObject = new PrivateObject(_pageList);
        }
        [TestMethod()]
        public void PageListTest()
        {
            Assert.AreEqual(_PageObject.GetFieldOrProperty("_pageNumber"), 0);
            Assert.AreNotEqual(_PageObject.GetFieldOrProperty("_orderListPage"), null);
        }

        [TestMethod()]
        public void AddPageTest()
        {
            Assert.AreEqual(_PageObject.GetFieldOrProperty("_pageNumber"), 0);
            _pageList.AddPage();
            Assert.AreEqual(_PageObject.GetFieldOrProperty("_pageNumber"), 1);
        }

        [TestMethod()]
        public void StorePageTest()
        {
            Assert.AreEqual(_PageObject.GetFieldOrProperty("_pageNumber"), 0);
            _pageList.StorePage();
            Assert.AreEqual(_PageObject.GetFieldOrProperty("_pageNumber"), 0);
        }

        [TestMethod()]
        public void GetListTest()
        {
            Assert.AreEqual(_pageList.GetList(-1).GetDrinkCount(), 0);
            Assert.AreEqual(_pageList.GetList(0).GetDrinkCount(), 0);
            Assert.AreEqual(_pageList.GetList(1).GetDrinkCount(), 0);
        }

        [TestMethod()]
        public void AddItemTest()
        {
            _pageList.AddItem(new Drink("da", 11), -1);
            _pageList.AddItem(new Drink("asd"), 0);
            _pageList.AddItem(new Drink("asddd", 213), 1);
            Assert.AreEqual(_pageList.GetAmountOfDrink(), 3);
        }

        [TestMethod()]
        public void GetOrderDrinkTest()
        {
            Assert.AreEqual(_pageList.GetOrderDrink(1), null);
            _pageList.AddItem(new Drink("da", 123), 0);
            Assert.AreNotEqual(_pageList.GetOrderDrink(0), null);
            Assert.AreEqual(_pageList.GetAmountOfDrink(), 1);
        }

        [TestMethod()]
        public void DeleteDrinkTest()
        {
            _pageList.DeleteDrink(0);
            Assert.AreEqual(_pageList.GetList(0).GetDrinkCount(), 0);
            _pageList.AddItem(new Drink("da", 123), 0);
            Assert.AreEqual(_pageList.GetList(0).GetDrinkCount(), 1);
            _pageList.DeleteDrink(0);
            Assert.AreEqual(_pageList.GetList(0).GetDrinkCount(), 0);
        }

        [TestMethod()]
        public void GetAmountOfDrinkTest()
        {

        }

        [TestMethod()]
        public void SetDrinkPropertyTest()
        {
            string property = "Sugar";
            string mistack = "sad";
            _pageList.AddItem(new Drink("da", 13), 1);
            _pageList.SetDrinkProperty("Suar", property, -1);
            Assert.AreEqual(_pageList.GetOrderDrink(0).Sugar, "");
            _pageList.SetDrinkProperty("Sur", property, 0);
            Assert.AreEqual(_pageList.GetOrderDrink(0).Sugar, "Sur");
            _pageList.SetDrinkProperty("sa", mistack, -1);
            Assert.AreEqual(_pageList.GetOrderDrink(0).Temperature, "");
            _pageList.SetDrinkProperty("Sugr", mistack, 0);
            Assert.AreEqual(_pageList.GetOrderDrink(0).Temperature, "Sugr");
        }

        [TestMethod()]
        public void GetTotalPriceTest()
        {
            _pageList.AddItem(new Drink("dd", 20), 0);
            Assert.AreEqual(_pageList.GetTotalPrice(0), 20);
            _pageList.AddItem(new DrinkAddition("AA", 120), 0);
            Assert.AreEqual(_pageList.GetTotalPrice(0), 140);
            _pageList.AddPage();
            _pageList.AddItem(new Drink("dd", 20), 1);
            Assert.AreEqual(_pageList.GetTotalPrice(1), 20);
            _pageList.AddItem(new DrinkAddition("AA", 120), 1);
            Assert.AreEqual(_pageList.GetTotalPrice(1), 20);
            Assert.AreEqual(_pageList.GetTotalPrice(3), 20);
        }

        [TestMethod()]
        public void GetTimeTest()
        {
            AddItemTest();
            _pageList.AddItem(new Drink("dd", 20), 1);
            _pageList.StorePage();
            Assert.AreNotEqual(_pageList.GetTime(0), null);
        }

        [TestMethod()]
        public void GetHistoryRecordTest()
        {
            GetTimeTest();
            Assert.AreNotEqual(_pageList.GetHistoryRecord().Count, 0);
        }
    }
}