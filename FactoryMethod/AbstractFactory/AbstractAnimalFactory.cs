using FactoryMethod.Animal;
using FactoryMethod.Factory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod.AbstractFactory
{
    abstract class AbstractAnimalFactory : IAnimalFactory
    {
        public abstract IAnimal CreateAnimal();
    }
}
