using System;

namespace ex02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Enter num: ");
                int n = int.Parse(Console.ReadLine());
                if(n <= 0)
                {
                    string error = "Invalid number";
                    throw new Exception(error);
                }
                else
                {
                    Console.WriteLine($"\u221A{n} = {Math.Sqrt(n)}");
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.WriteLine("End of program");
            }
        }
    }
}
