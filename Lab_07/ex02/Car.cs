using System;

namespace ex02
{
    class Car
    {
        private string brand, color, regNum;

        public Car()
        {
        }

        public Car(string brand, string color, string regNum)
        {
            this.brand = brand;
            this.color = color;
            this.regNum = regNum;
        }

        public string Brand
        {
            get { return brand; }
            set { brand = value; }  
        }

        public string Color
        {
            get { return color; }
            set { color = value; }
        }

        public string RegNum
        {
            get { return regNum; }
            set { regNum = value; }
        }

        public void Output()
        {
            Console.WriteLine($"Brand: {brand}");
            Console.WriteLine($"Color: {color}");
            Console.WriteLine($"Registration number: {regNum}");
        }
    }
}
