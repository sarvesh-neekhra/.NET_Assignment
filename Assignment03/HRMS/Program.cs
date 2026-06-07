using System;
using EmployeeLib;

namespace HRMS
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("===== HRMS APPLICATION =====");

            Manager manager = new Manager();
            Console.WriteLine("\nEnter Manager Details");
            manager.Accept();

            Supervisor supervisor = new Supervisor();
            Console.WriteLine("\nEnter Supervisor Details");
            supervisor.Accept();

            WageEmp wage = new WageEmp();
            Console.WriteLine("\nEnter Wage Employee Details");
            wage.Accept();

            Console.WriteLine("\n===== MANAGER DETAILS =====");
            manager.Print();

            Console.WriteLine("\n===== SUPERVISOR DETAILS =====");
            supervisor.Print();

            Console.WriteLine("\n===== WAGE EMPLOYEE DETAILS =====");
            wage.Print();

            Console.ReadLine();
        }
    }
}