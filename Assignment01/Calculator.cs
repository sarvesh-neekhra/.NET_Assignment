using System;

namespace Assignment01
{
    internal class Program
    {
        static void Main4(string[] args)
        {
            if (args.Length < 3)
            {
                Console.WriteLine(" number1 operator number2");
                return;
            }

            int num1 = Convert.ToInt32(args[0]);
            string op = args[1];
            int num2 = Convert.ToInt32(args[2]);
            switch (op)
            {
                case "+":
                    Console.WriteLine("Addition = " + (num1 + num2));
                    break;

                case "-":
                    Console.WriteLine("Subtraction = " + (num1 - num2));
                    break;

                case "*":
                    Console.WriteLine("Multiplication = " + (num1 * num2));
                    break;

                case "/":


                        if (num2 != 0)
                            Console.WriteLine("Division = " + (num1 / num2));
                        else
                            Console.WriteLine("Cannot divide by zero");
                        break;
                    

                default:
                    Console.WriteLine("Invalid Operator");
                    break;
            }
        }
    }
}