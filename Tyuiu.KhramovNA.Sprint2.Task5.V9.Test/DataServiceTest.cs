using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.KhramovNA.Sprint2.Task5.V9.Lib;

namespace Tyuiu.KhramovNA.Sprint2.Task5.V9.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidFindDateOfNextDay()
        {
            DataService ds = new DataService();
            int n; n = 4;
            Assert.AreEqual(1, ds.FindDateOfNextDay(1, 31));
            Assert.AreEqual(5, ds.FindDateOfNextDay(2, n));
            Assert.AreEqual(5, ds.FindDateOfNextDay(3, n));
            Assert.AreEqual(5, ds.FindDateOfNextDay(4, n));
            Assert.AreEqual(5, ds.FindDateOfNextDay(5, n));
            Assert.AreEqual(5, ds.FindDateOfNextDay(6, n));
            Assert.AreEqual(5, ds.FindDateOfNextDay(7, n));
            Assert.AreEqual(5, ds.FindDateOfNextDay(8, n));
            Assert.AreEqual(5, ds.FindDateOfNextDay(9, n));
            Assert.AreEqual(5, ds.FindDateOfNextDay(10, n));
            Assert.AreEqual(5, ds.FindDateOfNextDay(11, n));
            Assert.AreEqual(5, ds.FindDateOfNextDay(12, n));

            Assert.ThrowsException<ArgumentException>(() =>
            {
                ds.FindDateOfNextDay(-1, 5);
            });

            Assert.ThrowsException<ArgumentException>(() =>
            {
                ds.FindDateOfNextDay(13, 5);
            });

        }
    }
}