using System;

namespace ex01
{
    public class Cone : Circumference
    {
        private int h;

        public Cone() 
        {
            h = 9;
        }

        public Cone(int h)
        {
            this.h = h;
        }

        public int HeightCo { get { return h; } set { h = value; } }

        public double VolumeCo()
        {
            return 1 / 3.0 * Math.PI * Math.Pow(Radius, 2) * h;
        }
    }
}