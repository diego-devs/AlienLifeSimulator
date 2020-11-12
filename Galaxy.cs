using System;

namespace AlienLifeSimulator
{
    class Galaxy
    {
        public int starsNum { get; set; }
        public int planetsNum {get; set;}

        public Generate(int starsNum) 
        {
            // Generate 300,000,000,000 star systems
            for (int i = 0; i < starsNum; i++)
            {
                var newStarSystem = new Star();   
            }
        }
    }
    class Star()
    {
        public int Star { get; set; }
        public string Name {get; set;}
        public Star () 
        {
            Generate();
        }
        void Generate() 
        {

        }
    }
    
}
