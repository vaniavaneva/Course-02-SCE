using System;

namespace extra_ex02
{
    class Car
    {
        private int power, year, eco;
        private string municipalty;
        public Car()
        {
            power = year = eco = 0;
            municipalty = "";
        }
        public Car(int power, int year, int eco, string municipalty)
        {
            this.power = power;
            this.year = year;
            this.eco = eco;
            this.municipalty = municipalty;
        }
        public int Power
        {
            get { return power; }
            set { power = value; }
        }
        public int Year
        {
            get { return year; }
            set { year = value; }
        }
        public int Eco
        {
            get { return eco; }
            set { eco = value; }
        }
        public string Municipalty
        {
            get { return municipalty; }
            set { municipalty = value; }
        }
        public void Input()
        {
            Console.Write("Enter power: ");
            power = int.Parse(Console.ReadLine());
            Console.Write("Enter year: ");
            year = int.Parse(Console.ReadLine());
            Console.Write("Enter eco category: ");
            eco = int.Parse(Console.ReadLine());
            Console.Write("Enter municipalty: ");
            municipalty = Console.ReadLine();
        }
        public double Tax()
        {
            double kW = power * 0.7457;
            double baseTaxPerKW;

            if (kW <= 55)
                baseTaxPerKW = 0.34;
            else if (kW <= 74)
                baseTaxPerKW = 0.54;
            else if (kW <= 110)
                baseTaxPerKW = 1.10;
            else if (kW <= 150)
                baseTaxPerKW = 1.23;
            else if (kW <= 245)
                baseTaxPerKW = 1.60;
            else
                baseTaxPerKW = 2.14;

            int currentYear = DateTime.Now.Year;
            int age = currentYear - year;
            double ageCoefficient;
            
            if (age <= 5)
                ageCoefficient = 2.8;
            else if (age <= 14)
                ageCoefficient = 1.5;
            else
                ageCoefficient = 1.0;
            double ecoCoefficient;
            
            switch (eco)
            {
                case 1:
                    ecoCoefficient = 1.0;
                    break;
                case 2:
                    ecoCoefficient = 0.8;
                    break;
                case 3:
                    ecoCoefficient = 0.6;
                    break;
                case 4:
                    ecoCoefficient = 0.4;
                    break;
                case 5:
                    ecoCoefficient = 0.2;
                    break;
                default:
                    ecoCoefficient = 1.0;
                    break;
            }

            return kW * baseTaxPerKW * ageCoefficient * ecoCoefficient;
        }
    }
}
