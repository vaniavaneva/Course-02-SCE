using System;

namespace extra_ex06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Paper: ");
            int paper = int.Parse(Console.ReadLine());
            Console.Write("Cartridge: ");
            int cartridge = int.Parse(Console.ReadLine());
            Console.Write("Pens: ");
            int pens = int.Parse(Console.ReadLine());
            Console.Write("Markers: ");
            int markers = int.Parse(Console.ReadLine());
            Console.Write("Clips: ");
            int clips = int.Parse(Console.ReadLine());
            Console.Write("Discount: ");
            int discount = int.Parse(Console.ReadLine());

            double bill = paper * 9.2 + cartridge * 35.5 + pens * 5.35 + markers * 7.15 + clips * 2.85;
            double final = bill - bill * (discount / 100.0);

            Console.Write($"Final bill with discount included: {final}");
        }
    }
}
