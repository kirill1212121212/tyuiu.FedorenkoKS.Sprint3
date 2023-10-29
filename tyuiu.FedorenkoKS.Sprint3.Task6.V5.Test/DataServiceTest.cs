using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.FedorenkoKS.Sprint3.Task6.V5.Lib;

namespace Tyuiu.FedorenkoKS.Sprint3.Task6.V5.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetSumTheDivisors()
        {
            DataService ds = new DataService();

            int startValue = 15;
            int stopValue = 22;

            double res = ds.GetSumTheDivisors(startValue, stopValue);
            double wait = 242;

            Assert.AreEqual(wait, res);
        }
    }
}