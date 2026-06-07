using System;

namespace EmployeeLib
{
    public class Manager : Employee
    {
        private double bonus;
        public Manager()
        {
            designation = "Manager";
        }

        public Manager(string name, bool gender, Date birth, string address,
            double salary, DepartmentType dept, double bonus)
            : base(name, gender, birth, address, salary, "Manager", dept)
        {
            this.bonus = bonus;
        }

        public double Bonus
        {
            get { return bonus; }
            set { bonus = value; }
        }
        public override void Accept()
        {
            base.Accept();

            designation = "Manager";

            Console.Write("Enter Bonus : ");
            bonus = Convert.ToDouble(Console.ReadLine());
        }

        public override void Print()
        {
            Console.WriteLine(ToString());
        }

        public override string ToString()
        {
            return base.ToString() + $"\nBonus : {bonus}";
        }
    }
}