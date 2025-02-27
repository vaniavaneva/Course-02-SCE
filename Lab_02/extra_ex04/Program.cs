using System;

namespace extra_ex04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for(int a = 1; a < 100; a++)
            {
                for(int b = a; b < 100; b++)
                {
                    int c = (int)Math.Sqrt(a * a + b * b);

                    if (c * c == a * a + b * b && c < 100)
                    {
                        Console.Write($"{a}, {b}, {c}\n");
                    }
                }
            }
        }
    }
}
