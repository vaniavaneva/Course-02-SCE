using System;

namespace ex07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("n (cols) = ");
            uint n = uint.Parse(Console.ReadLine());
            Console.Write("m (rows) = ");
            uint m = uint.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                for (int y = 1; y <= n; y++)
                {
                    Console.Write("*");
                }
                Console.Write("\n");
            }

            Console.Write("\n");

            for (int i = 1; i <= n; i++)
            {
                for (int y = 1; y <= m; y++)
                {
                    Console.Write("*");
                }
                Console.Write("\n");
            }

            Console.Write("\n");

            for (int i = 1; i <= n; i++)
            {
                for (int y = 1; y <= i; y++)
                {
                    Console.Write("*");
                }
                Console.Write("\n");
            }
        }
    }
}
