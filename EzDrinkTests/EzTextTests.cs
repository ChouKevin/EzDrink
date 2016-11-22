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
    public class EzTextTests
    {
        EzText _text = new EzText();
        [TestMethod()]
        public void ChangeTextTest()
        {
            Assert.AreEqual(_text.ChangeText(true, EzText.FILE_INPUT), EzText.CANCEL);
            Assert.AreEqual(_text.ChangeText(true, EzText.INPUT_ITEM), EzText.OK);
            Assert.AreEqual(_text.ChangeText(true, "sads"), "sads");
            Assert.AreEqual(_text.ChangeText(false, EzText.CANCEL), EzText.FILE_INPUT);
            Assert.AreEqual(_text.ChangeText(false, EzText.OK), EzText.INPUT_ITEM);
            Assert.AreEqual(_text.ChangeText(false, "sads"), "sads");
        }

        [TestMethod()]
        public void IsAddTest()
        {
            Assert.AreEqual(_text.IsAdd("adasd"), false);
            Assert.AreEqual(_text.IsAdd(EzText.INPUT_ITEM), true);
        }

        [TestMethod()]
        public void IsCancelTest()
        {
            Assert.AreEqual(_text.IsAdd("adasd"), false);
            Assert.AreEqual(_text.IsCancel(EzText.CANCEL), true);
        }

        [TestMethod()]
        public void IsOkTest()
        {
            Assert.AreEqual(_text.IsOk("adasd"), false);
            Assert.AreEqual(_text.IsOk(EzText.OK), true);
        }

        [TestMethod()]
        public void IsFileInputTest()
        {
            Assert.AreEqual(_text.IsFileInput("adasd"), false);
            Assert.AreEqual(_text.IsFileInput(EzText.FILE_INPUT), true);
        }

        [TestMethod()]
        public void IsDrinkTest()
        {
            Assert.AreEqual(_text.IsDrink("adasd"), false);
            Assert.AreEqual(_text.IsDrink(EzText.DRINK + "sda"), true);
            Assert.AreEqual(_text.IsDrink(EzText.DRINK), true);
        }

        [TestMethod()]
        public void IsAdditionTest()
        {
            Assert.AreEqual(_text.IsAddition("asdasd"), false);
            Assert.AreEqual(_text.IsAddition(EzText.ADDITION + "sda"), true);
            Assert.AreEqual(_text.IsAddition(EzText.ADDITION), true);
        }
        [TestMethod()]
        public void SplitFileStringTest()
        {
            Assert.AreEqual(_text.SplitFileString("sda asd asd").Length, 3);
            Assert.AreEqual(_text.SplitFileString("sdaasdasd").Length, 1);
            Assert.AreEqual(_text.SplitFileString("sdaas\ndasd").Length, 2);
            Assert.AreEqual(_text.SplitFileString("sda as\n dasd").Length, 4);
        }
    }
}