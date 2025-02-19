namespace ex02
{
    internal class Program
    {
        static int Square(int a)
        {
            return a * a;
        }

        static int Rectangle(int a, int b)
        {
            return a * b;
        }

        static double Circle(int a)
        {
            return a * a * Math.PI;
        }

        static double Triangle(int a, int b)
        {
            return (a * b)/2.0;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Choose a figure\n1 - Square\n2 - Rectangle\n3 - Circle\n4 - Triangle\n5 - Exit");
            int _ = int.Parse(Console.ReadLine());
            int a, b;
            while(_ != 5)
            {
                switch (_)
                {
                    case 1:
                        Console.Write("a = ");
                        a = int.Parse(Console.ReadLine());
                        Console.WriteLine("Area of square = " + Square(a));
                        break;

                    case 2:
                        Console.Write("a = ");
                        a = int.Parse(Console.ReadLine());
                        Console.Write("b = ");
                        b = int.Parse(Console.ReadLine());
                        Console.WriteLine("Area of rectangle = " + Rectangle(a, b));
                        break;

                    case 3:
                        Console.Write("r = ");
                        a = int.Parse(Console.ReadLine());
                        Console.WriteLine("Area of circle = " + Circle(a));
                        break;

                    case 4:
                        Console.Write("a = ");
                        a = int.Parse(Console.ReadLine());
                        Console.Write("h = ");
                        b = int.Parse(Console.ReadLine());
                        Console.WriteLine("Area of triangle = " + Triangle(a, b));
                        break;

                    default:
                        Console.WriteLine("Error.");
                        break;
                }
                Console.Write("Choose a figure: ");
                _ = int.Parse(Console.ReadLine());
            }
        }
    }
}
