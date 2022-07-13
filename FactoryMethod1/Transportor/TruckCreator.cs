using FactoryMethod1.Car;
using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethod1.Transportor
{
    public class TruckCreator : Transportor
    {
        public override ICar CreateCar()
        {
            return new TruckObj();
        }
    }
}
