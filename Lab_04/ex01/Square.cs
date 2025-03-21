using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex01
{
    public class Square
    {
        private double a;

        public void Input()
        {
            Console.Write("a = ");
            a = double.Parse(Console.ReadLine());
        }

        public void Output()
        {
            Console.WriteLine($"Area: {a} * {a} = {a * a}\n");
        }

        public double Area()
        {
            return a * a;
        }
    }
}
