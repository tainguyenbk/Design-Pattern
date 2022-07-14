using System;
using FactoryMethod.AbstractFactory;
using FactoryMethod.Animal;
using FactoryMethod.Factory;

namespace FactoryMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            IAnimalFactory factory;

            Random random = new Random();
            int type = random.Next(0, 2);

            if (type == 0)
            {
                factory = new FourLegsAnimalFactory();
            }
            else
            {
                factory = new TwoLegsAnimalFactory();
            }

            Console.WriteLine(factory.CreateAnimal().getName());
            Console.WriteLine(factory.CreateAnimal().getName());
            Console.WriteLine(factory.CreateAnimal().getName());
            Console.WriteLine(factory.CreateAnimal().getName());
            Console.WriteLine(factory.CreateAnimal().getName());
        }
    }
}
