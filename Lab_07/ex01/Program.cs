using System;
using System.Linq;

namespace ex01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n, m;

            Console.WriteLine("Enter width and height for rectangle 1:");
            n = int.Parse(Console.ReadLine());
            m = int.Parse(Console.ReadLine());

            Rectangle r1 = new Rectangle(n, m);

            Console.WriteLine("Enter width and height for rectangle 2:");
            n = int.Parse(Console.ReadLine());
            m = int.Parse(Console.ReadLine());

            Rectangle r2 = new Rectangle(n, m);

            Console.WriteLine("Enter width and height for rectangle 3:");
            n = int.Parse(Console.ReadLine());
            m = int.Parse(Console.ReadLine());

            Rectangle r3 = new Rectangle(n, m);

            int[] Areas = { r1.Area, r2.Area, r3.Area };
            int max = Areas.Max();
            int index = Array.IndexOf(Areas, max);

            Console.WriteLine($"Rectangle {index + 1} has the biggest area = {max}");
        }
    }
}
