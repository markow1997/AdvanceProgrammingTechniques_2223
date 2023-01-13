using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathSample
{
    public class Calculator
    {
        public double Add(double number1, double number2)
        {
            return number1 + number2;
        }

        public double Subtract(double number1, double number2)
        {
            return number1 - number2;
        }

        public double Multiply(double number1, double number2)
        {
            return number1 * number2;
        }

        public double Divide(double number1, double number2)
        {
            if(number2 == 0)
            {
                throw new System.ArithmeticException("Do not divide by zero!");
            }
            return number1 / number2;
        }

        public double Power(double number1, double number2)
        {
            return Math.Pow(number1, number2);
        }

        public double Root(double number1, double number2)
        {
            if(number1 < 0)
            {
                throw new System.ArithmeticException("Radicant cannot be negative.");
            }
            return Math.Pow(number1, 1.0 / number2);
        }

        static void Main(string[] args)
        {
            Calculator calc = new Calculator();
            int x, y;
            x = -8;
            y = 3;

            double result = calc.Add(x, y);
            Console.WriteLine(result);
            result = calc.Subtract(x, y);
            Console.WriteLine(result);
            result = calc.Multiply(x, y);
            Console.WriteLine(result);
            result = calc.Divide(x, y);
            Console.WriteLine(result);
            result = calc.Power(x, y);
            Console.WriteLine(result);
            result = calc.Root(x, y);
            Console.WriteLine(result);
        }
    }
}
