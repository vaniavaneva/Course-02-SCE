using System;
using System.Collections.Generic;

namespace extra_ex03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Programmers> programmers = new List<Programmers>();
            List<Managers> managers = new List<Managers>();

            programmers.Add(new Programmers("Иван", 6, 1500, true, true));
            programmers.Add(new Programmers("Мартин", 5, 1300, false, false));
            programmers.Add(new Programmers("Минка", 2, 1000, true, false));
            programmers.Add(new Programmers("Иванa", 7, 1600, false, true));

            managers.Add(new Managers("Борис", 2, 2200, 130));
            managers.Add(new Managers("Мария", 5, 2600, 80));
            managers.Add(new Managers("Ася", 3, 2400, 60));

            programmers.RemoveAll(p => {
                if (p.Experience < 3)
                {
                    Console.WriteLine($"Removed {p.Name} with {p.Experience} months experience.");
                    return true;
                }
                return false;
            });

            managers.RemoveAll(m => {
                if (m.Experience < 3)
                {
                    Console.WriteLine($"Removed {m.Name} with {m.Experience} months experience.");
                    return true;
                }
                return false;
            });

            Console.WriteLine();

            foreach (var p in programmers)
            {
                if (p.CSharp && p.CPlus)
                    p.Salary += 500;
                else if (p.CSharp)
                    p.Salary += 100;
                else if (p.CPlus)
                    p.Salary += 500;
            }

            Console.WriteLine("All programmers");
            foreach(var p in programmers)
            {
                p.Output();
            }
            Console.WriteLine();

            Console.WriteLine("All Managers");
            foreach (var m in managers)
            {
                m.Output();
            }

            double total = 0;
            foreach (var p in programmers) total += p.Salary;
            foreach (var m in managers) total += m.Salary;
            Console.WriteLine($"\nTotal monthly expences: {total}");
        }
    }
}
