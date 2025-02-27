using System;

namespace extra_ex07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a: ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Enter b: ");
            int b = int.Parse(Console.ReadLine());

            if(a == b)
            {
                Console.Write($"a = b\n{a} = {b}");
            }
            else
            {
                if(a > b)
                {
                    Console.Write($"a > b\n{a} > {b}");
                }
                else
                {
                    Console.Write($"a < b\n{a} < {b}");
                }
            }
        }
    }
}
