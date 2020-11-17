using System;

namespace AlienLifeSimulator
{
    public class Program
    {
        static void Main(string[] args)
        {
            
        }
    }
    public class Galaxy 
    {
        public long NumStars = 100; // trecientas mil millones de estrellas como META
        public string Name = "Galaxia Zero";

        void Generate() 
        {
            // Generate planets and cosmis stuff
            for (long i = 1; i <= NumStars; i++)
            {
                Planet newplanet = new Planet();
            }
        }
    }    
    public class Planet 
    {
        public int Index { get; set; }
        public string Name {get; set;}

        private void Generate() 
        {

        }
    }
}

