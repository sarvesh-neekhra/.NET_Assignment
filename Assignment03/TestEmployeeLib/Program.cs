using System;
using EmployeeLib;

namespace TestEmployeeLib
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Manager m = new Manager();
            m.Accept();

            Console.WriteLine("\n===== Manager Details =====");
            m.Print();

            Console.WriteLine();

            Supervisor s = new Supervisor();
            s.Accept();

            Console.WriteLine("\n===== Supervisor Details =====");
            s.Print();

            Console.WriteLine();

            WageEmp w = new WageEmp();
            w.Accept();

            Console.WriteLine("\n===== Wage Employee Details =====");
            w.Print();
        }
    }
}