using System;

namespace ex02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            uint n = uint.Parse(Console.ReadLine());
            int[] m = new int[n];
            int posSum = 0, index = 0;

            for (int i = 0; i < m.Length; i++)
            {
                m[i] = int.Parse(Console.ReadLine());
            }

            foreach(int _ in m)
            {
                if (_ > 0)
                {
                    posSum++;
                }
            }
            int[] pos = new int[posSum];

            foreach(int _ in m)
            {
                if(_ > 0)
                {
                    pos[index] = _;
                    index++;
                }
            }

            Console.Write("\nOriginal array: ");
            foreach(int _ in m)
            {
                Console.Write(_ + " ");
            }

            Console.Write("\nPositive items only array: ");
            foreach (int _ in pos)
            {
                Console.Write(_ + " ");
            }
        }
    }
}
