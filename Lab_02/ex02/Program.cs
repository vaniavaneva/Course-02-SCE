using System;

namespace ex02
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

            if(a == b && b == c)
            {
                Console.WriteLine("Равностранен");
            }
            else
            {
                if(a == b || b == c || a == c)
                {
                    Console.WriteLine("Равнобедрен");
                }
                else
                {
                    Console.WriteLine("Разностранен");
                }
            }
        }
    }
}
