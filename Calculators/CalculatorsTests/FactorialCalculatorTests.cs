using Microsoft.VisualStudio.TestTools.UnitTesting;
using Calculators;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculators.Tests
{
    [TestClass()]
    public class FactorialCalculatorTests
    {
        [TestMethod()]
        public void CalculateFactorialTest()
        {
            FactorialCalculator Fred = new FactorialCalculator();
            Assert.AreEqual(0, Fred.CalculateFactorial(0));
            Assert.AreEqual(1, Fred.CalculateFactorial(1));
            Assert.AreEqual(-1, Fred.CalculateFactorial(-10));
            Assert.AreEqual(2, Fred.CalculateFactorial(2));
            Assert.AreEqual(6, Fred.CalculateFactorial(3));
            Assert.AreEqual(120, Fred.CalculateFactorial(5));
            Assert.AreEqual(3628800, Fred.CalculateFactorial(10));
            Assert.AreEqual(39916800, Fred.CalculateFactorial(11));
            Assert.AreEqual(479001600, Fred.CalculateFactorial(12));
            Assert.AreEqual(6227020800, Fred.CalculateFactorial(13));
            Assert.AreEqual(87178291200, Fred.CalculateFactorial(14));
            Assert.AreEqual(-7, Fred.CalculateFactorial(15));
            Assert.AreEqual(-3, Fred.CalculateFactorial(16));
            Assert.AreEqual(-3, Fred.CalculateFactorial(256));

        }
    }
}