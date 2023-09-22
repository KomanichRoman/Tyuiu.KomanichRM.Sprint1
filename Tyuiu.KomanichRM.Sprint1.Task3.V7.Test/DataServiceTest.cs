using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.KomanichRM.Sprint1.Task3.V7.Lib;

namespace Tyuiu.KomanichRM.Sprint1.Task3.V7.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double x = 100;
            double res = ds.VerstsToKilometers(x);
            double wait = 106.68;
            Assert.AreEqual(wait, res);

        }
    }
}
