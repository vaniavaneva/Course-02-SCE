using System;

namespace ex06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number: (0 for exit)");
            uint _ = uint.Parse(Console.ReadLine()), sum = 0;
            while(_ != 0)
            {
                sum += _;
                _ = uint.Parse(Console.ReadLine());
            }
            Console.WriteLine("Sum = " + sum);
        }
    }
}
