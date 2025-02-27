using System;

namespace ex08_mod
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("n (cols) = ");
            uint n = uint.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                for (int y = 0; y < n - i - 1; y++)
                {
                    Console.Write(" ");
                }

                for (int x = i; x >= 0; x--)
                {
                    Console.Write("*");
                }

                for (int z = 1; z <= i; z++)
                {
                    Console.Write("*");
                }

                Console.Write("\n");
            }
        }
    }
}
