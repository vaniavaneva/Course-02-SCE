using System;

namespace ex01
{
    class Rectangle
    {
        private int width, heigth;
        
        public Rectangle()
        {
            width = heigth = 0;
        }
        
        public Rectangle(int width, int heigth)
        {
            this.width = width;
            this.heigth = heigth;
        }
        
        public int Width
        {
            set { width = value; }
        }

        public int Heigth
        {
            set { heigth = value; }
        }

        public int Area
        {
            get { return width * heigth; }
        }
    }
}
