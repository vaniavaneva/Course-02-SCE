using System;

namespace ex01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Enter num1: ");
                int a = int.Parse(Console.ReadLine());
                Console.Write("Enter num2: ");
                int b = int.Parse(Console.ReadLine());
                int c = a / b;
                Console.WriteLine($"{a} / {b} = {c}");
            }
            catch(DivideByZeroException ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.Write("Good bye!");
            }
        }
    }
}
