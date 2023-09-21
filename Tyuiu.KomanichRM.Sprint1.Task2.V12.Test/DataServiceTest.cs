﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.KomanichRM.Sprint1.Task2.V12.Lib;

namespace Tyuiu.KomanichRM.Sprint1.Task2.V12.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            int x = 2;
            int y = 2;
            int z = 2;
            var res = ds.CalculateParallelepipedVolume(x, y, z);
            Assert.AreEqual(8, res);
        }   
    }
}
