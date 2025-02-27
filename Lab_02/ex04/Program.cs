using System;

namespace ex04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("n = ");
            uint n = uint.Parse(Console.ReadLine());
            for (uint _ = 1; _ <= n; _++)
            {
                Console.Write(_ + " ");
            }
            Console.WriteLine();
            for (uint _ = n; _ >= 1; _--)
            {
                Console.Write(_ + " ");
            }
        }
    }
}
