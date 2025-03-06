using System;
using System.Linq;

namespace ex04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] station = { "Ново село", "Видин", "Лом", "Оряхово", "Монтана", "Враца" };
            int[] degrees = { 8, 17, -6, 23, 0, 1 };
            int min = degrees.Min();
            int max = degrees.Max();

            var minIndex = degrees
            .Select((value, index) => new { value, index })
            .OrderBy(x => x.value)
            .First()
            .index;

            var maxIndex = degrees
            .Select((value, index) => new { value, index })
            .OrderByDescending(x => x.value)
            .First()
            .index;

            Console.WriteLine($"Lowest temperature: {min}°C in station {station[minIndex]}");
            Console.WriteLine($"Lowest temperature: {max}°C in station {station[maxIndex]}");
            Console.WriteLine($"Difference in temperature: {max - min}°C");
        }
    }
}
