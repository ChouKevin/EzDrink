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
    public class DrinkModelTests
    {
        DrinkModel _model;
        [TestInitialize()]
        public void Initialize()
        {
            _model = new DrinkModel();
        }

        [TestMethod()]
        public void OrderDrinkTest()
        {
            Assert.AreEqual(_model.GetOrderList().GetDrinkCount(), 0);
            for (int i = 0; i < 10; i++)
            {
                _model.AddItem(i.ToString(), i, "drink");
                _model.OrderDrink(i.ToString());
            }
            Assert.AreEqual(_model.GetOrderList().GetDrinkCount(), 10);

        }

        [TestMethod()]
        public void GetDrinkDataTest()
        {
            Assert.AreEqual(_model.GetDrinkData().Count, 0);
            for (int i = 0; i < 10; i++)
            {
                _model.AddItem(i.ToString() + "d", i, "drink");
            }
            Assert.AreEqual(_model.GetDrinkData().Count, 10);
            for (int i = 0; i < 10; i++)
            {
                Assert.AreEqual(_model.GetDrinkData()[i].Name, i.ToString() + "d");
                Assert.AreEqual(_model.GetDrinkData()[i].Price, i);
            }
        }

        [TestMethod()]
        public void GetDrinkAdditionTest()
        {
            Assert.AreEqual(_model.GetDrinkAddition().Count, 0);
            for (int i = 0; i < 10; i++)
            {
                _model.AddItem(i.ToString() + "a", i, "addition");
            }
            Assert.AreEqual(_model.GetDrinkAddition().Count, 10);
            for (int i = 0; i < 10; i++)
            {
                Assert.AreEqual(_model.GetDrinkAddition()[i].Name, i.ToString() + "a");
                Assert.AreEqual(_model.GetDrinkAddition()[i].Price, i);
            }
        }

        [TestMethod()]
        public void GetOrderListTest()
        {
            GetDrinkDataTest();
            int price = 0;
            for (int i = 0; i < 10; i++)
            {
                _model.OrderDrink(i.ToString() + "d", 0);
                price += i;
            }
            Assert.AreEqual(_model.GetOrderList().CountMoney(), price);
            Assert.AreEqual(_model.GetOrderList().GetDrinkCount(), 10);
            for (int i = 0; i < 10; i++)
            {
                Assert.AreEqual(_model.GetOrderList().GetOrderedDrink(i).GetDrinkName(), i.ToString() + "d");
                Assert.AreEqual(_model.GetOrderList().GetOrderedDrink(i).GetTotalPrice(), i);
            }
        }

        [TestMethod()]
        public void DeleteOrderedDrinkTest()
        {
            GetOrderListTest();
            _model.DeleteOrderedDrink(-1);
            _model.DeleteOrderedDrink(0);
            _model.DeleteOrderedDrink(11);
            Assert.AreEqual(_model.GetOrderedDrinkCount(), 9);
        }

        [TestMethod()]
        public void AddOrderListTest()
        {
            Assert.AreEqual(_model.GetOrderList(0), _model.GetOrderList(1));
            _model.AddOrderList();
            Assert.AreNotEqual(_model.GetOrderList(0), _model.GetOrderList(1));
        }

        [TestMethod()]
        public void SetListTest()
        {
            Assert.AreEqual(_model.SetList("drink", "DrinkList"), EzText.SUCCESS);
            Assert.AreEqual(_model.SetList("addition", "AdditionList"), EzText.SUCCESS);
        }

        [TestMethod()]
        public void AddItemTest()
        {
            Assert.AreEqual(_model.AddItem("drink", 213, "drink"), true);
            Assert.AreEqual(_model.AddItem("drink", 21, "drink"), false);
            Assert.AreEqual(_model.AddItem("drink", 213, "addition"), false);
            Assert.AreEqual(_model.AddItem("addition", 13, "addition"), true);
            Assert.AreEqual(_model.AddItem("addition", 3, "drink"), false);
            Assert.AreEqual(_model.AddItem("rrrrrr", 213, "eeeeee"), false);
        }

        [TestMethod()]
        public void SetDrinkSugarOrIceTest()
        {
            AddItemTest();
            _model.OrderDrink("drink");
            _model.SetDrinkSugarOrIce("T", "sugar", -1);
            Assert.AreEqual(_model.GetOrderedDrink(0).Sugar, "");
            _model.SetDrinkSugarOrIce("T", "Sugar", 0);
            Assert.AreEqual(_model.GetOrderedDrink(0).Sugar, "T");
            _model.SetDrinkSugarOrIce("S", "TTTTT", -1);
            Assert.AreEqual(_model.GetOrderedDrink(0).Temperature, "");
            _model.SetDrinkSugarOrIce("S", "sugar", 0);
            Assert.AreEqual(_model.GetOrderedDrink(0).Temperature, "S");
        }

        [TestMethod()]
        public void DeleteItemListTest()
        {
            _model.DeleteItemList("drink", -1);
            _model.DeleteItemList("drink", 0);
            _model.DeleteItemList("addition", -1);
            _model.DeleteItemList("addition", 0);
            AddItemTest();
            _model.DeleteItemList("drink", 0);
            Assert.AreEqual(_model.GetDrinkData().Count, 0);
            _model.DeleteItemList("addition", 0);
            Assert.AreEqual(_model.GetDrinkAddition().Count, 0);
        }

        [TestMethod()]
        public void ModifyItemListTest()
        {
            AddItemTest();
            _model.ModifyItemList("drink", 0, "名稱", "ddrink");
            _model.ModifyItemList("drink", 0, "價錢", "ddrink");
            Assert.AreEqual(_model.GetDrinkData()[0].Name, "ddrink");
            Assert.AreEqual(_model.GetDrinkData()[0].Price, 0);
            _model.ModifyItemList("addition", 0, "名稱", "aaddition");
            _model.ModifyItemList("addition", 0, "價錢", "aaddition");
            Assert.AreEqual(_model.GetDrinkAddition()[0].Name, "aaddition");
            Assert.AreEqual(_model.GetDrinkAddition()[0].Price, 0);
        }

        [TestMethod()]
        public void StoreListTest()
        {
            _model.StoreList();
            Assert.AreNotEqual(_model.GetOrderList(1), null);
        }

        [TestMethod()]
        public void ListTotalPriceTest()
        {
            AddItemTest();
            _model.OrderDrink("drink");
            Assert.AreEqual(_model.ListTotalPrice(), 213);
            _model.StoreList();
            _model.OrderDrink("drink");
            _model.OrderDrink("drink");
            Assert.AreEqual(_model.ListTotalPrice(), 426);
        }

        [TestMethod()]
        public void GetHistoryListTest()
        {
            Assert.AreEqual(_model.GetHistoryList().Count, 0);
        }
    }
}