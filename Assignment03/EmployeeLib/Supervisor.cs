using System;

namespace EmployeeLib
{
    public class Supervisor : Employee
    {
        private int subordinates;
        public Supervisor()
        {
            designation = "Supervisor";
        }
        public Supervisor(string name, bool gender, Date birth, string address,
            double salary, DepartmentType dept, int subordinates)
            : base(name, gender, birth, address, salary, "Supervisor", dept)
        {
            this.subordinates = subordinates;
        }

        public int Subordinates
        {
            get { return subordinates; }
            set { subordinates = value; }
        }
        public override void Accept()
        {
            base.Accept();

            designation = "Supervisor";

            Console.Write("Enter Number of Subordinates : ");
            subordinates = Convert.ToInt32(Console.ReadLine());
        }

        public override void Print()
        {
            Console.WriteLine(ToString());
        }

        public override string ToString()
        {
            return base.ToString() + $"\nSubordinates : {subordinates}";
        }
    }
}