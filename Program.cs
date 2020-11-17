using System;
using System.Collections.Generic;

namespace AlienLifeSimulator
{
    public static class CosmicNames 
    {
        public static List<string> PlanetsNames = new List<string>() {"KEPLER", "SAGAN"};
        public static List<string> StarsNames = new List<string>();
    }
    public class Program
    {
        static void Main(string[] args)
        {
            Galaxy galaxy = new Galaxy();
            Console.ReadLine();
        }
    }
    public class Galaxy 
    {
        public long NumStars = 100; // 300,000,000,000 - 500,000,000,000 stars in our Milky Way galaxy
        public string Name = "Simulated Galaxy";

        public Galaxy() 
        {
            GenerateStars();
        }

        private void GenerateStars() 
        {
            // Generate planets and cosmis stuff
            for (long i = 1; i <= NumStars; i++)
            {
                Star newStar = new Star();
                newStar.Index = i;
                newStar.Name = "star-" + Guid.NewGuid().ToString();
                System.Console.WriteLine($"\nNew STAR generated: {newStar.Index}-{newStar.Name}");
            }
        }
    }    
    public class Star
    {
        private int MAX_PLANETS = 6; 
        public long Index {get; set;}
        public string Name {get; set;}
        public string Type { get; set; }
        public int Age {get; set;}
        public int Mass {get; set; }
        public int Density {get; set;}
        public int Temperature {get; set;}
        public bool CanHoldLife {get; set;}

        Random random = new Random();
        public Star() 
        {
            GeneratePlanets();
        }
        private void GeneratePlanets() 
        {
            for (int i = 1; i <= random.Next(0, MAX_PLANETS); i++) 
            {
                Planet newPlanet = new Planet();
                newPlanet.Index = i;
                newPlanet.Name = "planet-" + Guid.NewGuid().ToString();
                System.Console.WriteLine($"\nNew PLANET generated: {newPlanet.Index}-{newPlanet.Name}");
            }
        }
    }
    public class Planet 
    {
        public long Index { get; set; }
        public string Name {get; set;}
        public bool CanHoldLife {get; set;}
        
        private int Mass {get; set;}
        private int Density {get; set;}
        private int Atmosphere {get; set;}

        private void GenerateLife() 
        {
            // Generate Life if suitable conditions are available
        }
    }
    
}

