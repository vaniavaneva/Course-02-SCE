using System;

namespace ex04
{
    public class Rectangle
    {
        private int x, y, width, height;

        public void Input()
        {
            Console.Write("Enter top-left X coordinate: ");
            x = int.Parse(Console.ReadLine());
            Console.Write("Enter top-left Y coordinate: ");
            y = int.Parse(Console.ReadLine());
            Console.Write("Enter width: ");
            width = int.Parse(Console.ReadLine());
            Console.Write("Enter height: ");
            height = int.Parse(Console.ReadLine());
        }

        public void Output()
        {
            Console.WriteLine($"Rectangle: Top-Left({x}, {y}), Width: {width}, Height: {height}");
        }

        public bool Contains(Point p)
        {
            return (p.GetX() >= x && p.GetX() <= x + width &&
                    p.GetY() >= y && p.GetY() <= y + height);
        }
    }
}
