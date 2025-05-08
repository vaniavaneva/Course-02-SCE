using System;

namespace ex01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Prefixed values");
            Circumference c1 = new Circumference();
            Cylinder cy1 = new Cylinder();
            Cone co1 = new Cone();
            Console.WriteLine($"\tCircle area = {c1.AreaCircle():F2}");
            Console.WriteLine($"\tCylinder volume = {cy1.VolumeCy():F2}");
            Console.WriteLine($"\tCone volume = {co1.VolumeCo():F2}\n");

            Console.Write("Enter radius: ");
            int n = int.Parse(Console.ReadLine());
            Circumference c2 = new Circumference(n);
            Console.Write("Enter height for cylinder: ");
            n = int.Parse(Console.ReadLine());
            Cylinder cy2 = new Cylinder(n);
            Console.Write("Enter height for cone: ");
            n = int.Parse(Console.ReadLine());
            Cone co2 = new Cone(n);
            Console.WriteLine($"\tCircle area = {c2.AreaCircle():F2}");
            Console.WriteLine($"\tCylinder volume = {cy2.VolumeCy():F2}");
            Console.WriteLine($"\tCone volume = {co2.VolumeCo():F2}");
        }
    }
}
