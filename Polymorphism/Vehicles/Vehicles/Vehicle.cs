using System;

namespace Vehicles
{
    abstract class Vehicle
    {
        double fuelQty;
        double fuelConsumption;
        double tankCapacity;

        public double FuelQty
        {
            get { return fuelQty; }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Fuel must be a positive number");
                }
                fuelQty = value;
            }
        }

        public double FuelConsumption
        {
            get { return fuelConsumption; }
            set { fuelConsumption = value; }
        }

        public double TankCapacity
        {
            get { return tankCapacity; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Fuel must be a positive number");
                }
                tankCapacity = value; }
        }


        public Vehicle(double fuelQty, double fuelConsumption, double tankCapacity)
        {
            this.FuelQty = fuelQty;
            this.FuelConsumption = fuelConsumption;
            this.TankCapacity = tankCapacity;
        }

        public abstract void Drive(double distance);

        public virtual void Refuel(double liters)
        {
            if (liters > this.TankCapacity)
            {
                throw new ArgumentException("Cannot fit fuel in tank");
            }
            else if (liters <= 0)
            {
                throw new ArgumentException("Fuel must be a positive number");
            }
            else
                this.FuelQty += liters;
        }
    }
}
