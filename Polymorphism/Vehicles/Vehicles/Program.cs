using System;

namespace Vehicles
{
    class Program
    {
        private static string Drive(string command, double distance, Car car, Bus bus, Truck truck)
        {
            switch (command)
            {
                case "Car": return car.Drive(distance);
                case "Truck": return truck.Drive(distance); 
                case "Bus": return bus.Drive(distance); 

                default: return "Unknown vehicle"; 
            }
        }

        private static void ParseCommand(string[] command, Car car, Bus bus, Truck truck)
        {
            string res = "Unknown command";

            switch (command[0])
            {
                case "Drive":
                    {
                        double.TryParse(command[2], out double distance);
                        res = Drive(command[1], distance, car, bus, truck);
                        Console.WriteLine(res);
                    }
                    break;

                case "DriveEmpty":
                    {
                        double.TryParse(command[2], out double distance);
                        switch (command[1])
                        {
                            case "Bus": res = bus.DriveEmpty(distance); break;
                            default: res = "Only bus can be drivven empty."; break;
                        }
                        Console.WriteLine(res);
                    }
                    break;

                case "Refuel":
                    {
                        double.TryParse(command[2], out double liters);
                        switch (command[1])
                        {
                            case "Car": res = car.Refuel(liters); break;
                            case "Truck": res = truck.Refuel(liters); break;
                            case "Bus": res = bus.Refuel(liters); break;
                            default: res = "Unknown vehicle"; break;
                        }
                        if (res != "")
                            Console.WriteLine(res);
                    }
                    break;
                default: res = "unknown command"; break;
            }
        }

        private static void initObjects(Car car, Bus bus, Truck truck)
        {
            for (int i = 0; i < 3; i++)
            {
                try
                {
                    string[] input = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                    double fuelQty = 0;
                    double fuelConsumption = 0;
                    double tankCapacity = 0;
                    double.TryParse(input[1], out fuelQty);
                    double.TryParse(input[2], out fuelConsumption);
                    double.TryParse(input[3], out tankCapacity);

                    switch (input[0])
                    {
                        case "Car":
                            {
                                if (car == null)
                                    car = new Car(fuelQty, fuelConsumption, tankCapacity);
                                else
                                    throw new Exception("Car is allready initialised!");
                            }
                            break;
                        case "Truck":
                            {
                                if (truck == null)
                                    truck = new Truck(fuelQty, fuelConsumption, tankCapacity);
                                else
                                    throw new Exception("Truck is allready initialised!");
                            }
                            break;

                        case "Bus":
                            {
                                if (bus == null)
                                    bus = new Bus(fuelQty, fuelConsumption, tankCapacity);
                                else
                                    throw new Exception("Bus is allready initialised!");
                            }
                            break;
                        default: throw new Exception("Wrong input format");
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine("Error: " + e.Message);
                }
            }
        }

        static void Main(string[] args)
        {
            Car car = null;
            Truck truck = null;
            Bus bus = null;

            initObjects(car, bus, truck);

            try
            {
                int.TryParse(Console.ReadLine(), out int numberOfEntries);

                for (int i = 0; i < numberOfEntries; i++)
                {
                    string[] command = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                    ParseCommand(command, car, bus, truck);
                }
                Console.WriteLine($"Car: {car.FuelQty:f2}");
                Console.WriteLine($"Truck: {truck.FuelQty:f2}");
                Console.WriteLine($"Bus: {bus.FuelQty:f2}");
            }
            catch (Exception e)
            {
                Console.WriteLine("Error: " + e.Message);
            }
        }
    }
}
