using System;

namespace UnitConverter.ConvertLib
{
    public class PtoK
    {
        public static double PtoKConvertMass(double initMass) {
            double newMass = initMass / 2.2046;
            return newMass;
        }
    }
}