using System;
using CollegeStudent = College.StudentInfo.Student;
using SchoolStudent = School.StudentInfo.Student;

namespace College.StudentInfo
{
    class Student
    {
        public void ShowDetails()
        {
            Console.WriteLine("This is College.StudentInfo.Student class");
        }
    }
}

namespace School.StudentInfo
{
    class Student
    {
        public void ShowDetails()
        {
            Console.WriteLine("This is School.StudentInfo.Student class");
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        CollegeStudent c1 = new CollegeStudent();
        c1.ShowDetails();

        SchoolStudent s1 = new SchoolStudent();
        s1.ShowDetails();

        Console.ReadLine();
    }
}