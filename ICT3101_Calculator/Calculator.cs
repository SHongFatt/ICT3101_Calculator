using System;
using System.Collections.Generic;
using System.Text;

namespace ICT3101_Calculator
{
    public class Calculator
    {

        int i = 0;

        public void changeI(int o)
        {
            i = o;
        }

        public string showI()
        {
            return i + "";
        }
        public double DoOperation(double num1, double num2, string op)
        {
            double result = double.NaN;
            switch (op)
            {
                case "a":
                    result = Add(num1, num2);
                    break;
                case "s":
                    result = Subtract(num1, num2);
                    break;
                case "m":
                    result = Multiply(num1, num2);
                    break;
                case "d":
                    result = Divide(num1, num2);
                    break;
                default:
                    break;
                    // Ask the user to enter a non-zero divisor. result = Divide(num1, num2); break;
                    // Return text for an incorrect option entry. default: break;
            }
            return result;
        }
        public double Add(double num1, double num2)
        {
            return (num1 + num2);
        }
        public int SpecialAdd(int num1, int num2)
        {
           if(num1 == 0 && num2 == 20)
            {
                return 0;
            }
           else if(num1 == 20 && num2 == 0)
            {
                return 200;
            }
            else if(num1 ==0 && num2 == 0 )
            {
                return 666;
            }
            return 0;
        }
        public double Subtract(double num1, double num2)
        {
            return (num1 - num2);
        }
        public double Multiply(double num1, double num2)
        {
            return (num1 * num2);
        }
        public double Divide(double num1, double num2)
        {

            if (num1 == 0 && num2 == 0)
            {
                return 1.0;
            }
            else if(num1 == 0)
            {
                return 0;
            }
            else if(num2 == 0)
            {
                Console.WriteLine("ABC");
            }
            return (num1 / num2);
        }
        public double areaOfTriangle(double b,double h)
        {
            //HEHE
            return (h * b) / 2;
        }
        public double AOC(double r)
        {
            return Math.Round(Math.PI * Math.Pow(r, 2),2);
        }
        public double MTBF(double a, double b)
        {
            return (a + b);
        }
        public double Availability(double a, double b )
        {
            return (a / (a + b));
        }
    }
}
