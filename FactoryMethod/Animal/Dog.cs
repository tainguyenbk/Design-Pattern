using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod.Animal
{
    class Dog : FourLegsAnimal
    {
        public override string getName()
        {
            return "I am Dog";
        }
    }
}
