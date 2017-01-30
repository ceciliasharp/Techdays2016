using Microsoft.VisualStudio.TestTools.UnitTesting;
using Calculator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.Tests
{
    [TestClass]
    public class CalculatorTests
    {
        [TestMethod]
        public void AddTest()
        {
            var c = new Calculator();
            c.Add(7);
            Assert.AreEqual(7, c.Sum);
        }

        [TestMethod]
        public void SubTest()
        {
            var c = new Calculator();
            c.Substract(4);
            Assert.AreEqual(-4, c.Sum);
        }
    }
}