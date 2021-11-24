using System;
using System.Collections.Generic;
using System.Text;

namespace Vehicles
{
    public class Car : Vehicle
    {
        private double fuelConsumption;
        private const double DefaultAirConditionerFuelConsumption = 0.9;

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

        public Car(double fuelQuantity, double fuelConsumption, double tankCapacity)
            : base(fuelQuantity, fuelConsumption, tankCapacity)
        {

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
                    this.FuelQuantity += fuelAmount;
                }
            }
        }

    }
}
