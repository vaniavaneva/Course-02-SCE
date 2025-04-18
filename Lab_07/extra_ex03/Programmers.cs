using System;

namespace extra_ex03
{
    class Programmers
    {
        public string Name { get; set; }
        public int Experience { get; set; }
        public double Salary { get; set; }
        public bool CSharp { get; set; }
        public bool CPlus { get; set; }
        public Programmers(string name, int experience, double salary, bool cSharp, bool cPlus)
        {
            Name = name;
            Experience = experience;
            Salary = salary;
            CSharp = cSharp;
            CPlus = cPlus;
        }
        public void Output()
        {
            Console.WriteLine($"\tData for {Name}:");
            Console.WriteLine($"\tExperience: {Experience} months");
            Console.WriteLine($"\tSalary: {Salary}");
            Console.WriteLine($"\tKnows C#: {CSharp}");
            Console.WriteLine($"\tKnows C++: {CPlus}\n");
        }
    }
}
