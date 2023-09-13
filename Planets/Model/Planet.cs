using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Planets.Model
{
    internal class Planet
    {
        // Variables
        #region Variables
        private int density;
        private int meanTemperature;
        private bool ringSystem;
        private sbyte numberOfMoons;
        private float mass;
        private float distanceFromSon;
        private float orbitalPeriod;
        private float orbitalVelocity;
        private float gravity;
        private double rotationPeriod;
        private double diameter;
        private double lengthOfDay;
        private string name;
        #endregion

        // Properties
        #region Properties
        public int Density
        {
            get { return density; }
            set { density = value; }
        }

        public int MeanTemperature
        {
            get { return meanTemperature; }
            set { meanTemperature = value; }
        }

        public bool RingSystem
        {
            get { return ringSystem; }
            set { ringSystem = value; }
        }

        public sbyte NumberOfMoons
        {
            get { return numberOfMoons; }
            set { numberOfMoons = value; }
        }

        public float Mass
        {
            get { return mass; }
            set { mass = value; }
        }
        public float DistanceFromSon
        { 
            get { return distanceFromSon; } 
            set { distanceFromSon = value; } 
        }
        public float OrbitalPeriod
        {
            get { return orbitalPeriod; }
            set { orbitalPeriod = value; }
        }
        public float OrbitalVelocity
        {
            get { return orbitalVelocity; }
            set { orbitalVelocity = value; }
        }

        public float Gravity
        {
            get { return gravity; }
            set { gravity = value; }
        }

        public double RotationPeriod
        {
            get { return rotationPeriod; }
            set { rotationPeriod = value; }
        }

        public double Diameter
        {
            get { return diameter; }
            set { diameter = value; }
        }

        public double LengthOfDay
        {
            get { return lengthOfDay; }
            set { lengthOfDay = value; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        #endregion

        #region Planet List
        public List<Planet> planets = new List<Planet>();
        public List<Planet> planetsMeanTemperature = new List<Planet>();
        public List<Planet> planetsDiameter = new List<Planet>();
        #endregion
    }
}