using InteractiveAnimals.Core.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace InteractiveAnimals.Core.Interfaces
{
    public interface IAnimalFactory
    {
        Animal GetAnimal(int numOfAnimal);
    }
}
