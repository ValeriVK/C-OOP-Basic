using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicles
{
    public class Truck : Vehicle
    {

        private const double AcOnMod = 1.6;
        private const double FuelLost = 0.95;
        public Truck(double fuelQuantity, double fuelConsumption, double tankCapacity) 
            : base(fuelQuantity, fuelConsumption + AcOnMod, tankCapacity)
        {}

        public override void Refuel(double fuelAmount)
        {
            base.Refuel(fuelAmount * FuelLost);
        }
    }
}
