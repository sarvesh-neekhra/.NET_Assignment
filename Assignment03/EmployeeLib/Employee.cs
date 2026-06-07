using System;

namespace EmployeeLib
{
    public enum DepartmentType
    {
        HR,
        Sales,
        IT,
        Admin
    }

    public class Employee : Person
    {
        private static int count = 0;
        private int id;
        private double salary;
        protected string designation;
        private DepartmentType dept;
        public Employee()
        {
            id = ++count;
            salary = 0;
            designation = "";
            dept = DepartmentType.IT;
        }
        public Employee(string name, bool gender, Date birth, string address,
            double salary, string designation, DepartmentType dept)
            : base(name, gender, birth, address)
        {
            id = ++count;
            this.salary = salary;
            this.designation = designation;
            this.dept = dept;
        }
        public int Id
        {
            get { return id; }
        }

        public double Salary
        {
            get { return salary; }
            set { salary = value; }
        }

        public string Designation
        {
            get { return designation; }
        }

        public DepartmentType Dept
        {
            get { return dept; }
            set { dept = value; }
        }

        public override void Accept()
        {
            base.Accept();

            Console.Write("Enter Salary : ");
            salary = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter Department (0-HR 1-Sales 2-IT 3-Admin) : ");
            dept = (DepartmentType)Convert.ToInt32(Console.ReadLine());
        }
        public override void Print()
        {
            Console.WriteLine(ToString());
        }

        public override string ToString()
        {
            return base.ToString() +
                   $"\nId : {id}\nSalary : {salary}\nDesignation : {designation}\nDepartment : {dept}";
        }
    }
}