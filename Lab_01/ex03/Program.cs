using System;

namespace ex03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Degrees: ");
            string temp = Console.ReadLine();
            double d = double.Parse(temp);
            Console.Write("What temperature (F/C): ");
            string type = Console.ReadLine();
            if(type == "F")
            {
                Console.Write("Temperature in C = " + (d - 32) / 1.8);
            }
            else if(type == "C")
            {
                Console.Write("Temperature in F = " + d * 1.8 + 32); 
            }
            else
            {
                Console.Write("Error.");
            }
        }
    }
}
