using System;

namespace UnitConverter.ConvertLib
{
    public class KtoP
    {
        public static double KtoPConvertMass(double initMass) {
            double newMass = initMass / 0.45359237;
            return newMass;
        }
    }
}