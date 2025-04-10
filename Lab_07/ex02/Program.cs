using System;

namespace ex02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string brand, color, regNum;
            Console.WriteLine("Enter car 1 details");
            Console.Write("Brand: ");
            brand = Console.ReadLine();
            Console.Write("Color: ");
            color = Console.ReadLine();
            Console.Write("Registration number: ");
            regNum = Console.ReadLine();
            
            Car car1 = new Car(brand, color, regNum);
            Car car2 = new Car();

            Console.WriteLine();

            Console.WriteLine("Enter car 2 details");
            Console.Write("Brand: ");
            car2.Brand = Console.ReadLine();
            Console.Write("Color: ");
            car2.Color = Console.ReadLine();
            Console.Write("Registration number: ");
            car2.RegNum = Console.ReadLine();

            Console.WriteLine();

            Console.WriteLine("Listing car 1 details");
            car1.Output();
            Console.WriteLine();
            Console.WriteLine("Listing car 2 details");
            car2.Output();
        }
    }
}
