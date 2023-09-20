using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.KomanichRM.Sprint1.Task1.V24.Lib;


namespace Tyuiu.KomanichRM.Sprint1.Task1.V24.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double x = 2.0;
            double y = 2.0;
            var res = ds.Calculate(x, y);
            Assert.AreEqual(-0.25, res);
        }
    }
}
