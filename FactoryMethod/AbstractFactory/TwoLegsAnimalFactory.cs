using FactoryMethod.Animal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod.AbstractFactory
{
    class TwoLegsAnimalFactory : AbstractAnimalFactory
    {
        public override IAnimal CreateAnimal()
        {
            Random random = new Random();
            int type = random.Next(0, 2);
            if (type == 0)
            {
                return new Chicken();
            }
            else
            { 
                return new Duck();
            }
        }
    }
}
