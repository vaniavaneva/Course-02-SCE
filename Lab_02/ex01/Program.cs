using System;

namespace ex01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Аритметични
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("Arithmetic");
            Console.Write($"{a} + {b} = {a + b}\n");
            Console.Write($"{a} - {b} = {a - b}\n");
            Console.Write($"{a} * {b} = {a * b}\n");
            Console.Write($"{a} / {b} = {a / (double)b}\n");
            Console.Write($"{a} % {b} = {a % b}\n\n");

            // Логически
            Console.WriteLine("Logical");
            bool x = true;
            bool y = false;
            Console.Write($"{x} && {y} = {x && y}\n");
            Console.Write($"{x} || {y} = {x || y}\n");
            Console.Write($"!{x} = {!x}\n\n");

            // Побитови
            Console.WriteLine("Bitwise");
            Console.Write($"{a} & {b} = {a & b}\n");
            Console.Write($"{a} | {b} = {a | b}\n");
            Console.Write($"{a} ^ {b} = {a ^ b}\n");
            Console.Write($"~{a} = {~a}\n");
            Console.Write($"{a} << {1} = {a << 1}\n");
            Console.Write($"{a} >> {1} = {a >> 1}\n");
        }
    }
}
