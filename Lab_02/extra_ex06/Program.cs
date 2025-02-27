using System;

namespace extra_ex06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Side a = ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Side b = ");
            int b = int.Parse(Console.ReadLine());
            Console.Write("Side c = ");
            int c = int.Parse(Console.ReadLine());

            if((a > 0) && (b > 0) && (c > 0) && (a + b > c) && (a + c > b) && (b + c > a))
            {
                if (a == b && b == c)
                {
                    Console.WriteLine("Равностранен");
                }
                else
                {
                    if (a == b || b == c || a == c)
                    {
                        Console.WriteLine("Равнобедрен");
                    }
                    else
                    {
                        Console.WriteLine("Разностранен");
                    }
                }
            }
            else
            {
                Console.Write("0");
            }
        }
    }
}
