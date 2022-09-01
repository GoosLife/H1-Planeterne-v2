using System;
using System.Collections.Generic;

namespace H1_Planeterne_v2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Create planet objects
            Mercury mercury = new Mercury();
            Earth earth = new Earth();
            Mars mars = new Mars();
            Jupiter jupiter = new Jupiter();
            Saturn saturn = new Saturn();
            Uranus uranus = new Uranus();
            Neptune neptune = new Neptune();
            Pluto pluto = new Pluto();

            // Create list of planets with the planets specified in the assignment.
            List<IPlanet> planets = new List<IPlanet>()
            {
                mercury,
                earth,
                mars,
                jupiter,
                saturn,
                uranus,
                neptune,
                pluto
            };

            // Output list
            Console.WriteLine("Outputting list:\n");
            foreach (IPlanet planet in planets)
            {
                Console.WriteLine(planet.Name);
            }

            // Insert venus
            Venus venus = new Venus();
            planets.Insert(1, venus);

            // Output list with Venus
            Console.WriteLine("\nOutputting list with Venus:\n");
            foreach (IPlanet planet in planets)
            {
                Console.WriteLine(planet.Name);
            }

            // Remove Pluto from list
            planets.Remove(planets.Find(p => p.Name == "Pluto"));

            // Put Pluto back
            planets.Add(pluto);

            // Output number of elements in the list
            Console.WriteLine(planets.Count);

            // Create new list with all planets with all planets with mean temperature below 0
            List<IPlanet> planetsWithTempBelowZero = new List<IPlanet>();
            
            foreach (IPlanet p in planets)
            {
                if (p.HasMeanTemperatureBelow(0))
                    planetsWithTempBelowZero.Add(p);
            }

            // Create a new list with all planets with diameter above 10000 km, but below 50000 km
            List<IPlanet> planetsInDiameterRange = new List<IPlanet>();
            
            foreach (IPlanet p in planets)
            {
                if (p.HasDiameterInRange(10000, 50000))
                    planetsInDiameterRange.Add(p);
            }

            // Remove all elements from list
            planetsInDiameterRange.Clear();
            planetsWithTempBelowZero.Clear();
            planets.Clear();

            Console.ReadKey();
        }
    }
}