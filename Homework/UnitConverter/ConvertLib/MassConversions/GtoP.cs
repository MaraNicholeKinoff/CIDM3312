using System;

namespace UnitConverter.ConvertLib
{
    public class GtoP
    {
        public static double GtoPConvertMass(double initMass) {
            double newMass = initMass / 453.59237;
            return newMass;
        }
    }
}