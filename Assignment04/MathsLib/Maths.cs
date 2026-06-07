using System;

namespace MathsLib
{
    public class Maths
    {
        public int Sum(int a, int b)
        {
            return a + b;
        }

        public int Subtract(int a, int b)
        {
            return a - b;
        }

        public int Multiply(int a, int b)
        {
            return a * b;
        }

        public double Divide(int a, int b)
        {
            if (b == 0)
            {
                Console.WriteLine("Division by zero not possible");
                return 0;
            }

            return (double)a / b;
        }
    }
}