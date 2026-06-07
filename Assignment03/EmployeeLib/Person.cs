using System;

namespace EmployeeLib
{
    public class Person
    {
        private string name;
        private bool gender;
        private Date birth;
        private string address;

        public Person()
        {
            name = "";
            gender = true;
            birth = new Date();
            address = "";
        }

        public Person(string name, bool gender, Date birth, string address)
        {
            this.name = name;
            this.gender = gender;
            this.birth = birth;
            this.address = address;
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public bool Gender
        {
            get { return gender; }
            set { gender = value; }
        }

        public Date Birth
        {
            get { return birth; }
            set { birth = value; }
        }

        public string Address
        {
            get { return address; }
            set { address = value; }
        }

        public int Age
        {
            get { return Date.CalculateAge(birth); }
        }

        public virtual void Accept()
        {
            Console.Write("Enter Name : ");
            name = Console.ReadLine();

            Console.Write("Enter Gender (true=Male false=Female) : ");
            gender = Convert.ToBoolean(Console.ReadLine());

            Console.WriteLine("Enter Birth Date");
            birth.AcceptDate();

            Console.Write("Enter Address : ");
            address = Console.ReadLine();
        }

        public virtual void Print()
        {
            Console.WriteLine(ToString());
        }

        public override string ToString()
        {
            return $"Name : {name}\nGender : {(gender ? "Male" : "Female")}\nBirth : {birth}\nAddress : {address}\nAge : {Age}";
        }
    }
}