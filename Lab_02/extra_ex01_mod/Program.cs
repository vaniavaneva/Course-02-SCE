using System;

namespace extra_ex01_mod
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter number of years: ");
            int _ = int.Parse(Console.ReadLine()), index = 0;
            int[] years = new int[_];
            int[] leap = new int[_];

            Console.Write("Enter years: ");

            for (int i = 0; i < _; i++)
            {
                years[i] = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < _; i++)
            {
                if ((years[i] % 4 == 0 && years[i] % 100 != 0) || (years[i] % 400 == 0))
                {
                    leap[index] = years[i];
                    index++;
                }
            }

            Console.Write("\nLeap years: ");
            for (int i = 0; i < index; i++)
            {
                Console.Write(leap[i] + " ");
            }
        }
    }
}
