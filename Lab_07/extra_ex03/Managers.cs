using System;

namespace extra_ex03
{
    class Managers
    {
        public string Name { get; set; }
        public int Experience { get; set; }
        public double Salary { get; set; }
        public int People { get; set; }
        public Managers(string name, int experience, double salary, int people)
        {
            Name = name;
            Experience = experience;
            Salary = salary;
            People = people;
        }
        public void Output()
        {
            Console.WriteLine($"\tData for {Name}:");
            Console.WriteLine($"\tExperience: {Experience} months");
            Console.WriteLine($"\tSalary: {Salary}");
            Console.WriteLine($"\tManaged people: {People}\n");
        }
    }
}
