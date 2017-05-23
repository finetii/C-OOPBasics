using System;

namespace Car
{
    class Car
    {
        public double speed;
        public double fuel;
        public double fuelEconomy;
        public double travelDistance;
        public double travelTime;

        public Car(double speed, double fuel, double fuelEconomy)
        {
            this.speed = speed;
            this.fuel = fuel;
            this.fuelEconomy = fuelEconomy;
            travelDistance = 0;
            travelTime = 0;
        }

        public void Travel(double distance)
        {
            double requiredFuel = fuelEconomy * (distance/100d);
            if (fuel >= requiredFuel)
            {
                fuel -= requiredFuel;
                travelDistance += distance;
                travelTime = (distance / speed) * 60d;
            }
            else
            {
                double passedDistance = fuel / (fuelEconomy / 100d);
                fuel = 0;
                travelDistance += passedDistance;
                travelTime += (passedDistance / speed) * 60d;
            }
        }

        public void Refuel(double load)
        {
            fuel += load;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            Car car = new Car(int.Parse(input[0]), double.Parse(input[1]), double.Parse(input[2]));
            string command = Console.ReadLine();

            

            while (command != "END")
            {
                string[] commandArgs = command.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                switch (commandArgs[0])
                {
                    case "Travel":
                        car.Travel(double.Parse(commandArgs[1]));
                        break;
                    case "Refuel":
                        car.Refuel(double.Parse(commandArgs[1]));
                        break;
                    case "Distance":
                        Console.WriteLine("Total distance: {0:f1} kilometers", car.travelDistance);
                        break;
                    case "Time":
                        Console.WriteLine("Total time: {0} hours and {1} minutes",(int)(car.travelTime / 60), (int)(car.travelTime % 60));
                        break;
                    case "Fuel":
                        Console.WriteLine("Fuel left: {0:f1} liters", car.fuel);
                        break;
                }
                command = Console.ReadLine();
            }
        }
    }
}
