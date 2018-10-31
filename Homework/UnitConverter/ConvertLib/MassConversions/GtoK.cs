using System;

namespace UnitConverter.ConvertLib
{
    public class GtoK
    {
        public static double GtoKConvertMass(double initMass) {
            double newMass = initMass / 1000.00;
            return newMass;
        }
    }
}