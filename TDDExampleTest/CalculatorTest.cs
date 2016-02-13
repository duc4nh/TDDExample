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
        public void Test_Max_Number_Gt_1000()
        {
            Calculator.Calculate(1001, 3, "+");
        }

        [TestMethod]
        [ExpectedException(typeof(IndexOutOfRangeException))]
        public void Test_Min_Number_Lt_N1000()
        {
            Calculator.Calculate(-1001, 3, "+");
        }
    }
}
