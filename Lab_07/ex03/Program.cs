using System;

namespace ex03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name, lastName, number;
            Console.WriteLine("Enter person 1 details");
            Console.Write("First name: ");
            name = Console.ReadLine();
            Console.Write("Last name: ");
            lastName = Console.ReadLine();
            Console.Write("Phone number: ");
            number = Console.ReadLine();

            Person p1 = new Person(name, lastName, number);
            Person p2 = new Person();

            Console.WriteLine();

            Console.WriteLine("Enter person 2 details");
            Console.Write("First name: ");
            p2.Name = Console.ReadLine();
            Console.Write("Last name: ");
            p2.LastName = Console.ReadLine();
            Console.Write("Phone number: ");
            p2.Number = Console.ReadLine();

            Console.WriteLine();

            Console.WriteLine("Listing person 1 details");
            p1.Output();
            Console.WriteLine();
            Console.WriteLine("Listing person 2 details");
            p2.Output();
        }
    }
}
