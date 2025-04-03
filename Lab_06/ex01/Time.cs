using System;

namespace ex01
{
    class Time
    {
        private int hour, minute, second;
        private string hours, minutes, seconds;
        public Time()
        {
            hour = minute = second = 0;
        }
        public Time(int hour, int minute, int second)
        {
            this.hour = hour;
            this.minute = minute;
            this.second = second;
        }

        public void Input()
        {
            Console.Write("Enter hours: ");
            hour = int.Parse(Console.ReadLine());
            Console.Write("Enter minutes: ");
            minute = int.Parse(Console.ReadLine());
            Console.Write("Enter seconds: ");
            second = int.Parse(Console.ReadLine());
        }

        public void Output()
        {
            if (hour < 9)
            {
                hours = "0" + hour;
            }
            else
            {
                hours = "" + hour;
            }

            if (minute < 9)
            {
                minutes = "0" + minute;
            }
            else
            {
                minutes = "" + minute;
            }

            if (second < 9)
            {
                seconds = "0" + second;
            }
            else
            {
                seconds = "" + second;
            }
            Console.WriteLine($"{hours}:{minutes}:{seconds}");
        }
    }
}
