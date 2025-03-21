using System;
using System.Linq;

namespace ex01
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Rectangle:");
            Rectangle rectangle = new Rectangle();
            rectangle.Input();
            rectangle.Output();

            Console.WriteLine("Triangle:");
            Triangle triangle = new Triangle();
            triangle.Input();
            triangle.Output();

            Console.WriteLine("Circle:");
            Circle circle = new Circle();
            circle.Input();
            circle.Output();

            Console.WriteLine("Trapezoid:");
            Trapezoid trapezoid = new Trapezoid();
            trapezoid.Input();
            trapezoid.Output();

            Console.WriteLine("Cone:");
            Cone cone = new Cone();
            cone.Input();
            cone.Output();

            Console.WriteLine("Square:");
            Square square = new Square();
            square.Input();
            square.Output();

            string[] Figures = { "Rectangle", "Triangle", "Circle", "Trapezoid", "Cone", "Square" };
            double[] Areas = { rectangle.Area(), triangle.Area(), circle.Area(), trapezoid.Area(), cone.Area(), square.Area() };

            double max = Areas.Max();
            int maxIndex = Array.IndexOf(Areas, max);

            Console.WriteLine($"\nLargest area: {max}, figure: {Figures[maxIndex]}");
        }
    }
}
