using System;
using System.Collections.Generic;
using System.Text;

namespace VehiclesNew.Models
{
    public class Truck : Vehicle
    {
        private const double DefaultAirCondFuelCons = 1.6;
        private const double RefuelLeak = 0.95;

        public Truck(double fuelQuantity, double fuelConsumption, double tankCapacity, bool hasAirCond = true)
            : base(fuelQuantity, fuelConsumption, tankCapacity, hasAirCond)
        {

        }

        public override double AirCondFuelCons => DefaultAirCondFuelCons;

        public override void Refuel(double liters)
        {
            if (liters <= 0)
            {
                Console.WriteLine("Fuel must be a positive number");
            }
            else
            {
                if (liters + FuelQuantity > TankCapacity)
                {
                    Console.WriteLine($"Cannot fit {liters} fuel in the tank");
                }
                else
                {
                    FuelQuantity += liters * RefuelLeak;
                }
            }
        }
    }
}
