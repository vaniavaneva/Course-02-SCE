using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex01
{
    public class Trapezoid
    {
        private double a;
        private double b;
        private double h;

        public void Input()
        {
            Console.Write("a = ");
            a = double.Parse(Console.ReadLine());
            Console.Write("b = ");
            b = double.Parse(Console.ReadLine());
            Console.Write("h = ");
            h = double.Parse(Console.ReadLine());
        }

        public void Output()
        {
            Console.WriteLine($"Area: (({a} + {b}) / 2) * {h} = {((a + b) / 2) * h}\n");
        }

        public double Area()
        {
            return ((a + b) / 2) * h;
        }
    }
}
