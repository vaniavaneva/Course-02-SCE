using System;

namespace ex01
{
    public class Point
    {
        private int x, y;

        public void Input()
        {
            Console.Write("x = ");
            x = int.Parse(Console.ReadLine());
            Console.Write("y = ");
            y = int.Parse(Console.ReadLine());
        }

        public void Input(int newX, int newY)
        {
            x = newX;
            y = newY;
        }

        public void Output()
        {
            Console.WriteLine($"x = {x}, y = {y}");
        }

        public static double Distance(Point a, Point b)
        {
            int dx, dy;
            dx = a.x - b.x;
            dy = a.y - b.y;
            double l = Math.Sqrt(dx * dx + dy * dy);
            return l;
        }
    }
}
