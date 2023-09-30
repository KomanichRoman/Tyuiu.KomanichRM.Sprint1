using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.KomanichRM.Sprint1.Task6.V1.Lib;

namespace Tyuiu.KomanichRM.Sprint1.Task6.V1.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            string a = "1";
            string res = ds.SymbolCode(a);
            Assert.AreEqual(res, "49");
            
        }
    }
}
