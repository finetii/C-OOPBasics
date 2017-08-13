using System;


namespace Vehicles
{
    class Bus : Vehicle
    {
        public Bus(double fuelQty, double fuelConsumption, double tankCapacity)
            : base (fuelQty, fuelConsumption, tankCapacity)
        {
        }

        public override void Drive(double distance)
        {
            if ((distance * this.FuelConsumption) <= this.FuelQty)
            {
                this.FuelQty -= distance * this.FuelConsumption;
            }
            else
            {
                throw new ArgumentException("Bus needs refueling");
            }
        }
    }
}
