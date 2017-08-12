

namespace ConsoleApplication1
{
    public abstract class Vehicle
    {
        double fuelQuantity;
        double fuelConsumption;
        
        public double FuelConsumption
        {
            get { return this.fuelConsumption; }
            set { this.fuelConsumption = value; }
        }
        
        public double FuelQuantity
        {
            get { return this.fuelQuantity; }
            set { this.fuelQuantity = value; }
        }


        public Vehicle(double fuelQuantity, double fuelConsumption)
        {
            this.FuelQuantity = fuelQuantity;
            this.FuelConsumption = fuelConsumption;
        }

        public abstract void Drive(double distance);
        public virtual void Refuel(double fuel)
        {
            this.fuelQuantity += fuel;
        }
    }
}
