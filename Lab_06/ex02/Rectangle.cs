using System;

namespace ex02
{
    class Rectangle
    {
        private double height, width;

        public Rectangle()
        {
            height = width = 0;
        }

        public Rectangle(double height, double width)
        {
            this.height = height;
            this.width = width;
        }

        public void Input()
        {
            Console.Write("Enter a: ");
            height = double.Parse(Console.ReadLine());
            Console.Write("Enter b: ");
            width = double.Parse(Console.ReadLine());
        }

        public double Area()
        {
            return height * width;
        }
    }
}
