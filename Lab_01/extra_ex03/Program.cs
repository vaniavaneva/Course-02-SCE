using System;

namespace extra_ex03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter firm name ");
            string fName = Console.ReadLine();
            Console.Write("Enter firm address ");
            string address = Console.ReadLine();
            Console.Write("Enter firm phone number ");
            string fNum = Console.ReadLine();
            Console.Write("Enter firm fax number ");
            string fax = Console.ReadLine();
            Console.Write("Enter firm website ");
            string site = Console.ReadLine();
            Console.WriteLine("Enter firm manager details");
            Console.Write("\tManager's first name ");
            string name = Console.ReadLine();
            Console.Write("\tManager's last name ");
            string lastName = Console.ReadLine();
            Console.Write("\tManager's phone number ");
            string mNum = Console.ReadLine();

            Console.WriteLine("\n--------------------------------------");
            Console.WriteLine($"    {fName} - Business Card          ");
            Console.WriteLine("--------------------------------------");
            Console.WriteLine($"Address: {address}");
            Console.WriteLine($"Phone: {fNum}");
            Console.WriteLine($"Fax: +{fax}");
            Console.WriteLine($"Website: {site}");
            Console.WriteLine($"\nManager Details: {name} {lastName}, {mNum}");
            Console.WriteLine("--------------------------------------");
        }
    }
}
