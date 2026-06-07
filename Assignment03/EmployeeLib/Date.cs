using System;

namespace EmployeeLib
{
    public class Date
    {
        private int day;
        private int month;
        private int year;
        public Date()
        {
            day = 1;
            month = 1;
            year = 2000;
        }
        public Date(int day, int month, int year)
        {
            this.day = day;
            this.month = month;
            this.year = year;
        }
        public int Day
        {
            get { return day; }
            set { day = value; }
        }

        public int Month
        {
            get { return month; }
            set { month = value; }
        }

        public int Year
        {
            get { return year; }
            set { year = value; }
        }

        public void AcceptDate()
        {
            Console.Write("Enter Day : ");
            day = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Month : ");
            month = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Year : ");
            year = Convert.ToInt32(Console.ReadLine());
        }

        public void PrintDate()
        {
            Console.WriteLine($"{day}/{month}/{year}");
        }

        public bool IsValid()
        {
            return DateTime.TryParse($"{day}/{month}/{year}", out _);
        }

        public static int CalculateAge(Date birth)
        {
            DateTime dob = new DateTime(birth.Year, birth.Month, birth.Day);
            int age = DateTime.Now.Year - dob.Year;

            if (DateTime.Now.DayOfYear < dob.DayOfYear)
                age--;

            return age;
        }

        public override string ToString()
        {
            return $"{day}/{month}/{year}";
        }
    }
}