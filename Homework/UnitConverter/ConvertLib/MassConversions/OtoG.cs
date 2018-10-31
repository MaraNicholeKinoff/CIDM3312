using System;

namespace UnitConverter.ConvertLib
{
    public class OtoG
    {
        public static double OtoGConvertMass(double initMass) {
            double newMass = initMass / 0.035274;
            return newMass;
        }
    }
}