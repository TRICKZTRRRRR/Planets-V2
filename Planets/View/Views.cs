using Planets.Model;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Planets.View
{
    internal class Views
    {

        #region Planet Outputs
        public void PlanetOutputs(Planet planets)
        {
            Console.WriteLine($"Name: {planets.Name} \n" +
                $"Mass: {planets.Mass} \n" +
                $"Diameter: {planets.Diameter} \n" +
                $"Density: {planets.Density} \n" +
                $"Gravity: {planets.Gravity} \n" +
                $"Rotation Period: {planets.RotationPeriod} \n" +
                $"Length of Day: {planets.LengthOfDay} \n" +
                $"Distance from Sun: {planets.DistanceFromSon} \n" +
                $"Orbital Period: {planets.OrbitalPeriod} \n" +
                $"Orbital Velocity: {planets.OrbitalVelocity} \n" +
                $"Mean Temperature: {planets.MeanTemperature} \n" +
                $"Number of Moons: {planets.NumberOfMoons} \n" +
                $"Ring System: {planets.RingSystem} \n");

        }
        #endregion

        #region Count
        public void PlanetCount(int count)
        {
            Console.WriteLine($"Total Planets: {count}");
        }
        #endregion

        #region Temperature
        public void TemperatureMessage()
        {
            Console.WriteLine("\nPlanets with mean temperature below 0°C:");
        }

        public void Temperature(string planet)
        {
            Console.WriteLine(planet);
        }
        #endregion

        #region Diamter

        public void DiameterMessage()
        {
            Console.WriteLine("\nPlanets with diameter between 10000 km and 50000 km");
        }

        public void DiameterList(string planet)
        {
            Console.WriteLine(planet);
        }


        #endregion

        #region Remove planets
        public void RemovePlanets()
        {
            Console.Clear();
            Console.WriteLine("You removed all the planets");
        }
        #endregion

        #region ReadLine
        public void ReadOut() 
        {
            Console.ReadLine();
        }
        #endregion
    }
}
