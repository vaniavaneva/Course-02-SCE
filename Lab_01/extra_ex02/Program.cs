using System;

namespace extra_ex02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter millimeter: ");
            double _ = double.Parse(Console.ReadLine());
            Console.WriteLine($"{_}mm = {_ / 1000}m");

            Console.Write("Enter kilogram: ");
            _ = double.Parse(Console.ReadLine());
            Console.WriteLine($"{_}kg = {_ / 1000}t");

            Console.Write("Enter century/es: ");
            _ = double.Parse(Console.ReadLine());
            Console.WriteLine($"{_} century/es = {_ * 100} year/s");

            Console.Write("Enter minutes: ");
            _ = double.Parse(Console.ReadLine());
            Console.WriteLine($"{_} mins = {_ / 60} hrs");

            Console.Write("Enter degrees in C: ");
            _ = double.Parse(Console.ReadLine());
            Console.WriteLine($"{_}C = {_ * 1.8 + 32}F");

            Console.Write("Enter degrees in F: ");
            _ = double.Parse(Console.ReadLine());
            Console.WriteLine($"{_}F = {(_ - 32) * 5 / 9 + 273.15}K");
        }
    }
}
