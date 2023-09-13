using Planets.Model;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Planets.Controller
{
    internal class Controller
    {
        #region Import
        Planet planet = new Planet();
        View.Views OutputView = new View.Views();
        #endregion

        #region Controller
        public void MainController()
        {
            Controllers();
        }
        #endregion

        #region Output maker
        void OutputAll()
        {
            foreach (Planet allPlanets in planet.planets)
            {
                OutputView.PlanetOutputs(allPlanets);
            }
            OutputView.PlanetCount(planet.planets.Count);

        }
        #endregion

        #region TaskTwo
        void Tasks()
        {

            // Creates 8 planets, inside the planets list
            for (int i = 0; i < 8; i++)
            {
                planet.planets.Add(planet);
                planet.planets[i] = new Planet();
            }

            // Creates the 8 planets
            //Mercury
            planet.planets[0].Name = "Mercury";
            planet.planets[0].Mass = 0.330f;
            planet.planets[0].Diameter = 4879;
            planet.planets[0].Density = 5427;
            planet.planets[0].Gravity = 3.7f;
            planet.planets[0].RotationPeriod = 1407.6;
            planet.planets[0].LengthOfDay = 4222.6;
            planet.planets[0].DistanceFromSon = 57.9f;
            planet.planets[0].OrbitalPeriod = 88.0f;
            planet.planets[0].OrbitalVelocity = 47.4f;
            planet.planets[0].MeanTemperature = 167;
            planet.planets[0].NumberOfMoons = 0;
            planet.planets[0].RingSystem = false;

            // Earth
            planet.planets[1].Name = "Earth";
            planet.planets[1].Mass = 5.97f;
            planet.planets[1].Diameter = 12756;
            planet.planets[1].Density = 5514;
            planet.planets[1].Gravity = 9.8f;
            planet.planets[1].RotationPeriod = 23.9;
            planet.planets[1].LengthOfDay = 24.0;
            planet.planets[1].DistanceFromSon = 149.6f;
            planet.planets[1].OrbitalPeriod = 365.2f;
            planet.planets[1].OrbitalVelocity = 29.8f;
            planet.planets[1].MeanTemperature = 15;
            planet.planets[1].NumberOfMoons = 1;
            planet.planets[1].RingSystem = false;

            // Mars
            planet.planets[2].Name = "Mars";
            planet.planets[2].Mass = 0.642f;
            planet.planets[2].Diameter = 6792;
            planet.planets[2].Density = 3933;
            planet.planets[2].Gravity = 3.7f;
            planet.planets[2].RotationPeriod = 24.6;
            planet.planets[2].LengthOfDay = 24.7;
            planet.planets[2].DistanceFromSon = 227.9f;
            planet.planets[2].OrbitalPeriod = 687;
            planet.planets[2].OrbitalVelocity = 24.1f;
            planet.planets[2].MeanTemperature = -65;
            planet.planets[2].NumberOfMoons = 2;
            planet.planets[2].RingSystem = false;

            // Jupiter
            planet.planets[3].Name = "Jupiter";
            planet.planets[3].Mass = 1898f;
            planet.planets[3].Diameter = 142984;
            planet.planets[3].Density = 1326;
            planet.planets[3].Gravity = 23.1f;
            planet.planets[3].RotationPeriod = 9.9;
            planet.planets[3].LengthOfDay = 9.9;
            planet.planets[3].DistanceFromSon = 778.6f;
            planet.planets[3].OrbitalPeriod = 4331;
            planet.planets[3].OrbitalVelocity = 13.1f;
            planet.planets[3].MeanTemperature = -110;
            planet.planets[3].NumberOfMoons = 67;
            planet.planets[3].RingSystem = true;

            // Saturn
            planet.planets[4].Name = "Saturn";
            planet.planets[4].Mass = 568;
            planet.planets[4].Diameter = 120536;
            planet.planets[4].Density = 687;
            planet.planets[4].Gravity = 9.0f;
            planet.planets[4].RotationPeriod = 10.7f;
            planet.planets[4].LengthOfDay = 10.7;
            planet.planets[4].DistanceFromSon = 1433.5f;
            planet.planets[4].OrbitalPeriod = 10747;
            planet.planets[4].OrbitalVelocity = 9.7f;
            planet.planets[4].MeanTemperature = -140;
            planet.planets[4].NumberOfMoons = 62;
            planet.planets[4].RingSystem = true;

            // Uranus
            planet.planets[5].Name = "Uranus";
            planet.planets[5].Mass = 86.8f;
            planet.planets[5].Diameter = 51118;
            planet.planets[5].Density = 1271;
            planet.planets[5].Gravity = 8.7f;
            planet.planets[5].RotationPeriod = -17.2;
            planet.planets[5].LengthOfDay = 17.2;
            planet.planets[5].DistanceFromSon = 2872.5f;
            planet.planets[5].OrbitalPeriod = 30589;
            planet.planets[5].OrbitalVelocity = 6.8f;
            planet.planets[5].MeanTemperature = -195;
            planet.planets[5].NumberOfMoons = 27;
            planet.planets[5].RingSystem = true;

            // Neptune
            planet.planets[6].Name = "Neptune";
            planet.planets[6].Mass = 102;
            planet.planets[6].Diameter = 49528;
            planet.planets[6].Density = 1638;
            planet.planets[6].Gravity = 11.0f;
            planet.planets[6].RotationPeriod = 16.1;
            planet.planets[6].LengthOfDay = 16.1;
            planet.planets[6].DistanceFromSon = 4495.1f;
            planet.planets[6].OrbitalPeriod = 59.8f;
            planet.planets[6].OrbitalVelocity = 5.4f;
            planet.planets[6].MeanTemperature = -200;
            planet.planets[6].NumberOfMoons = 14;
            planet.planets[6].RingSystem = true;

            // Pluto
            planet.planets[7].Name = "Pluto";
            planet.planets[7].Mass = 0.0146f;
            planet.planets[7].Diameter = 2370;
            planet.planets[7].Density = 2095;
            planet.planets[7].Gravity = 0.7f;
            planet.planets[7].RotationPeriod = -153.3f;
            planet.planets[7].LengthOfDay = 153.3;
            planet.planets[7].DistanceFromSon = 5906.4f;
            planet.planets[7].OrbitalPeriod = 90.56f;
            planet.planets[7].OrbitalVelocity = 4.7f;
            planet.planets[7].MeanTemperature = -225;
            planet.planets[7].NumberOfMoons = 5;
            planet.planets[7].RingSystem = false;
        }
        #endregion

        #region New Planet
        void NewPlanet()
        {
            // Venus
            planet.planets.Insert(1, planet);
            planet.planets[1] = new Planet();

            planet.planets[1].Name = "Venus";
            planet.planets[1].Mass = 4.87f;
            planet.planets[1].Diameter = 12104;
            planet.planets[1].Density = 5245;
            planet.planets[1].Gravity = 8.9f;
            planet.planets[1].RotationPeriod = -5832.5f;
            planet.planets[1].LengthOfDay = 2802.0f;
            planet.planets[1].DistanceFromSon = 108.2f;
            planet.planets[1].OrbitalPeriod = 224.7f;
            planet.planets[1].OrbitalVelocity = 35.0f;
            planet.planets[1].MeanTemperature = 464;
            planet.planets[1].NumberOfMoons = 0;
            planet.planets[1].RingSystem = false;

            // Pluto
            planet.planets.Add(planet);
            Planet pluto = planet.planets.Last();

            pluto.Name = "Pluto";
            pluto.Mass = 0.0146f;
            pluto.Diameter = 2370;
            pluto.Density = 2095;
            pluto.Gravity = 0.7f;
            pluto.RotationPeriod = -153.3f;
            pluto.LengthOfDay = 153.3;
            pluto.DistanceFromSon = 5906.4f;
            pluto.OrbitalPeriod = 90.56f;
            pluto.OrbitalVelocity = 4.7f;
            pluto.MeanTemperature = -225;
            pluto.NumberOfMoons = 5;
            pluto.RingSystem = false;
        }
        #endregion

        #region Remove Planet
        void RemovePlanet()
        {
            for (int i = 0; i < planet.planets.Count; i++)
            {
                if (planet.planets[i].Name == "Pluto")
                {
                    planet.planets.Remove(planet.planets[i]);
                }
            }
        }
        #endregion

        #region MeanTemperature
        void MeanTemperatureList()
        {
            OutputView.TemperatureMessage();
            foreach (Planet planetTemp in planet.planets)
            {
                if (planetTemp.MeanTemperature < 0)
                {
                    OutputView.Temperature(planetTemp.Name);
                    planetTemp.planetsMeanTemperature.Add(planetTemp);
                }
            }
        }
        #endregion

        #region Diameter
        void DiameterList()
        {
            OutputView.DiameterMessage();
            foreach (Planet planetDia in planet.planets)
            {
                if (planetDia.Diameter > 10000 && planetDia.Diameter < 50000)
                {
                    OutputView.DiameterList(planetDia.Name);
                    planetDia.planetsDiameter.Add(planetDia);
                }
            }
        }
        #endregion

        #region Remove all Planets
        void RemoveAllPlanets()
        {
            OutputView.RemovePlanets();
            for (int i = 0; i < planet.planets.Count; i++)
            {
                planet.planets.Clear();
            }
        }
        

        #endregion

        #region Controllers
        void Controllers()
        {
            Tasks();
            RemovePlanet();
            NewPlanet();

            OutputAll();
            MeanTemperatureList();
            DiameterList();
            Thread.Sleep(5000);
            RemoveAllPlanets();
            Console.ReadKey();
        }
        #endregion
    }
}
