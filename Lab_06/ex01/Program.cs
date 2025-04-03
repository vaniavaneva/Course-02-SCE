using System;

namespace ex01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Default constructor:");
            Time t1 = new Time();
            t1.Input();
            t1.Output();

            Console.WriteLine();

            Console.WriteLine("Initialized constructor:");
            Time t2 = new Time(32, 53, 2);
            t2.Output();
        }
    }
}
