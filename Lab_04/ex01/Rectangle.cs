using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex01
{
    public class Rectangle
    {
        private double a;
        private double b;

        public void Input()
        {
            Console.Write("a = ");
            a = double.Parse(Console.ReadLine());
            Console.Write("b = ");
            b = double.Parse(Console.ReadLine());
        }

        public void Output()
        {
            Console.WriteLine($"Area: {a} * {b} = {a * b}\n");
        }

        public double Area()
        {
            return a * b;
        }
    }
}
