using System;

namespace extra_ex05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter time: ");
            int time = int.Parse(Console.ReadLine());
            string result = "";

            if (time >= 0 && time < 24)
            {
                result = (time >= 5 && time < 11) ? "Добро утро" :
                        (time >= 11 && time < 18) ? "Добър ден" :
                        (time >= 18 && time < 21) ? "Добър вечер" : "Лека нощ";
            }
            else
            {
                result = "Error";
            }

            Console.WriteLine(result);
        }
    }
}
