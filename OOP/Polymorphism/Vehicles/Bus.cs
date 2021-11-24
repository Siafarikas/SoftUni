using System;
using System.Collections.Generic;
using System.Text;

namespace Vehicles 
{
    public class Bus : Vehicle
    {
        private const double DefaultAirConditionerFuelConsumption = 1.4;

        private double fuelConsumption;
        public bool HasAirConditioner { get; set; }
        public Bus(double fuelQuantity, double fuelConsumption, double tankCapacity)
            :base(fuelQuantity, fuelConsumption, tankCapacity)
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
                    this.FuelQuantity += fuelAmount;
                }
            }
        }

        public void DriveEmpty(double distance)
        {
            this.FuelConsumption = this.FuelConsumption - DefaultAirConditionerFuelConsumption;
            this.FuelQuantity -= distance * this.FuelConsumption;
        }
    }
}
