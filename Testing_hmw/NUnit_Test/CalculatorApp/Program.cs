using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorApp
{
    public class Program
    {
        static void Main(string[] args)
        {
        }
    }

    public class Calculator
    {
       public double Add(double num1, double num2)
        {
            return num1 + num2;
        }

        public double Subtract(double num1, double num2)
        {
            return num1 - num2;
        }

        public double Multiply(double num1, double num2)
        {
            return num1 * num2;
        }

        public double Divide(double num1, double num2)
        {
            return num1 / num2;
        }
        public double Modulo(double num1, double num2)
        {
            return num1 % num2;
        }
        public double RectangleArea(double length, double width)
        {
            return length * width;
        }
        public double TriangleArea(double length, double width)
        {
            return 0.5 * length * width;
        }
        public double CircleArea(double r)
        {
            return  Math.PI * r * r;
        }
    }
}
