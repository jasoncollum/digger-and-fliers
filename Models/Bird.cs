using System;

namespace diggers_and_fliers
{
    public class Bird : IGround, IAir, IDigger, IWater
    {
        public void Fly()
        {
            Console.WriteLine("Bird is flying...");
        }

        public void Move()
        {
            Console.WriteLine("Bird is walking...");
        }

        public void Swim()
        {
            Console.WriteLine("Bird is diving for fish...");
        }

        public void Burrow()
        {
            Console.WriteLine("Bird is burrowing for worms...");
        }
    }
}