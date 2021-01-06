using InteractiveAnimals.Core.Interfaces;
using InteractiveAnimals.Core.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace InteractiveAnimals.Core.Infrastructure
{
    public class SimpleAnimalFactory : IAnimalFactory
    {
        private int currentNumOfAnimal;
        private Animal animal;
        public Animal GetAnimal(int numOfAnimal)
        {
            if (currentNumOfAnimal != numOfAnimal)
            {
                currentNumOfAnimal = numOfAnimal;

                switch (numOfAnimal)
                {
                    case 0:
                        animal = new Bunny();
                        break;
                    case 1:
                        animal = new Snake();
                        break;
                    case 2:
                        animal = new Wolf();
                        break;
                    default:
                        animal = new Animal();
                        break;
                }
            }

            return animal;
        }
    }
}
