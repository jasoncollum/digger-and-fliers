using System;

namespace diggers_and_fliers
{
    public class Mammal : IGround, IDigger
    {
        public void Move()
        {
            Console.WriteLine("It's moving...");
        }

        public void Burrow()
        {
            Console.WriteLine("Mammal is burrowing...");
        }
    }
}