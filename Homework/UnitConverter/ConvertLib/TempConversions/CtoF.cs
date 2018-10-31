using System;

namespace UnitConverter.ConvertLib
{
    public class CtoF
    {
        public static double CtoFConvertTemp(double initTemp) {
            double newTemp = (initTemp * 1.8) + 32.0;
            return newTemp;
        }
    }
}
