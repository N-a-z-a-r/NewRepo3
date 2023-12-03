using Microsoft.VisualStudio.TestTools.UnitTesting;
using practice.PR3;
using System;

namespace UnitTestProject1
{
    [TestClass]
    public class Calculation_abcTest
    {
        [TestMethod]
        public void Calculation_Positive_Numbers()
        {
            // Arrange
            var calc = new Calculation_abc(1, 2, 3);
            var expected = 36;

            // Act
            var actual = calc.D();

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Calculation_Negative_Numbers()
        {
            // Arrange
            var calc = new Calculation_abc(-1, -2, -3);
            var expected = 14;

            // Act
            var actual = calc.D();

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Calculation_Mixed_Numbers()
        {
            // Arrange
            var calc = new Calculation_abc(-1, 2, 3);
            var expected = 16;

            // Act
            var actual = calc.D();

            // Assert
            Assert.AreEqual(expected, actual);
        }
    }
}