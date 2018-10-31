using System;

namespace UnitConverter.ConvertLib
{
    public class FtoC
    {
        public static double FtoCConvertTemp(double initTemp) {
            double newTemp = (initTemp - 32.0) / 1.8;
            return newTemp;
        }
    }
}
