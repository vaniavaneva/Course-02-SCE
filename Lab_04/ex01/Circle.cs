using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex01
{
    public class Circle
    {
        private double r;

        public void Input()
        {
            Console.Write("r = ");
            r = double.Parse(Console.ReadLine());
        }

        public void Output()
        {
            Console.WriteLine($"Area: 3.14 * {r}^2 = {Math.PI * r * r}\n");
        }

        public double Area()
        {
            return Math.PI * r * r;
        }
    }
}
