using System;
using System.Collections.Generic;
using System.Text;

namespace VehiclesNew
{
    public interface IVehicle
    {
        double FuelQuantity { get;}
        double FuelConsumption { get; }
        bool HasAirCond { get; }
        double AirCondFuelCons { get; }
        double TankCapacity { get; }
        bool Drive(double distance);

        void Refuel(double liters);

    }
}
