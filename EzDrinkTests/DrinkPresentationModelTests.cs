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
    public class DrinkPresentationModelTests
    {
        DrinkPresentationModel _model;
        DrinkModel _drinkModel;
        PrivateObject _modelObject;
        [TestInitialize()]
        public void Initialize()
        {
            _drinkModel = new DrinkModel();
            _model = new DrinkPresentationModel(_drinkModel);
            _modelObject = new PrivateObject(_model);
        }

        [TestMethod()]
        public void SetOrderedNameTest()
        {
            _model.SetOrderedName("dd");
            Assert.AreEqual(_modelObject.GetFieldOrProperty("_orderedName"), "dd");
        }

        [TestMethod()]
        public void IsCheckOutOkTest()
        {
            Assert.AreEqual(_model.IsCheckOutOk(), false);
            _drinkModel.AddItem("dd", 10, "drink");
            _drinkModel.OrderDrink("dd");
            Assert.AreEqual(_model.IsCheckOutOk(), false);
            _model.SelectedDrinkIndex = 0;
            _model.SetSugarAndIce("ss", "Sugar");
            Assert.AreEqual(_model.IsCheckOutOk(), false);
            _model.SetSugarAndIce("tt", "T");
            Assert.AreEqual(_model.IsCheckOutOk(), true);
        }

        [TestMethod()]
        public void IsAdditionOrderedTest()
        {
            IsCheckOutOkTest();
            _model.SelectedDrinkIndex = 1;
            Assert.AreEqual(_model.IsAdditionOrdered("aaa"), false);
            _model.SelectedDrinkIndex = 0;
            Assert.AreEqual(_model.IsAdditionOrdered("aaa"), false);
            _drinkModel.AddItem("aaa", 10, "addition");
            Assert.AreEqual(_model.IsAdditionOrdered("aaa"), false);
            _drinkModel.OrderDrink("aaa", 0);
            Assert.AreEqual(_model.IsAdditionOrdered("aaa"), true);
        }
        public void Nothing()
        {
        }
        [TestMethod()]
        public void ClickAndUseTest()
        {
            _model.SetOrderedName("dd");
            _drinkModel.AddItem("dd", 10, "drink");
            _drinkModel.AddItem("aa", 10, "addition");
            _model.ClickAndUse(EzText.ORDER, 0, Nothing);
            Assert.AreEqual(_drinkModel.GetOrderedDrink(0).GetDrinkName(), "dd");
            _model.SetOrderedName("aa");
            _model.ClickAndUse(EzText.ORDER, 0, Nothing);
            Assert.AreEqual(_drinkModel.GetOrderedDrink(0).GetAdditionName(), "aa,");
            _model.SelectedDrinkIndex = 1;
            _model.ClickAndUse(EzText.DELETE, 5, Nothing);
            Assert.AreEqual(_drinkModel.GetOrderedDrinkCount(), 1);
            _model.SelectedDrinkIndex = 0;
            _model.ClickAndUse(EzText.DELETE, 5, Nothing);
            Assert.AreEqual(_drinkModel.GetOrderedDrinkCount(), 0);
            _model.ClickAndUse("drink", 0, Nothing);
            Assert.AreEqual(_drinkModel.GetDrinkData().Count, 0);
            _model.ClickAndUse("addition", 0, Nothing);
            Assert.AreEqual(_drinkModel.GetDrinkAddition().Count, 0);
        }

        [TestMethod()]
        public void IsOrderedDrinkEmptyTest()
        {
            Assert.AreEqual(_model.IsOrderedDrinkEmpty(), true);
            _model.SetOrderedName("dd");
            _drinkModel.AddItem("dd", 10, "drink");
            _drinkModel.AddItem("aa", 10, "addition");
            _drinkModel.OrderDrink("dd");
            Assert.AreEqual(_model.IsOrderedDrinkEmpty(), false);
        }
        public void Nothing(string str1, string str2)
        {
            _model.SetOrderedName("aaa");
        }
        [TestMethod()]
        public void InputFileDataTest()
        {
            _model.InputFileData("DrinkList", "..\\..\\..\\EzDrink\\TextFile\\" + "DrinkList.txt", Nothing);
            Assert.AreEqual(_modelObject.GetFieldOrProperty("_orderedName"), null);
            _model.InputFileData("dad", "sad", Nothing);
            Assert.AreEqual(_modelObject.GetFieldOrProperty("_orderedName"), "aaa");
        }

        [TestMethod()]
        public void AddItemButtonChangeTest()
        {
            _model.AddItemName("drink", "ddd");
            _model.AddItemPrice("drink", "132");
            _model.AddItemName("addition", "aaa");
            _model.AddItemPrice("addition", "10");
            Assert.AreEqual(_model.InputAddition, false);
            Assert.AreEqual(_model.InputDrink, false);
            _model.AddItemButtonChange("drink", EzText.INPUT_ITEM, Nothing);
            Assert.AreEqual(_model.InputDrink, true);
            _model.AddItemButtonChange("drink", EzText.OK, Nothing);
            Assert.AreEqual(_model.InputDrink, false);
            _model.AddItemButtonChange("addition", EzText.OK, Nothing);
            Assert.AreEqual(_model.InputAddition, false);
            _model.AddItemButtonChange("addition", EzText.INPUT_ITEM, Nothing);
            Assert.AreEqual(_model.InputAddition, true);

        }

        [TestMethod()]
        public void ButtonChangeTest()
        {
            AddItemNameANDPriceTest();
            Item item = (Item)_modelObject.GetFieldOrProperty("_drink");
            Assert.AreEqual(_model.ButtonChange(item, "drink", EzText.INPUT_ITEM, Nothing), true);
            Assert.AreEqual(_model.ButtonChange(item, "drink", EzText.OK, Nothing), false);
            Assert.AreEqual(_modelObject.GetFieldOrProperty("_orderedName"), null);
            Assert.AreEqual(_model.ButtonChange(item, "drink", EzText.OK, Nothing), true);
            Assert.AreEqual(_modelObject.GetFieldOrProperty("_orderedName"), "aaa");
            Assert.AreEqual(_model.ButtonChange(item, "drink", EzText.CANCEL, Nothing), false);
            Assert.AreEqual(_model.ButtonChange(item, "drink", EzText.OK, Nothing), true);
        }

        [TestMethod()]
        public void ChangeButtonTextTest()
        {
            _model.InputDrink = true;
            Assert.AreEqual(_model.ChangeButtonText(EzText.INPUT_ITEM, "drink"), EzText.OK);
            Assert.AreEqual(_model.ChangeButtonText(EzText.FILE_INPUT, "drink"), EzText.CANCEL);
            _model.InputDrink = false;
            Assert.AreEqual(_model.ChangeButtonText(EzText.CANCEL, "drink"), EzText.FILE_INPUT);
            Assert.AreEqual(_model.ChangeButtonText(EzText.OK, "drink"), EzText.INPUT_ITEM);
            _model.InputAddition = true;
            Assert.AreEqual(_model.ChangeButtonText(EzText.INPUT_ITEM, "addition"), EzText.OK);
            Assert.AreEqual(_model.ChangeButtonText(EzText.FILE_INPUT, "addition"), EzText.CANCEL);
            _model.InputAddition = false;
            Assert.AreEqual(_model.ChangeButtonText(EzText.OK, "addition"), EzText.INPUT_ITEM);
            Assert.AreEqual(_model.ChangeButtonText(EzText.CANCEL, "addition"), EzText.FILE_INPUT);
        }

        [TestMethod()]
        public void AddItemNameANDPriceTest()
        {
            _model.AddItemName("drink", "ddd");
            _model.AddItemPrice("drink", "132");
            _model.AddItemName("addition", "aaa");
            _model.AddItemPrice("addition", "10");
            Item item = (Item)_modelObject.GetFieldOrProperty("_drink");
            Assert.AreEqual(item.Name, "ddd");
            Assert.AreEqual(item.Price, 132);
            item = (Item)_modelObject.GetFieldOrProperty("_addition");
            Assert.AreEqual(item.Name, "aaa");
            Assert.AreEqual(item.Price, 10);
        }

        [TestMethod()]
        public void IsInputFileTest()
        {
            Assert.AreEqual(_model.IsInputFile(EzText.FILE_INPUT), true);
            Assert.AreEqual(_model.IsInputFile(" "), false);
        }

        [TestMethod()]
        public void SelectedDrinkIndexTests()
        {
            Assert.AreEqual(_model.SelectedDrinkIndex, 0);
            Assert.AreEqual(_model.SelectedDrinkIndex = 1, 1);
        }
    }
}