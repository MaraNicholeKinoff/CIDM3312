using System;

namespace UnitConverter.ConvertLib
{
    public class KtoF
    {
        public static double KtoFConvertTemp(double initTemp) {
            double newTemp = (initTemp * 1.8) - 459.67;
            return newTemp;
        }
    }
}
