using System;

namespace Vehicles
{
    class Truck : Vehicle
    {
        public Truck(double fuelQty, double fuelConsumption, double tankCapacity)
            : base (fuelQty, fuelConsumption, tankCapacity)
        {
            this.FuelConsumption += 1.6;
        }

        public override string Drive(double distance)
        {
            if((distance * this.FuelConsumption) <= FuelQty)
            {
                this.FuelQty -= distance * this.FuelConsumption;
                return $"Truck travelled {distance} km";

            }
            else
            {
                return "Truck needs refueling";
            }
        }

        public override string Refuel(double liters)
        {
            if (liters <= 0)
            {
                return "Fuel must be a positive number";
            }
            else
            {
                this.FuelQty += liters*0.95;
                return "";
            }

        }
    }
}
