using System;

namespace UnitConverter.ConvertLib
{
    public class FtoK
    {
        public static double FtoKConvertTemp(double initTemp) {
            double newTemp = (initTemp + 459.67) * (5.0/9.0);
            return newTemp;
        }
    }
}
