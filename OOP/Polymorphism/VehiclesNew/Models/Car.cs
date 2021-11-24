using System;
using System.Collections.Generic;
using System.Text;

namespace VehiclesNew.Models
{
    public class Car : Vehicle
    {
        private const double DefaultAirCondFuelCons= 0.9;
        public Car(double fuelQuantity, double fuelConsumption, double tankCapacity, bool hasAirCond = true) :
            base(fuelQuantity, fuelConsumption, tankCapacity, hasAirCond)
        {

        }

        public override double AirCondFuelCons => DefaultAirCondFuelCons;


    }
}
