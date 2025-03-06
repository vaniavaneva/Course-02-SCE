using System;

namespace ex01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            uint n = uint.Parse(Console.ReadLine());
            double[] m = new double[n];

            for(int i = 0; i<m.Length; i++)
            {
                m[i] = double.Parse(Console.ReadLine());
            }

            Console.WriteLine("\nArray in asc order: ");
            foreach(double _ in m)
            {
                Console.Write(_ + " ");
            }

            Console.WriteLine("\n\nArray in desc order: ");
            for (int i = m.Length - 1; i > 0; i--)
            {
                Console.Write(m[i] + " ");
            }

            Console.WriteLine("\n\nEven index elements: ");
            for (int i = 0; i < m.Length; i+=2)
            {
                Console.Write(m[i] + " ");
            }

            Console.WriteLine("\n\nOdd index elements: ");
            for (int i = 1; i < m.Length; i += 2)
            {
                Console.Write(m[i] + " ");
            }
        }
    }
}
