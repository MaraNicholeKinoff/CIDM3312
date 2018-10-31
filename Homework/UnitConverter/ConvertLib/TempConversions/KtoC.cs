using System;

namespace UnitConverter.ConvertLib
{
    public class KtoC
    {
        public static double KtoCConvertTemp(double initTemp) {
            double newTemp = initTemp - 273.15;
            return newTemp;
        }
    }
}
