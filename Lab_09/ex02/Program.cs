using System;

namespace ex02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Person");
            Person p1 = new Person();
            p1.InputP();

            Console.WriteLine();

            Console.WriteLine("Student");
            Student s1 = new Student();
            s1.InputS();

            Console.WriteLine();

            Console.WriteLine("Person details:");
            p1.OutputP();
            Console.WriteLine("Student details:");
            s1.OutputS();
        }
    }
}
