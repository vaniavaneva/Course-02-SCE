using System;

namespace ex04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Speed: ");
            double speed = double.Parse(Console.ReadLine());
            Console.Write("km or m: ");
            string type = Console.ReadLine();
            if (type == "km")
            {
                Console.Write("Speed in m/s = " + speed / 3.6);
            }
            else
            {
                if (type == "m")
                {
                    Console.Write("Speed in km/h = " + speed * 3.6);
                }
                else
                {
                    Console.Write("Error.");
                }
            }
        }
    }
}
