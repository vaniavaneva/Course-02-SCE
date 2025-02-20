using System;

namespace ex01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Num: "); //Не преминава на нов ред
            int num = int.Parse(Console.ReadLine()); //Чете цял ред
            Console.WriteLine($"Num - 1: {num - 1}\nType symbol: "); //Преминава на нов ред
            int symbol = Console.Read(); //Чете само един символ
        }
    }
}
