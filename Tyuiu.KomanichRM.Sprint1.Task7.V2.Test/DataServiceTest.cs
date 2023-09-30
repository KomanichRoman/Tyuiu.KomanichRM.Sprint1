using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.KomanichRM.Sprint1.Task7.V2.Lib;

namespace Tyuiu.KomanichRM.Sprint1.Task7.V2.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            double x = 1;
            double y = 1;
            var res = ds.Calculate(x, y);
            Assert.AreEqual(res, -0.785);
        }
    }
}
