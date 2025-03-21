using System;

namespace ex04
{
    public class Program
    {
        static void Main(string[] args)
        {
            Point point = new Point();
            Console.WriteLine("Enter point coordinates:");
            point.Input();

            Rectangle rectangle = new Rectangle();
            Console.WriteLine("\nEnter rectangle details:");
            rectangle.Input();

            Console.WriteLine("\nPoint Information:");
            point.Output();

            Console.WriteLine("\nRectangle Information:");
            rectangle.Output();

            if (rectangle.Contains(point))
            {
                Console.WriteLine("\nThe point is inside the rectangle.");
            }
            else
            {
                Console.WriteLine("\nThe point is outside the rectangle.");
            }
        }
    }
}
