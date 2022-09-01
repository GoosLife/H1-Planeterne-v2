using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H1_Planeterne_v2
{
    internal class Uranus : IPlanet
    {
        private string name;
        private float mass;
        private int diameter;
        private int density;
        private float gravity;
        private float rotationPeriod;
        private float lengthOfDay;
        private float distanceFromSun;
        private float orbitalPeriod;
        private float orbitalVelocity;
        private int meanTemperature;
        private int numberOfMoons;
        private bool isRingsystem;

        public string Name { get => name; }
        public float Mass { get => mass; }
        public int Diameter { get => diameter; }
        public int Density { get => density; }
        public float Gravity { get => gravity; }
        public float RotationPeriod { get => rotationPeriod; }
        public float LengthOfDay { get => lengthOfDay; }
        public float DistanceFromSun { get => distanceFromSun; }
        public float OrbitalPeriod { get => orbitalPeriod; }
        public float OrbitalVelocity { get => orbitalVelocity; }
        public int MeanTemperature { get => meanTemperature; }
        public int NumberOfMoons { get => numberOfMoons; }
        public bool IsRingsystem { get => isRingsystem; }

        public Uranus()
        {
            this.name = "Uranus";
            GetData();
        }

        /// <summary>
        /// Reads data for fields from text file of the same name
        /// </summary>
        private void GetData()
        {
            string data = File.ReadAllText(Directory.GetCurrentDirectory() + @"\" + Name + ".txt");
            string[] splitData = data.Split(",");

            mass = float.Parse(splitData[0]);
            diameter = int.Parse(splitData[1]);
            density = int.Parse(splitData[2]);
            gravity = float.Parse(splitData[3]);
            rotationPeriod = float.Parse(splitData[4]);
            lengthOfDay = float.Parse(splitData[5]);
            distanceFromSun = float.Parse(splitData[6]);
            orbitalPeriod = float.Parse(splitData[7]);
            orbitalVelocity = float.Parse(splitData[8]);
            meanTemperature = int.Parse(splitData[9]);
            numberOfMoons = int.Parse(splitData[10]);
            isRingsystem = bool.Parse(splitData[11]);
        }

        public bool HasMeanTemperatureBelow(int temperature)
        {
            return meanTemperature < temperature;
        }

        public bool HasDiameterInRange(int minDiameter, int maxDiameter)
        {
            return this.diameter > minDiameter && this.diameter < maxDiameter;
        }
    }
}
