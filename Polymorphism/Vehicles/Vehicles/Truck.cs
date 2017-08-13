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

        public override void Drive(double distance)
        {
            if((distance * this.FuelConsumption) <= FuelQty)
            {
                this.FuelQty -= distance * this.FuelConsumption;
            }
            else
            {
                throw new ArgumentException("Truck needs refueling");
            }
        }

        public override void Refuel(double liters)
        {
            if (liters <= 0)
            {
                throw new ArgumentException("Fuel must be a positive number");
            }
            else
                this.FuelQty += liters * 0.95;
        }
    }
}
