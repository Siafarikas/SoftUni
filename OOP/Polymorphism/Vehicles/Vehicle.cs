using System;
using System.Collections.Generic;
using System.Text;

namespace Vehicles
{
    public abstract class Vehicle
    {
        public double FuelQuantity { get; set; }
        public abstract double FuelConsumption { get; set; }
        public double TankCapacity { get; set; }

        protected Vehicle(double fuelQuantity, double fuelConsumption, double tankCapacity)
        {
            this.FuelQuantity = fuelQuantity;
            this.FuelConsumption = fuelConsumption;
            this.TankCapacity = tankCapacity;
        }
        public void Drive(double distance)
        {
            this.FuelQuantity -= distance * this.FuelConsumption;
        }

        public abstract void Refuel(double fuelAmount);
    }
}
