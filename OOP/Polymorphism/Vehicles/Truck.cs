using System;

namespace Vehicles
{
    public class Truck : Vehicle
    {
        private double fuelConsumption;
        private const double DefaultAirConditionerFuelConsumption = 1.6;
        private const double RefuelLeakPercentage = 0.95;

        public Truck(double fuelQuantity, double fuelConsumption, double tankCapacity)
            : base(fuelQuantity, fuelConsumption, tankCapacity)
        {

        }

        public override double FuelConsumption
        {
            get
            {
                return fuelConsumption;
            }
            set
            {
                fuelConsumption = value + DefaultAirConditionerFuelConsumption;
            }
        }

        public override void Refuel(double fuelAmount)
        {
            if (fuelAmount <= 0)
            {
                Console.WriteLine("Fuel must be a positive number");
            }
            else
            {
                if (fuelAmount > TankCapacity)
                {
                    Console.WriteLine($"Cannot fit {fuelAmount} fuel in the tank");
                }
                else
                {
                    this.FuelQuantity += fuelAmount * DefaultAirConditionerFuelConsumption;
                }
            }
        }
    }
}
