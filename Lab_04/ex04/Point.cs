using System;

namespace ex04
{
    public class Point
    {
        private int x, y;

        public void Input()
        {
            Console.Write("Enter X coordinate: ");
            x = int.Parse(Console.ReadLine());
            Console.Write("Enter Y coordinate: ");
            y = int.Parse(Console.ReadLine());
        }

        public void Output()
        {
            Console.WriteLine($"Point Coordinates: ({x}, {y})");
        }

        public int GetX()
        {
            return x;
        }

        public int GetY()
        {
            return y;
        }
    }
}
