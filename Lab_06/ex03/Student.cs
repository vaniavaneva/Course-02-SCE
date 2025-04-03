using System;

namespace ex03
{
    class Student
    {
        private string fullName, facNum, spec, course;
        public Student()
        {
        }

        public Student(string fullName, string facNum, string spec, string course)
        {
            this.fullName = fullName;
            this.facNum = facNum;
            this.spec = spec;
            this.course = course;
        }

        public void Input()
        {
            Console.Write("Enter full name: ");
            fullName = Console.ReadLine();
            Console.Write("Enter faculty number: ");
            facNum = Console.ReadLine();
            Console.Write("Enter specialty: ");
            spec = Console.ReadLine();
            Console.Write("Enter course: ");
            course = Console.ReadLine();
        }

        public void Output()
        {
            Console.WriteLine("Full name: " + fullName);
            Console.WriteLine("Faculty number: " + facNum);
            Console.WriteLine("Specialty: " + spec);
            Console.WriteLine("Course: " + course);
        }
    }
}
