using System;

namespace Assignment02
{
    struct Student
    {
        private string name;
        private bool gender;
        private int age;
        private int std;
        private char div;
        private double marks;

     
        public Student(string name, bool gender, int age, int std, char div, double marks)
        {
            this.name = name;
            this.gender = gender;
            this.age = age;
            this.std = std;
            this.div = div;
            this.marks = marks;
        }

      
        public string GetName()
        {
            return name;
        }

        public void SetName(string name)
        {
            this.name = name;
        }

        public bool GetGender()
        {
            return gender;
        }

        public void SetGender(bool gender)
        {
            this.gender = gender;
        }

        public int GetAge()
        {
            return age;
        }

        public void SetAge(int age)
        {
            this.age = age;
        }

        public int GetStd()
        {
            return std;
        }

        public void SetStd(int std)
        {
            this.std = std;
        }

        public char GetDiv()
        {
            return div;
        }

        public void SetDiv(char div)
        {
            this.div = div;
        }

        public double GetMarks()
        {
            return marks;
        }

        public void SetMarks(double marks)
        {
            this.marks = marks;
        }

        public void AcceptDetails()
        {
            Console.Write("Enter Name: ");
            name = Console.ReadLine();

            Console.Write("Enter Gender (true for Male / false for Female): ");
            gender = Convert.ToBoolean(Console.ReadLine());

            Console.Write("Enter Age: ");
            age = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Standard: ");
            std = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Division: ");
            div = Convert.ToChar(Console.ReadLine());

            Console.Write("Enter Marks: ");
            marks = Convert.ToDouble(Console.ReadLine());
        }

        public void PrintDetails()
        {
            Console.WriteLine("\nStudent Details");
            Console.WriteLine("Name = " + name);
            Console.WriteLine("Gender = " + gender);
            Console.WriteLine("Age = " + age);
            Console.WriteLine("Standard = " + std);
            Console.WriteLine("Division = " + div);
            Console.WriteLine("Marks = " + marks);
        }
    }
    internal class Program
    {
        static void Main1(string[] args)
        {
            
            Student s1 = new Student();

            s1.AcceptDetails();

            s1.PrintDetails();

            Console.ReadLine();
        }
    }
}