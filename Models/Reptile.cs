using System;

namespace diggers_and_fliers
{
    public class Reptile : IGround, IWater, IDigger
    {
        public bool IsPoisonous { get; set; }
        public void Move()
        {
            Console.WriteLine("It's moving around...");
        }

        public void Swim()
        {
            Console.WriteLine("Reptile is swimming...");
        }

        public void Burrow()
        {
            Console.WriteLine("Reptile is burrowing...");
        }

    }
}