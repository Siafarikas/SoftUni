using System;
using System.Collections.Generic;
using System.Text;

namespace VehiclesNew.Models
{
    public class Bus : Vehicle
    {
        private const double DefaultAirCondFuelCons = 1.4;

        public Bus(double fuelQuantity, double fuelConsumption, double tankCapacity, bool hasAirCond = true)
            : base(fuelQuantity, fuelConsumption, tankCapacity, hasAirCond)
        {

        }

        public override double AirCondFuelCons => DefaultAirCondFuelCons;

        public void DriveEmpty(double distance)
        {
            double spentFuel = distance * FuelConsumption;

            if (FuelQuantity < spentFuel)
            {
                Console.WriteLine($"Bus needs refueling");
            }
            else
            {
                FuelQuantity -= spentFuel;
            }
        }
    }
}
