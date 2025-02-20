using System;

namespace extra_ex05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Cost for 1 year: ");
            int cost = int.Parse(Console.ReadLine());

            double ski = cost - cost * 0.4;
            double outfit = ski - ski * 0.2;
            double helmet = outfit / 4.0;
            double acc = helmet / 5.0;

            Console.Write(cost + ski + outfit + helmet + acc);
        }
    }
}
