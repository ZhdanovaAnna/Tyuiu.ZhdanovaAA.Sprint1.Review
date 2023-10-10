using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.ZhdanovaAA.Sprint1.TaskReview.V20.Lib;

namespace Tyuiu.ZhdanovaAA.Sprint1.TaskReview.V20.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();
            double x = 0.5, y = 0.5;
            Assert.AreEqual(1.449, ds.Calculate(x, y));
        }
    }
} 
