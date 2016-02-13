using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TDDExample;

namespace TDDExampleTest
{
    [TestClass]
    public class CalculatorTest
    {
        [TestMethod]
        [ExpectedException(typeof(IndexOutOfRangeException))]
        public void Test_SoDauLonHon1000()
        {
            Calculator.Calculate(1001, 3, "+");
        }

        [TestMethod]
        [ExpectedException(typeof(IndexOutOfRangeException))]
        public void Test_SoSauLonHon1000()
        {
            Calculator.Calculate(101, 1001, "+");
        }

        [TestMethod]
        [ExpectedException(typeof(IndexOutOfRangeException))]
        public void Test_SoDauNhoHonAm1000()
        {
            Calculator.Calculate(-1001, 3, "+");
        }

        [TestMethod]
        [ExpectedException(typeof(IndexOutOfRangeException))]
        public void Test_SoSauNhoHonAm1000()
        {
            Calculator.Calculate(1, -1003, "+");
        }
    }
}
