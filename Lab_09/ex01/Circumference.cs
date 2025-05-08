using System;

namespace ex01
{
    public class Circumference
    {
        private int r;
        public Circumference()
        {
            r = 3;
        }

        public Circumference(int r)
        {
            this.r = r;
        }
        public int Radius { get { return r; } set { r = value; } }

        public double AreaCircle()
        {
            return Math.PI * Math.Pow(r, 2);
        }
    }
}
