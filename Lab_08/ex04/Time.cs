using System;

namespace ex04
{
    class Time
    {
        private int hour, min, sec;
        private bool error = false;
        public bool Error
        {
            get { return error; }
        }
        public Time() { }
        public void Input()
        {
            try
            {
                Console.Write("Enter hours: ");
                hour = int.Parse(Console.ReadLine());
                Console.Write("Enter minutes: ");
                min = int.Parse(Console.ReadLine());
                Console.Write("Enter seconds: ");
                sec = int.Parse(Console.ReadLine());

                if (hour < 0 || hour > 23 || min < 0 || min > 59 || sec < 0 || sec > 59)
                {
                    error = true; // for out of range
                    throw new ArgumentOutOfRangeException();
                }
            }
            catch
            {
                error = true; // for string instead of int
                Console.WriteLine("Error. Hours must be 0–23 and minutes/seconds must be 0–59");
            }
        }
        public void Output()
        {
            if (!error)
            {
                string formattedTime = $"{hour:D2}:{min:D2}:{sec:D2}";
                Console.WriteLine(formattedTime);
            }
            else
            {
                Console.WriteLine("Invalid time");
            }
        }
    }
}
