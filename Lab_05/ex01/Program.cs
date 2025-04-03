using System;

namespace ex01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Point[] point = new Point[3];

            for (int i = 0; i < 3; i++)
            {
                point[i] = new Point();
            }

            Console.WriteLine("Point 1");
            point[0].Input();
            Console.WriteLine("Point 2 (10, 3)");
            point[1].Input(10, 3);
            Console.WriteLine("Point 3");
            point[2].Input();

            Console.WriteLine($"\nDistance between Point 1 & Point 2: {Point.Distance(point[0], point[1]):F4}");
            Console.WriteLine($"Distance between Point 2 & Point 3: {Point.Distance(point[1], point[2]):F4}");
            Console.WriteLine($"Distance between Point 3 & Point 1: {Point.Distance(point[2], point[0]):F4}\n");

            for (int i = 0; i < 3; i++)
            {
                Console.Write($"Point {i + 1} coordinates: ");
                point[i].Output();
            }
        }
    }
}
