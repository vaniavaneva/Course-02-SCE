using System;

namespace extra_ex01
{
    class Birthday
    {
        private string day, month, year;
        public Birthday()
        {
            day = month = year = "";
        }
        public Birthday(string day, string month, string year)
        {
            this.day = day;
            this.month = month;
            this.year = year;
        }
        public string Day
        {
            get { return day; }
            set { day = value; }
        }
        public string Month
        {
            get { return month; }
            set { month = value; }
        }
        public string Year
        {
            get { return year; }
            set { year = value; }
        }
        public void Input()
        {
            Console.Write("Enter day: ");
            day = Console.ReadLine();
            Console.Write("Enter month: ");
            month = Console.ReadLine();
            Console.Write("Enter year: ");
            year = Console.ReadLine();
        }
        public void Output()
        {
            Console.WriteLine($"My birthday is: {day}:{month}:{year}г.");
        }
    }
}
