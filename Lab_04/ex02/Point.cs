using System;

namespace ex02
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

        public void Output()
        {
            Console.WriteLine($"x: {x}; y: {y}");
        }

        public void Translation(int vx, int vy)
        {
            int oldX = x, oldY = y;
            x += vx;
            y += vy;

            Console.WriteLine($"New position after translation: ({x}; {y})");
            Console.WriteLine($"Difference in x = {x - oldX} & y = {y - oldY}");
        }

        public void Rotation(double angle)
        {
            double radians = angle * Math.PI / 180;
            int oldX = x, oldY = y;

            double newX = x * Math.Cos(radians) - y * Math.Sin(radians);
            double newY = x * Math.Sin(radians) + y * Math.Cos(radians);

            x = (int)Math.Round(newX);
            y = (int)Math.Round(newY);

            Console.WriteLine($"New position after rotation: ({x}; {y})");
            Console.WriteLine($"Difference in x = {x - oldX} & y = {y - oldY}");
        }

        public void Scaling(int kx, int ky)
        {
            int oldX = x, oldY = y;
            x *= kx;
            y *= ky;

            Console.WriteLine($"New position after scaling: ({x}; {y})");
            Console.WriteLine($"Difference in x =  {x - oldX} & y = {y - oldY}");
        }

    }
}
