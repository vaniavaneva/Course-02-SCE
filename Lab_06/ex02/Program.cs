using System;

namespace ex02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Default constructor:");
            Circle c1 = new Circle();
            c1.Input();
            Console.WriteLine("Area = " + c1.Area());

            Rectangle r1 = new Rectangle();
            r1.Input();
            Console.WriteLine("Area = " + r1.Area());

            Console.WriteLine();

            Console.WriteLine("Initialized constructor:");
            Circle c2 = new Circle(2.4);
            Console.WriteLine("Area = " + c2.Area());

            Rectangle r2 = new Rectangle(31.7, 9.6);
            Console.WriteLine("Area = " + r2.Area());
        }
    }
}
