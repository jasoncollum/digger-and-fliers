using System;

namespace diggers_and_fliers
{
    public class Insect : IGround, IDigger
    {
        public void Move()
        {
            Console.WriteLine("Bug is running...");
        }

        public void Burrow()
        {
            Console.WriteLine("Bug is burrowing to escape the hungry bird...");
        }
    }
}