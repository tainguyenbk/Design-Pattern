using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod.Animal
{
    abstract class FourLegsAnimal : IAnimal
    {
        public abstract string getName();
    }
}
