using System;

namespace courseWork
{
    public class Workout
    {
        private string name, type;
        private int duration, calories;
        
        public Workout(string name, string type, int duration, int calories)
        {
            this.name = name;
            this.type = type;
            this.duration = duration;
            this.calories = calories;
        }

        public string Name { get { return name; } set { name = value; } }
        public int Calories { get { return calories; } set { calories = value; } }

        public void Output()
        {
            Console.WriteLine($"\t{name} - {type} - {duration} mins - {calories} Kcals");
        }
    }
}
