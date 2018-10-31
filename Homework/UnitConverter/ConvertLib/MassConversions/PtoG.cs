using System;

namespace UnitConverter.ConvertLib
{
    public class PtoG
    {
        public static double PtoGConvertMass(double initMass) {
            double newMass = initMass / 0.0022046;
            return newMass;
        }
    }
}