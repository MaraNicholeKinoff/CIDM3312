using System;

namespace UnitConverter.ConvertLib
{
    public class MtoF
    {
        public static double MtoFConvertLength(double initLength) {
            double newLength = initLength / 0.3048;
            return newLength;
        }
    }
}
