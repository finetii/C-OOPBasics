using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Car : Vehicle
    {
        public Car(double fuelQuantity, double fuelConsumption)
            : base(fuelQuantity, fuelConsumption)
        {
            this.FuelConsumption += 0.9;
        }

        public override void Drive(double distance)
        {
            if (this.FuelConsumption >= this.FuelQuantity)
            {
                throw new ArgumentException($"Car needs refueling");
            }
            else
            {
                this.FuelQuantity -= this.FuelConsumption * distance;
            }
        }

        public override void Refuel(double fuel)
        {
            throw new NotImplementedException();
        }
    }
}
