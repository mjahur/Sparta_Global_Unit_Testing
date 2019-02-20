using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorApp
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
    public class Calculator
    {
        public double Add(double num1, double num2)
        {
            double result = num1 + num2;
            return result;
        }
        public double Divide(double num1, double num2)
        {
            double result = num1 / num2;
            return result;
        }
        public double Subtract(double num1, double num2)
        {
            double result = num1 - num2;
            return result;
        }
        public double Multiply(double num1, double num2)
        {
            double result = num1 * num2;
            return result;
        }
        public double Modulo(double num1, double num2)
        {
            double result = num1 % num2;
            return result;
        }
        public double RectangleArea(double length, double height)
        {
            double result = length * height;
            return result;
        }
        public double TriangleArea(double length, double height)
        {
            double result = length * height * 0.5;
            return result;
        }
        public double CircleArea(double radius)
        {
            double result = Math.PI * radius * radius;
            return result;
        }
    }
}
