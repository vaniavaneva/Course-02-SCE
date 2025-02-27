using System;

namespace extra_ex08
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int _ = int.Parse(Console.ReadLine());
            switch (_)
            {
                case 1:
                    goto case 12;
                case 2:
                    goto case 12;
                case 3:
                    goto case 5;
                case 4:
                    goto case 5;
                case 5:
                    Console.Write("Spring");
                    break;
                case 6:
                    goto case 8;
                case 7:
                    goto case 8;
                case 8:
                    Console.Write("Summer");
                    break;
                case 9:
                    goto case 11;
                case 10:
                    goto case 11;
                case 11:
                    Console.Write("Autumn");
                    break;
                case 12:
                    Console.Write("Winter");
                    break;
                default:
                    Console.Write("Invalid month num");
                    break;
            }
        }
    }
}
