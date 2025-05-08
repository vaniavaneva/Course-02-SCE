using System;

namespace ex02
{
    public class Student : Person
    {
        private string specialty, group, facNum;

        public Student() { }

        public Student(string specialty, string group, string facNum)
        {
            this.specialty = specialty;
            this.group = group;
            this.facNum = facNum;
        }

        public void InputS()
        {
            InputP();
            Console.Write("Specialty: ");
            specialty = Console.ReadLine();
            Console.Write("Group: ");
            group = Console.ReadLine(); ;
            Console.Write("Faculty number: ");
            facNum = Console.ReadLine();
        }

        public void OutputS()
        {
            OutputP();
            Console.WriteLine($"\tSpecialty: {specialty}");
            Console.WriteLine($"\tGroup: {group}");
            Console.WriteLine($"\tFaculty number: {facNum}");
        }
    }
}
