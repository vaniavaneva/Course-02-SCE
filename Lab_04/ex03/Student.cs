using System;

namespace ex03
{
    public class Student
    {
        private string name, facultyNum, specialty;

        public void Input()
        {
            Console.Write("Name: ");
            name = Console.ReadLine();
            Console.Write("Faculty number: ");
            facultyNum = Console.ReadLine();
            Console.Write("Specialty: ");
            specialty = Console.ReadLine();
        }

        public void Output()
        {
            Console.WriteLine($"Name: {name}");
            Console.WriteLine($"Faculty number: {facultyNum}");
            Console.WriteLine($"Specialty: {specialty}");
        }

        public string FacultyNum()
        {
            return facultyNum;
        }

        public string Name()
        {
            return name;
        }
    }
}
