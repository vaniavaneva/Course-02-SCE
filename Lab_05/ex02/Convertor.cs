using System;

namespace ex02
{
    public class Convertor
    {
        public static double Mps(double speed)
        {
            return speed * 3.6;
        }

        public static double Kph(double speed)
        {
            return speed / 3.6;
        }
    }
}
