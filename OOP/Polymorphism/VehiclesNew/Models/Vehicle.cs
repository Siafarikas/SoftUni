using System;
using System.Collections.Generic;
using System.Text;

namespace VehiclesNew
{
    public abstract class Vehicle : IVehicle
    {
        protected Vehicle(double fuelQuantity, double fuelConsumption, double tankCapacity, bool hasAirCond = true)
        {
            FuelQuantity = fuelQuantity;
            FuelConsumption = fuelConsumption;
            HasAirCond = hasAirCond;
            TankCapacity = tankCapacity;
        }
        public double FuelQuantity { get; protected set; }

        public double FuelConsumption { get; }

        public bool HasAirCond { get; }

        public abstract double AirCondFuelCons { get; }

        public double TankCapacity { get; }

        public bool Drive(double distance)
        {
            double spentFuel = distance * FuelConsumption;
            if (HasAirCond)
            {
                spentFuel += AirCondFuelCons * distance;
            }

            if (FuelQuantity < spentFuel)
            {
                return false;
            }
            FuelQuantity -= spentFuel;
            return true;
        }
        public virtual void Refuel(double liters)
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
                    FuelQuantity += liters;
                }
            }
        }

        public override string ToString()
        {
            return $"{GetType().Name}: {FuelQuantity:f2}";
        }
    }
}
