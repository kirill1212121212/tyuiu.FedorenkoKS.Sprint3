using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.FedorenkoKS.Sprint3.Task2.V13.Lib;

namespace Tyuiu.FedorenkoKS.Sprint3.Task2.V13.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void validGetSumSeries()
        {
            DataService ds = new DataService();

            double value = 5;
            int startValue = 1;
            int stopValue = 10;

            double res = ds.GetSumSeries(value, startValue, stopValue);

            double wait = -1846.888;
            Assert.AreEqual(wait, res);
        }
    }
}
