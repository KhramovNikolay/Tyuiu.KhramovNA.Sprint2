using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.KhramovNA.Sprint2.Task2.V19.Lib;

namespace Tyuiu.KhramovNA.Sprint2.Task2.V19.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCheckedDotInShadeArea()
        {
            DataService ds = new DataService();
            int x = 13;
            int y = 6;
            bool res = ds.CheckDotInShadedArea(x, y);
            bool wait = true;
            Assert.AreEqual(res, wait);
        }
    }
}