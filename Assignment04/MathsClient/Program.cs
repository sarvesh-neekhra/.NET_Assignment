using System;
using System.Reflection;

namespace MathsClient
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string path = @"D:\E Drive\DotNet\DotNet_Assignments\MathsLib\bin\Debug\net8.0\MathsLib.dll";

            Assembly assembly = Assembly.LoadFrom(path);

 
            Type mathsType = assembly.GetType("MathsLib.Maths");

            object mathsObj = Activator.CreateInstance(mathsType);

            int choice;

            do
            {
                Console.WriteLine("\n===== MENU =====");
                Console.WriteLine("1. Sum");
                Console.WriteLine("2. Subtract");
                Console.WriteLine("3. Multiply");
                Console.WriteLine("4. Divide");
                Console.WriteLine("5. Exit");

                Console.Write("Enter Choice : ");
                choice = Convert.ToInt32(Console.ReadLine());

                if (choice == 5)
                    break;

                Console.Write("Enter First Number : ");
                int a = Convert.ToInt32(Console.ReadLine());

                Console.Write("Enter Second Number : ");
                int b = Convert.ToInt32(Console.ReadLine());

                object result = null;

                switch (choice)
                {
                    case 1:
                        result = mathsType.InvokeMember(
                            "Sum",
                            BindingFlags.InvokeMethod,
                            null,
                            mathsObj,
                            new object[] { a, b });
                        break;

                    case 2:
                        result = mathsType.InvokeMember(
                            "Subtract",
                            BindingFlags.InvokeMethod,
                            null,
                            mathsObj,
                            new object[] { a, b });
                        break;

                    case 3:
                        result = mathsType.InvokeMember(
                            "Multiply",
                            BindingFlags.InvokeMethod,
                            null,
                            mathsObj,
                            new object[] { a, b });
                        break;

                    case 4:
                        result = mathsType.InvokeMember(
                            "Divide",
                            BindingFlags.InvokeMethod,
                            null,
                            mathsObj,
                            new object[] { a, b });
                        break;

                    default:
                        Console.WriteLine("Invalid Choice");
                        continue;
                }

                Console.WriteLine("Result = " + result);

            } while (choice != 5);
        }
    }
}