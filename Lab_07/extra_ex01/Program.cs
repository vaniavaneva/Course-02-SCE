using System;

namespace extra_ex01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Birthday b1 = new Birthday();
            Console.WriteLine("Default constructor");
            b1.Input();
            b1.Output();
            Console.WriteLine("Initialised constructor");
            Birthday b2 = new Birthday("25", "10", "2005");
            b2.Output();
        }
    }
}
