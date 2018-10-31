using System;

namespace UnitConverter.ConvertLib
{
    public class CtoK
    {
        public static double CtoKConvertTemp(double initTemp) {
            double newTemp = initTemp + 273.15;
            return newTemp;
        }
    }
}
