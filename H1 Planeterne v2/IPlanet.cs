using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H1_Planeterne_v2
{
    // This interface would've worked much better as a superclass,
    // as all planets must have the same functionality
    internal interface IPlanet
    {
        string Name { get; }
        float Mass { get; }
        int Diameter { get; }
        int Density { get; }
        float Gravity { get; }
        float RotationPeriod { get; }
        float LengthOfDay { get; }
        float DistanceFromSun { get; }
        float OrbitalPeriod { get; }
        float OrbitalVelocity { get; }
        int MeanTemperature { get; }
        int NumberOfMoons { get; }
        bool IsRingsystem { get; }

        bool HasMeanTemperatureBelow(int temperature);
        bool HasDiameterInRange(int minDiameter, int maxDiameter);
    }
}