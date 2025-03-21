using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex01
{
    public class Cone
    {
        private double h;
        private double r;

        public void Input()
        {
            Console.Write("r = ");
            r = double.Parse(Console.ReadLine());
            Console.Write("h = ");
            h = double.Parse(Console.ReadLine());
        }

        public void Output()
        {
            Console.WriteLine($"Area: 3.14 * {r} * ({r} + \u221A({h}^2 + {r}^2)) = {Math.PI * r * (r + Math.Sqrt(h * h + r * r))}\n");
        }

        public double Area()
        {
            return Math.PI * r * (r + Math.Sqrt(h * h + r * r));
        }
    }
}
