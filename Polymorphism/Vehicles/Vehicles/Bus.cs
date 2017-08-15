using System;


namespace Vehicles
{
    class Bus : Vehicle
    {
        public Bus(double fuelQty, double fuelConsumption, double tankCapacity)
            : base (fuelQty, fuelConsumption, tankCapacity)
        {
        }

        public override string Drive(double distance)
        {
            if ((distance * (this.FuelConsumption+1.4)) <= this.FuelQty)
            {
                this.FuelQty -= distance * (this.FuelConsumption+1.4);
                return $"Bus travelled {distance} km";
            }
            else
            {
                return "Bus needs refueling";
            }
        }

        public string DriveEmpty(double distance)
        {
            if ((distance * this.FuelConsumption) <= this.FuelQty)
            {
                this.FuelQty -= distance * this.FuelConsumption;
                return $"Bus travelled {distance} km";
            }
            else
            {
                return "Bus needs refueling";
            }
        }

    }
}
