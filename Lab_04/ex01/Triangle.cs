using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex01
{
    public class Triangle
    {
        private double h;
        private double b;

        public void Input()
        {
            Console.Write("h = ");
            h = double.Parse(Console.ReadLine());
            Console.Write("b = ");
            b = double.Parse(Console.ReadLine());
        }

        public void Output()
        {
            Console.WriteLine($"Area: ({h} * {b}) / 2 = {(h * b) / 2}\n");
        }

        public double Area()
        {
            return (h * b) / 2;
        }
    }
}
