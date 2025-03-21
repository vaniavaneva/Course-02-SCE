using System;

namespace ex02
{
    public class Program
    {
        static void Main(string[] args)
        {
            Point[] points = new Point[3];
            for (int i = 0; i < 3; i++)
            {
                points[i] = new Point();
                Console.WriteLine($"Point {i + 1}:");
                points[i].Input();
            }

            while (true)
            {
                Console.Write("Choose point (1, 2, 3) or 0 to Exit: ");
                int choice = int.Parse(Console.ReadLine());
                if (choice == 0) break;
                if (choice < 1 || choice > 3)
                {
                    Console.WriteLine("Invalid choice!");
                    continue;
                }

                Point selectedPoint = points[choice - 1];

                Console.Write("translation, rotation or scaling? - ");
                string action = Console.ReadLine().ToLower();

                switch (action)
                {
                    case "translation":
                        Console.Write("Vx = ");
                        int vx = int.Parse(Console.ReadLine());
                        Console.Write("Vy = ");
                        int vy = int.Parse(Console.ReadLine());
                        selectedPoint.Translation(vx, vy);
                        break;

                    case "rotation":
                        Console.Write("Alpha (degrees) = ");
                        double alpha = double.Parse(Console.ReadLine());
                        selectedPoint.Rotation(alpha);
                        break;

                    case "scaling":
                        Console.Write("Kx = ");
                        int kx = int.Parse(Console.ReadLine());
                        Console.Write("Ky = ");
                        int ky = int.Parse(Console.ReadLine());
                        selectedPoint.Scaling(kx, ky);
                        break;

                    default:
                        Console.WriteLine("Invalid action!");
                        break;
                }
            }

            Console.WriteLine("Final positions:");
            for (int i = 0; i < 3; i++)
            {
                Console.Write($"Point {i + 1}: ");
                points[i].Output();
            }
        }
    }
}
