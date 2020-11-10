using System;

namespace AlienLifeSimulator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
    public enum StarType 
    {
        one, two, three
    }
    public class Star 
    {
        public float mass { get; set; }
        public StarType type {get; set;}

    }
    
}
