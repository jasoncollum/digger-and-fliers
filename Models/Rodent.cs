using System;

namespace diggers_and_fliers
{
    public class Rodent : IGround, IDigger
    {
        public void Move()
        {
            Console.WriteLine("It's moving...");
        }

        public void Burrow()
        {
            Console.WriteLine("Rodent is burrowing...");
        }
    }
}