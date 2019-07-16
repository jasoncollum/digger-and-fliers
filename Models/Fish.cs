using System;

namespace diggers_and_fliers
{
    public class Fish : IWater
    {
        public void Swim()
        {
            Console.WriteLine("Fish is swimming...");
        }
    }
}