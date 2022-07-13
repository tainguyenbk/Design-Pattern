using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethod1.Car
{
    public class TruckObj : ICar
    {
        public string CreateVehicle()
        {
            return this.ToString();
        }
    }
}
