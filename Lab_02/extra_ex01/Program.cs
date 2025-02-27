using System;

namespace extra_ex01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter year: ");
            int year = int.Parse(Console.ReadLine());

            if((year % 4 == 0 && year % 100 != 0) || (year % 400 == 0))
            {
                Console.Write("Leap year");
            }
            else
            {
                Console.Write("Regular year");
            }
        }
    }
}
