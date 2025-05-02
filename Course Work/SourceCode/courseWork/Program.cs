using System;

namespace courseWork
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter number of workouts for the week: ");
            int n = int.Parse(Console.ReadLine());

            Workout[] workouts = new Workout[n];
            for(int i = 0; i < n; i++)
            {
                Console.WriteLine($"\nEnter details for workout {i + 1}");
                Console.Write("\tName: ");
                string name = Console.ReadLine();
                Console.Write("\tType: ");
                string type = Console.ReadLine();
                Console.Write("\tDuration(in mins): ");
                int duration = int.Parse(Console.ReadLine());
                Console.Write("\tKcals burned: ");
                int calories = int.Parse(Console.ReadLine());
                workouts[i] = new Workout(name, type, duration, calories);
                Console.WriteLine();
            }

            CalsAsc(workouts);
            Workout maxCals = workouts[workouts.Length - 1];
            double avgCals = AvgCals(workouts);

            Console.WriteLine($"Burned most Kcals during {maxCals.Name} - {maxCals.Calories}!");
            Console.WriteLine($"Average Kcals burned - {avgCals:F2}\n");
            Console.WriteLine("List of this week's workouts");
            Console.WriteLine("\tname - type - duration - calories");

            foreach(var w in workouts)
            {
                w.Output();
            }
        }
        
        static void CalsAsc(Workout[] workouts)
        {
            Array.Sort(workouts, (w1, w2) => w1.Calories.CompareTo(w2.Calories));
        }

        static double AvgCals(Workout[] workouts)
        {
            double total = 0;
            foreach(var w in workouts)
            {
                total += w.Calories;
            }
            return total / workouts.Length;
        }
    }
}
