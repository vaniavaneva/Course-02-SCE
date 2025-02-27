using System;

namespace ex05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("n = ");
            int n = int.Parse(Console.ReadLine()), factoriel = 1;
            for(int _ = 1; _ <= n; _++)
            {
                factoriel *= _;
            }
            Console.WriteLine("n! = " + factoriel);
        }
    }
}
