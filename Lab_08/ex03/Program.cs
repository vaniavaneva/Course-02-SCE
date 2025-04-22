using System;
using System.Globalization;

namespace ex03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Enter num for month: ");
                int n = int.Parse(Console.ReadLine());
                if (n <= 0 || n > 13) // 1-12
                {
                    string error = "Invalid value. Must be 1-12";
                    throw new Exception(error);
                }
                else
                {
                    Console.WriteLine(CultureInfo.CurrentCulture.DateTimeFormat.GetMonthName(n));
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
