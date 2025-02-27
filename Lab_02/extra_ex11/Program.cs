using System;

namespace extra_ex11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("n = ");
            int n = int.Parse(Console.ReadLine()), sum = 0, num;
            while(n > 0)
            {
                num = int.Parse(Console.ReadLine());
                if(num < 0)
                {
                    sum += num;
                }
                n--;
            }
            Console.Write($"Sum of negative nums = {sum}");
        }
    }
}
