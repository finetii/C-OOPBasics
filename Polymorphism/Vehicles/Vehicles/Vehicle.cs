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
                if (value <= 0)
                {
                    throw new ArgumentException("TankCapacity must be a positive number");
                }
                tankCapacity = value; }
        }


        public Vehicle(double fuelQty, double fuelConsumption, double tankCapacity)
        {
            this.FuelQty = fuelQty;
            this.FuelConsumption = fuelConsumption;
            this.TankCapacity = tankCapacity;
        }

        public abstract string Drive(double distance);

        public virtual string Refuel(double liters)
        {
            if (liters > this.TankCapacity - this.FuelQty)
            {
                return "Cannot fit fuel in tank";
            }
            else if (liters <= 0)
            {
                return "Fuel must be a positive number";
            }
            else
            {
                this.FuelQty += liters;
                return "";
            }
                
        }
    }
}
