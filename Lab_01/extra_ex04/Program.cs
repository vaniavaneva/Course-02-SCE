using System;

namespace extra_ex04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Tank volume: ");
            double tank = double.Parse(Console.ReadLine());
            Console.Write("Distance passed with a full tank: ");
            double distance = double.Parse(Console.ReadLine());
            Console.Write("Vehicle model: ");
            string model = Console.ReadLine();

            double cost = (tank * 100) / distance;

            Console.Write($"Вашият среден разход за 100 км е {cost} л/км, все пак е {model}!");
        }
    }
}
