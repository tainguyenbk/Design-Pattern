using FactoryMethod1.Car;
using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethod1.Transportor
{
    public abstract class Transportor : ICar
    {
        public abstract ICar CreateCar();
        public string CreateVehicle()
        {
            var car = CreateCar();

            var result = string.Format("Transport: The '{0}' has been created", car.CreateVehicle());

            return result;
        }
    }
}
