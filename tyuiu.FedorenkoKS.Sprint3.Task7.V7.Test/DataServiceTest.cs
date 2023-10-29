using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.FedorenkoKS.Sprint3.Task7.V7.Lib;

namespace Tyuiu.FedorenkoKS.Sprint3.Task7.V7.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckGetMassFunction()
        {
            int a = -5;
            int b = 5;

            double[] res = new double[b - a + 1];

            res[0] = 15.19;
            res[1] = 11.67;
            res[2] = 9.00;
            res[3] = 0.00;
            res[4] = 4.08;
            res[5] = 1.50;
            res[6] = -2.28;
            res[7] = -6.52;
            res[8] = -10.19;
            res[9] = -12.76;
            res[10] = -14.68;

            DataService ds = new DataService();
            CollectionAssert.AreEqual(res, ds.GetMassFunction(a, b));
        }
    }
}