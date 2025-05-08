using System;

namespace ex01
{
    public class Cylinder : Circumference
    {
        private int h;

        public Cylinder()
        {
            h = 5;
        }

        public Cylinder(int h)
        {
            this.h = h;
        }

        public int HeightCy { get { return h; } set { h = value; } }

        public double VolumeCy()
        {
            return Math.PI * Math.Pow(Radius, 2) * h;
        }
    }
}
