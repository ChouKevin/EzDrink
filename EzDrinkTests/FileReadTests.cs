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
    public class FileReadTests
    {
        FileRead _file;
        PrivateObject _fileObject;
        [TestInitialize()]
        public void Initialize()
        {
            _file = new FileRead();
            _fileObject = new PrivateObject(_file);
        }
        [TestMethod()]
        public void FileReadTest()
        {
            Assert.AreEqual(_fileObject.GetFieldOrProperty("_fileString"), "");
        }

        [TestMethod()]
        public void ReadTest()
        {
            Assert.AreNotEqual(_file.Read("DrinkList"), FileRead.ERROR);
            Assert.AreEqual(_file.Read("DrinkList", "sas"), FileRead.ERROR);
            Assert.AreEqual(_file.Read("DrinkList", "asd", "asd"), FileRead.ERROR);
            Assert.AreEqual(_file.Read("asda"), FileRead.ERROR);
            Assert.AreEqual(_file.Read("asda",".das"), FileRead.ERROR);
            Assert.AreEqual(_file.Read("asda", ".das", "das"), FileRead.ERROR);
        }
    }
}