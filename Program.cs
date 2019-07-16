using System;
using System.Collections.Generic;

namespace diggers_and_fliers
{
    class Program
    {
        static void Main(string[] args)
        {
            var Parakeet = new Bird();
            var Terrapin = new Reptile();
            var TimberRattlesnake = new Reptile() { IsPoisonous = true };
            var Mouse = new Mammal();
            var Ant = new Insect();
            var Finch = new Bird();
            var BettaFish = new Fish();
            var CopperheadSnake = new Reptile() { IsPoisonous = true };
            var Gerbil = new Mammal();

            List<IWater> swimmers = new List<IWater>(){
                Terrapin, TimberRattlesnake, BettaFish, CopperheadSnake
            };

            List<IAir> fliers = new List<IAir>(){
                Parakeet, Finch
            };

            List<IGround> groundDwellers = new List<IGround>(){
                TimberRattlesnake, Mouse, Ant, CopperheadSnake, Gerbil
            };

            List<IDigger> diggers = new List<IDigger>(){
                Terrapin, Ant
            };

        }
    }
}
