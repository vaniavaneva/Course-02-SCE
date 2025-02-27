using System;
using System.Numerics;

namespace ex03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("a = ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("b = ");
            int b = int.Parse(Console.ReadLine());
            Console.Write("c = ");
            int c = int.Parse(Console.ReadLine());

            double d = Math.Pow(b, 2) - 4 * a * c;

            if (d >= 0)
            {
                double x1 = ((-1) * b + Math.Sqrt(d)) / (2 * a);
                double x2 = ((-1) * b - Math.Sqrt(d)) / (2 * a);

                Console.WriteLine($"x1 = {x1:F2}");
                Console.WriteLine($"x2 = {x2:F2}");
            }
            else
            {
                Console.WriteLine("No real roots");
            }
        }
    }
}
