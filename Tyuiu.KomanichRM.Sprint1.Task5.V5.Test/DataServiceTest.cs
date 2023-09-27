using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.KomanichRM.Sprint1.Task5.V5.Lib;

namespace Tyuiu.KomanichRM.Sprint1.Task5.V5.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double x = 2.9456;
            var res = ds.Calculate(x);
            Assert.AreEqual(res, 9);
        }
    }
}
