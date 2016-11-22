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
    public class DataManageTests
    {
        DataManage _dataManage;
        [TestInitialize()]
        public void Initialize()
        {
            _dataManage = new DataManage();
        }
        [TestMethod()]
        public void ModifyDataTest()
        {
            _dataManage.ModifyData("drink", -1, "名稱", "asd");
            _dataManage.ModifyData("drink", 0, "名稱", "asd");
            _dataManage.ModifyData("addition", -1, "名稱", "asd");
            _dataManage.ModifyData("addition", 0, "名稱", "asd");
            _dataManage.AddData("dad", 1341, "drink");
            _dataManage.AddData("sad", 1341, "addition");

            Assert.AreNotEqual(_dataManage.ExistItem("dad"), null);
            _dataManage.ModifyData("drink", 0, "名稱", "asd");
            Assert.AreNotEqual(_dataManage.ExistItem("asd"), null);
            Assert.AreEqual(_dataManage.ExistItem("dad"), null);
            _dataManage.ModifyData("drink", 0, "價錢", "asd");
            Assert.AreEqual(_dataManage.ExistItem("asd").Price, 0);
            _dataManage.ModifyData("drink", 0, "價錢", "213");
            Assert.AreEqual(_dataManage.ExistItem("asd").Price, 213);

            Assert.AreNotEqual(_dataManage.ExistItem("sad"), null);
            _dataManage.ModifyData("addition", 0, "名稱", "aaa");
            Assert.AreNotEqual(_dataManage.ExistItem("aaa"), null);
            Assert.AreEqual(_dataManage.ExistItem("sad"), null);
            _dataManage.ModifyData("addition", 0, "價錢", "asd");
            Assert.AreEqual(_dataManage.ExistItem("aaa").Price, 0);
            _dataManage.ModifyData("addition", 0, "價錢", "213");
            Assert.AreEqual(_dataManage.ExistItem("aaa").Price, 213);
        }

        [TestMethod()]
        public void AddDataTest()
        {
            Assert.AreEqual(_dataManage.AddData("dasd", 1233, "drink"), true);
            Assert.AreEqual(_dataManage.AddData("dasd", 1233, "drink"), false);
            Assert.AreEqual(_dataManage.AddData("dasd", 66, "drink"), false);
            Assert.AreEqual(_dataManage.AddData("dasd", 1233, "addition"), false);
            Assert.AreEqual(_dataManage.AddData("dasd", 66, "addition"), false);
            Assert.AreEqual(_dataManage.AddData("aaa", 1233, "addition"), true);
            Assert.AreEqual(_dataManage.AddData("aaa", 1233, "drink"), false);
        }

        [TestMethod()]
        public void DeleteTest()
        {
            _dataManage.Delete("drink", -1);
            _dataManage.Delete("drink", 0);
            _dataManage.Delete("addition", -1);
            _dataManage.Delete("addition", 0);
            _dataManage.AddData("ddd", 894, "drink");
            _dataManage.AddData("aaa", 894, "addition");
            Assert.AreNotEqual(_dataManage.ExistItem("ddd"), null);
            Assert.AreNotEqual(_dataManage.ExistItem("aaa"), null);
            _dataManage.Delete("drink", 0);
            Assert.AreEqual(_dataManage.ExistItem("ddd"), null);
            _dataManage.Delete("addition", 0);
            Assert.AreEqual(_dataManage.ExistItem("aaa"), null);
        }

        [TestMethod()]
        public void ImportFileTest()
        {
            Assert.AreEqual(_dataManage.ImportFile("dd", "dasd"), EzText.ERROR);
            Assert.AreEqual(_dataManage.ImportFile("dd", "dasd", "dasd"), EzText.ERROR);
            Assert.AreEqual(_dataManage.ImportFile("dd", path : "dasd"), EzText.ERROR);
            Assert.AreEqual(_dataManage.ImportFile("dd", path: "dasd"), EzText.ERROR);

            Assert.AreEqual(_dataManage.ImportFile("drink", "DrinkList"), EzText.SUCCESS);
            Assert.AreEqual(_dataManage.ImportFile("addition", "AdditionList"), EzText.SUCCESS);
            Initialize();
            Assert.AreEqual(_dataManage.ImportFile("drink", "DrinkList", "..\\..\\..\\EzDrink\\TextFile\\" + "DrinkList.txt"), EzText.SUCCESS);
            Assert.AreEqual(_dataManage.ImportFile("addition", "AdditionList", "..\\..\\..\\EzDrink\\TextFile\\" + "AdditionList.txt"), EzText.SUCCESS);
            Initialize();
            Assert.AreEqual(_dataManage.ImportFile("drink", path : "..\\..\\..\\EzDrink\\TextFile\\" + "DrinkList.txt"), EzText.SUCCESS);
            Assert.AreEqual(_dataManage.ImportFile("addition", path : "..\\..\\..\\EzDrink\\TextFile\\" + "AdditionList.txt"), EzText.SUCCESS);
            Initialize();
            Assert.AreEqual(_dataManage.ImportFile("dd", path: "..\\..\\..\\EzDrink\\TextFile\\" + "DrinkList.txt"), EzText.ERROR);
            Assert.AreEqual(_dataManage.ImportFile("aa", path: "..\\..\\..\\EzDrink\\TextFile\\" + "AdditionList.txt"), EzText.ERROR);
        }

        [TestMethod()]
        public void ExistItemTest()
        {
            Assert.AreEqual(_dataManage.ExistItem("aaa"), null);
            _dataManage.AddData("aaa", 21, "drink");
            Assert.AreEqual(_dataManage.ExistItem("aaa").Name, "aaa");
            Assert.AreEqual(_dataManage.ExistItem("aaa").Price, 21);
            _dataManage.AddData("add", 212, "addition");
            Assert.AreEqual(_dataManage.ExistItem("add").Name, "add");
            Assert.AreEqual(_dataManage.ExistItem("add").Price, 212);
        }

        [TestMethod()]
        public void GetDrinkDataTest()
        {
            Assert.AreEqual(_dataManage.GetDrinkData().Count, 0);
            _dataManage.AddData("aaa", 21, "drink");
            _dataManage.AddData("aaa", 21, "drink");
            _dataManage.AddData("ada", 21, "drink");
            _dataManage.AddData("aad", 21, "drink");
            Assert.AreEqual(_dataManage.GetDrinkData().Count, 3);
        }

        [TestMethod()]
        public void GetAdditionDataTest()
        {
            Assert.AreEqual(_dataManage.GetAdditionData().Count, 0);
            _dataManage.AddData("aaa", 21, "addition");
            _dataManage.AddData("aaa", 21, "addition");
            _dataManage.AddData("ada", 21, "addition");
            _dataManage.AddData("aad", 21, "addition");
            Assert.AreEqual(_dataManage.GetAdditionData().Count, 3);
        }
    }
}