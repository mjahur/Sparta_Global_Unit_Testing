using System;
using Xunit;
using CalculatorApp;
namespace XUnit_Test
{
    public class UnitTest1
    {
        [Fact]
        public void TestAdd()
        {//Arrange
            Calculator calc = new Calculator();
            double expected = 6.0;
            //Act
            double actual = calc.Add(2.0, 4.0);
            //Assert
            Assert.Equal(expected, actual);
        }
        [Fact]
        public void TestSubtract()
        {//Arrange
            Calculator calc = new Calculator();
            double expected = 2.0;
            //Act
            double actual = calc.Subtract(4.0, 2.0);
            //Assert
            Assert.Equal(expected, actual);
        }
        [Fact]
        public void TestMultiply()
        {//Arrange
            Calculator calc = new Calculator();
            double expected = 8.0;
            //Act
            double actual = calc.Multiply(4.0, 2.0);
            //Assert
            Assert.Equal(expected, actual);
        }
        [Fact]
        public void TestDivide()
        {//Arrange
            Calculator calc = new Calculator();
            double expected = 2.0;
            //Act
            double actual = calc.Divide(4.0, 2.0);
            //Assert
            Assert.Equal(expected, actual);
        }
        [Fact]
        public void TestModulo()
        {//Arrange
            Calculator calc = new Calculator();
            double expected = 0.0;
            //Act
            double actual = calc.Modulo(4.0, 2.0);
            //Assert
            Assert.Equal(expected, actual);
        }
        [Fact]
        public void TestRectangleArea()
        {//Arrange
            Calculator calc = new Calculator();
            double expected = 8.0;
            //Act
            double actual = calc.RectangleArea(4.0, 2.0);
            //Assert
            Assert.Equal(expected, actual);
        }
        [Fact]
        public void TestTriangleArea()
        {//Arrange
            Calculator calc = new Calculator();
            double expected = 4.0;
            //Act
            double actual = calc.TriangleArea(4.0, 2.0);
            //Assert
            Assert.Equal(expected, actual);
        }
        [Fact]
        public void TestCircleArea()
        {//Arrange
            Calculator calc = new Calculator();
            double expected = Math.PI * 4.0 * 4.0;
            //Act
            double actual = calc.CircleArea(4.0);
            //Assert
            Assert.Equal(expected, actual);
        }


    }
}
