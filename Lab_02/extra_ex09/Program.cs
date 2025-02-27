using System;

namespace extra_ex09
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("n = ");
            int n = int.Parse(Console.ReadLine());
            Console.Write($"2^{n} = {Math.Pow(2, n)}");
        }
    }
}
