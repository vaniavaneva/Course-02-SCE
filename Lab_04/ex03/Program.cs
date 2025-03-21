using System;

namespace ex03
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter number of students: ");
            int num = int.Parse(Console.ReadLine());

            Student[] students = new Student[num];

            for (int i = 0; i < num; i++)
            {
                Console.WriteLine($"\nEnter data for student {i + 1}:");
                students[i] = new Student();
                students[i].Input();
            }

            Console.Write("\nSearch with faculty number: ");
            string search = Console.ReadLine();
            bool found = false;

            for (int i = 0; i < num; i++)
            {
                if (students[i].FacultyNum() == search)
                {
                    students[i].Output();
                    found = true;
                    break;
                }
            }

            if (!found)
            {
                Console.WriteLine($"No student found with {search}");
            }

            Console.WriteLine("\nAll students:");
            Console.ReadKey();
            for (int i = 0; i < num; i++)
            {
                students[i].Output();
                Console.WriteLine();
            }
        }
    }
}
