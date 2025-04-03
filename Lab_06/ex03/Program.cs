using System;

namespace ex03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Default constructor:");
            Student student1 = new Student();
            student1.Input();
            student1.Output();

            Console.WriteLine();

            Console.WriteLine("Initialized constructor:");
            Student student2 = new Student("Ivan", "22472128", "SCI", "1");
            student2.Output();
        }
    }
}
