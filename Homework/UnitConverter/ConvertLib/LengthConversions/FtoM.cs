using System;

namespace UnitConverter.ConvertLib
{
    public class FtoM
    {
        public static double FtoMConvertLength(double initLength) {
            double newLength = initLength * 0.3048;
            return newLength;
        }
    }
}
