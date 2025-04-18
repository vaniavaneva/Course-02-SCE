using System;

namespace extra_ex02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car c1 = new Car();
            Console.WriteLine("Default constructor");
            c1.Input();
            Console.WriteLine($"Размер на данъка на МПС: { c1.Tax():F2}лева.в община { c1.Municipalty}");
            Console.WriteLine("Initialised constructor");
            Car c2 = new Car(90, 2006, 3, "Хасково");
            Console.WriteLine($"Размер на данъка на МПС: { c2.Tax():F2}лева.в община { c2.Municipalty}");
        }
    }
}
