using System;

namespace ex03
{
    public class Complex
    {
        private double real, imag;

        public void Input()
        {
            Console.Write("Real part: ");
            real = double.Parse(Console.ReadLine());
            Console.Write("Imag part: ");
            imag = double.Parse(Console.ReadLine());
        }

        public void Output()
        {
            Console.WriteLine($"{real} + j{imag}");
        }

        public Complex Add(Complex other)
        {
            Complex result = new Complex();
            result.real = real + other.real;
            result.imag = imag + other.imag;
            return result;
        }

        public static Complex Add(Complex a, Complex b)
        {
            Complex result = new Complex();
            result.real = a.real + b.real;
            result.imag = a.imag + b.imag;
            return result;
        }
    }
}
