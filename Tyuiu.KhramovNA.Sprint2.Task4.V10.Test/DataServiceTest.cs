using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.KhramovNA.Sprint2.Task4.V10.Lib;

namespace Tyuiu.KhramovNA.Sprint2.Task4.V10.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCondition1()
        {
            DataService ds = new DataService();
            double x = 1;
            double y = 12;
            double res = ds.Calculate(x, y);
            double wait = 1.021;
            Assert.AreEqual(wait, res);
        }

        [TestMethod]
        public void ValidCondition2()
        {
            DataService ds = new DataService();
            double x = 5;
            double y = 12;
            double res = ds.Calculate(x, y);
            double wait = 61;
            Assert.AreEqual(wait, res);
        }
    }
}