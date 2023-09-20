using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.KomanichRM.Sprint1.Task0.V0.Lib;

namespace Tyuiu.KomanichRM.Sprint1.Task0.V0.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            var res = ds.Culculate();
            Assert.AreEqual(2, res);
        }
    }
}
