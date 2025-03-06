using System;

namespace ex03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[,] year = new string[2, 12]
            {
                {"Januray", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December"},
                {"31", "28", "31", "30", "31","30", "31","30", "31","30", "31", "30"}
            };
            for(int y = 0; y < 12; y++)
            {
                Console.WriteLine(year[0, y] + ": " + year[1, y]);
            }
        }
    }
}
