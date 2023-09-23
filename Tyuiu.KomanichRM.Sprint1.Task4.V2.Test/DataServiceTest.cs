using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.KomanichRM.Sprint1.Task4.V2.Lib;

namespace Tyuiu.KomanichRM.Sprint1.Task4.V2.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double y = 16;
            double x = 32;
            var res = ds.Calculate(x, y);
            Assert.AreEqual(res, 0.125);
        }
    }
}
