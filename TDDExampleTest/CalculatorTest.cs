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

        [TestMethod]
        public void Test_PhepCong()
        {
            // Arrange
            int input1 = 1;
            int input2 = 2;
            int expectedResult = 3;
            String method = "+";

            // Act
            double actualResult = Calculator.Calculate(input1, input2, method);

            // Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void Test_PhepNhan()
        {
            // Arrange
            int input1 = 1;
            int input2 = 2;
            int expectedResult = 2;
            String method = "*";

            // Act
            double actualResult = Calculator.Calculate(input1, input2, method);

            // Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void Test_PhepChia_KhongDuocChiaCho0()
        {
            // Arrange
            int input1 = 1;
            int input2 = 0;
            String method = "/";

            // Act
            Calculator.Calculate(input1, input2, method);

            // Assert
            // "Nothing to do here"
        }

        [TestMethod]
        public void Test_PhepChia()
        {
            // Arrange
            int input1 = 1;
            int input2 = 2;
            double expectedResult = 0.5;
            String method = "/";

            // Act
            double actualResult = Calculator.Calculate(input1, input2, method);

            // Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void Test_PhepTru()
        {
            // Arrange
            int input1 = 1;
            int input2 = 2;
            int expectedResult = -1;
            String method = "-";

            // Act
            double actualResult = Calculator.Calculate(input1, input2, method);

            // Assert
            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}
