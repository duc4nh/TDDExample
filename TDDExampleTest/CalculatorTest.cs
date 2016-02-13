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
        public void Test_InputInRange()
        {
            // Arrange
            int validInput = 500;
            int tooLargeInput = 1001;
            int tooSmallInput = -1001;

            // Act
            Calculator.Calculate(tooLargeInput, validInput, "+");
            Calculator.Calculate(validInput, tooLargeInput, "+");
            Calculator.Calculate(validInput, tooSmallInput, "+");
            Calculator.Calculate(tooSmallInput, validInput, "+");

            // Assert
            // "Nothing to do here"
        }
    }
}
