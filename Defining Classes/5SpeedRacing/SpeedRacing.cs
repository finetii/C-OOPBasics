using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5SpeedRacing
{
    public class Car
    {
        public string carModel;
        public double fuelAmount;
        public double fuelCostPerKm;
        public double distanceTraveled;
        
        public Car(string carModel, double fuelAmount, double fuelCost)
        {
            this.carModel = carModel;
            this.fuelAmount = fuelAmount;
            this.fuelCostPerKm = fuelCost;
            this.distanceTraveled = 0;
        }
        public void KmTravelled(int amountOfKm)
        {            
            if (amountOfKm <= fuelAmount/fuelCostPerKm)
            {
                distanceTraveled += amountOfKm;
                fuelAmount -= (fuelCostPerKm*amountOfKm);
            }
            else
                Console.WriteLine("Insufficient fuel for the drive");
        }
    }


    public class SpeedRacing
    {
        public static void Main()
        {
            List<Car> cars = new List<Car>();
            int numberOfCars = int.Parse(Console.ReadLine());

            for (int i = 0; i < numberOfCars; i++)
            {
                string[] input = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                cars.Add(new Car(input[0], double.Parse(input[1]), double.Parse(input[2])));
            }

            string driveCommand = Console.ReadLine();
            while(driveCommand != "End")
            {
                string[] driveArgs = driveCommand.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                string carModel = driveArgs[1];
                int amountOfKm = int.Parse(driveArgs[2]);
                Car carToDrive = cars.First(c => c.carModel == carModel);
                carToDrive.KmTravelled(amountOfKm);
                driveCommand = Console.ReadLine();
            }
            foreach (var car in cars)
            {
                Console.WriteLine("{0} {1:f2} {2}", car.carModel,car.fuelAmount, car.distanceTraveled);
            }
        }
    }
}
