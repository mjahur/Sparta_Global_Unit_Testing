using System;
using NUnit.Framework;
using NUnit_Test;
using CalculatorApp;

namespace NUnit_Test
{
    [TestFixture]
    public class UnitTest1
    {
        [Test]
        public void TestAdd()
        {//Arrange
            Calculator calc = new Calculator();
            double expected = 6.0;
            //Act
            double actual = calc.Add(2.0, 4.0);
            //Assert
            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void TestSubtract()
        {//Arrange
            Calculator calc = new Calculator();
            double expected = 2.0;
            //Act
            double actual = calc.Subtract(4.0, 2.0);
            //Assert
            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void TestMultiply()
        {//Arrange
            Calculator calc = new Calculator();
            double expected = 8.0;
            //Act
            double actual = calc.Multiply(4.0, 2.0);
            //Assert
            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void TestDivide()
        {//Arrange
            Calculator calc = new Calculator();
            double expected = 2.0;
            //Act
            double actual = calc.Divide(4.0, 2.0);
            //Assert
            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void TestModulo()
        {//Arrange
            Calculator calc = new Calculator();
            double expected = 0.0;
            //Act
            double actual = calc.Modulo(4.0, 2.0);
            //Assert
            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void TestRectangleArea()
        {//Arrange
            Calculator calc = new Calculator();
            double expected = 8.0;
            //Act
            double actual = calc.RectangleArea(4.0, 2.0);
            //Assert
            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void TestTriangleArea()
        {//Arrange
            Calculator calc = new Calculator();
            double expected = 4.0;
            //Act
            double actual = calc.TriangleArea(4.0, 2.0);
            //Assert
            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void TestCircleArea()
        {//Arrange
            Calculator calc = new Calculator();
            double expected = Math.PI * 4.0 * 4.0;
            //Act
            double actual = calc.CircleArea(4.0);
            //Assert
            Assert.AreEqual(expected, actual);
        }


    }
}
