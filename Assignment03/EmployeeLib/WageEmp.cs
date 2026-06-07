using System;

namespace EmployeeLib
{
    public class WageEmp : Employee
    {
        private int hours;
        private int rate;

        public WageEmp()
        {
            designation = "Wage";
        }
        public WageEmp(string name, bool gender, Date birth, string address,
            double salary, DepartmentType dept, int hours, int rate)
            : base(name, gender, birth, address, salary, "Wage", dept)
        {
            this.hours = hours;
            this.rate = rate;
        }

        public int Hours
        {
            get { return hours; }
            set { hours = value; }
        }

        public int Rate
        {
            get { return rate; }
            set { rate = value; }
        }

        public override void Accept()
        {
            base.Accept();

            designation = "Wage";

            Console.Write("Enter Hours : ");
            hours = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Rate : ");
            rate = Convert.ToInt32(Console.ReadLine());
        }

        public override void Print()
        {
            Console.WriteLine(ToString());
        }

        public override string ToString()
        {
            return base.ToString() +
                   $"\nHours : {hours}\nRate : {rate}";
        }
    }
}