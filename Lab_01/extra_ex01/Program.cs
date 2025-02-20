using System;

namespace extra_ex01
{
    internal class Program
    {
        static int Parallelogram(int a, int b)
        {
            return a * b;
        }

        static double Trapezoid(int a, int b, int c)
        {
            double s = (a + b + c) / 2.0;
            return Math.Sqrt(s * (s - a) * (s - b) * (s - c));
        }

        static double TriangleBySides(int a, int b, int c)
        {
            return (a * b) / 2.0;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Choose a figure\n1 - Parallelogram\n2 - Trapezoid\n3 - Triangle(3 sides)\n4 - Exit");
            int _ = int.Parse(Console.ReadLine());
            int a, b, c;
            while (_ != 4)
            {
                switch (_)
                {
                    case 1:
                        Console.Write("a = ");
                        a = int.Parse(Console.ReadLine());
                        Console.Write("h = ");
                        b = int.Parse(Console.ReadLine());
                        Console.WriteLine("Area of Parallelogram = " + Parallelogram(a, b));
                        break;

                    case 2:
                        Console.Write("a = ");
                        a = int.Parse(Console.ReadLine());
                        Console.Write("b = ");
                        b = int.Parse(Console.ReadLine());
                        Console.Write("h = ");
                        c = int.Parse(Console.ReadLine());
                        Console.WriteLine("Area of Trapezoid = " + Trapezoid(a, b, c));
                        break;

                    case 3:
                        Console.Write("a = ");
                        a = int.Parse(Console.ReadLine());
                        Console.Write("b = ");
                        b = int.Parse(Console.ReadLine());
                        Console.Write("c = ");
                        c = int.Parse(Console.ReadLine());
                        Console.WriteLine("Area of Triangle (using S) = " + TriangleBySides(a, b, c));
                        break;

                    default:
                        Console.WriteLine("Error.");
                        break;
                }
                Console.Write("Choose a figure: ");
                _ = int.Parse(Console.ReadLine());
            }
        }
    }
}
