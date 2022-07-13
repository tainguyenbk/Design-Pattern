using FactoryMethod1.Transportor;
using System;

namespace FactoryMethod1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello Transportation App!");

            var truck = new TruckCreator();
            Console.WriteLine("{0}", truck.CreateVehicle());

            var bus = new BusCreator();
            Console.WriteLine("{0}", bus.CreateVehicle());
        }
    }
}
