using Microsoft.VisualStudio.TestTools.UnitTesting;
using practice.PR3;
using System;

namespace UnitTest
{
    [TestClass]
    public class Calculation_abTests
    {
        [TestMethod]
        public void Sum_EqualInputs_ReturnsZero()
        {
            // Arrange
            var calc = new Calculation_ab(10, 10);
            var expected = 0;

            // Act
            var actual = calc.Sun();

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void Sum_FirstMoreThanSecond_ThrowsException()
        {
            // Arrange
            var calc = new Calculation_ab(15, 10);

            // Act
            var actual = calc.Sun();

            // Assert
            // Not needed since we expect exception
        }
    }
}
