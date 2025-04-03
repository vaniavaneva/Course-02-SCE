using System;

namespace ex03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Complex complex1 = new Complex();
            Complex complex2 = new Complex();

            Console.WriteLine("Complex num 1:");
            complex1.Input();
            Console.WriteLine("\nComplex num 2:");
            complex2.Input();

            Console.WriteLine();

            Complex sum1 = complex1.Add(complex2);
            Console.Write("Sum = ");
            sum1.Output();

            Console.WriteLine();

            Complex sum2 = Complex.Add(complex1, complex2);
            Console.Write("Sum (static) = ");
            sum2.Output();

            Console.WriteLine();

            Console.Write("First num = ");
            complex1.Output();
            Console.Write("Second num = ");
            complex2.Output();
        }
    }
}
