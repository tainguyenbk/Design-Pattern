using FactoryMethod.Animal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod.AbstractFactory
{
    internal class FourLegsAnimalFactory : AbstractAnimalFactory
    {
        public override IAnimal CreateAnimal()
        {
            Random random = new Random();
            int type = random.Next(0, 1);
            if (type == 0)
            {
                return new Dog();
            }
            else 
            {
                return new Cat();
            }
        }
    }
}
