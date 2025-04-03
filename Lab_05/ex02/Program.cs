using System;

namespace ex02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Speed = ");
            double speed = double.Parse(Console.ReadLine());

            Console.WriteLine("is this mps or kph?");
            string choice = Console.ReadLine();

            if (choice  == "mps")
            {
                Console.WriteLine($"{speed} m/s = {Convertor.Mps(speed)} km/h");
            }
            else if (choice == "kph")
            {
                Console.WriteLine($"{speed} km/h = {Convertor.Kph(speed)} m/s");
            }
            else
            {
                Console.Write("Error");
            }
        }
    }
}
