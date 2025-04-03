using System;

namespace ex02
{
    class Circle
    {
        private double r;

        public Circle()
        {
            r = 0;
        }

        public Circle(double r)
        {
            this.r = r;
        }

        public void Input()
        {
            Console.Write("Enter radius: ");
            r = double.Parse(Console.ReadLine());
        }

        public double Area()
        {
            return r * r * Math.PI;
        }
    }
}
