using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TDDExample;

namespace TDDExampleTest
{
    [TestClass]
    public class CalculatorTest
    {
        int validInput;

        [TestInitialize]
        public void MyTestInitialize()
        {
            validInput = 500;
        }

        [TestMethod]
        [ExpectedException(typeof(IndexOutOfRangeException))]
        public void Test_InputInRange()
        {
            // Arrange
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

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void Test_MethodInRange()
        {
            // Arrange
            String[] invalidMethods = {"g", ".", "3", "="};

            // Act
            foreach (String method in invalidMethods)
            {
                Calculator.Calculate(validInput, validInput, method);
            }

            // Assert
            // "Nothing to do here"
        }
    }
}
