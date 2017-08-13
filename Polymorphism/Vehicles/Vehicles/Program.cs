using System;

namespace Vehicles
{
    class Program
    {
        static void Main(string[] args)
        {
            Tuple<double,double,double> InputData()
            {
                string[] vehicleInfo = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                double.TryParse(vehicleInfo[1], out double fuelQty);
                double.TryParse(vehicleInfo[2], out double fuelConsumption);
                double.TryParse(vehicleInfo[3], out double tankCapacity);
                var tuple = new Tuple<double, double, double>(fuelQty, fuelConsumption, tankCapacity);
                return tuple;
            }
            var vehicleData1 = InputData();
            Vehicle car = new Car(vehicleData1.Item1, vehicleData1.Item2, vehicleData1.Item3);
            var vehicleData2 = InputData();
            Vehicle truck = new Truck(vehicleData2.Item1, vehicleData2.Item2, vehicleData2.Item3);
            var vehicleData3 = InputData();
            Vehicle bus = new Bus(vehicleData3.Item1, vehicleData3.Item2, vehicleData3.Item3);
            

            int.TryParse(Console.ReadLine(), out int numberOfEntries);

            for (int i = 0; i < numberOfEntries; i++)
            {
                string[] command = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);                
                
                switch (command[0])
                {
                    case "Drive":
                        double.TryParse(command[2], out double distance);
                        if (command[1] == "Car")
                        {
                            try
                            {
                                car.Drive(distance);
                                Console.WriteLine($"Car travelled {distance} km");
                            }
                            catch (ArgumentException ae)
                            {
                                Console.WriteLine(ae.Message);
                            }
                        }
                        else if (command[1] == "Truck")
                        {
                            try
                            {
                                truck.Drive(distance);
                                Console.WriteLine($"Truck travelled {distance} km");
                            }
                            catch (ArgumentException ae)
                            {
                                Console.WriteLine(ae.Message);
                            }
                        }
                        else
                        {
                            try
                            {
                                bus.FuelConsumption += 1.4;
                                bus.Drive(distance);
                                Console.WriteLine($"Bus travelled {distance} km");
                            }
                            catch (ArgumentException ae)
                            {
                                Console.WriteLine(ae.Message);
                            }
                        }
                        break;

                    case "DriveEmpty":
                        double.TryParse(command[2], out double busDistance);
                        try
                        {
                            bus.Drive(busDistance);
                            Console.WriteLine($"Bus travelled {busDistance} km");
                        }
                        catch (ArgumentException ae)
                        {
                            Console.WriteLine(ae.Message);
                        }
                        break;

                    case "Refuel":
                        double.TryParse(command[2], out double liters);
                        if (command[1] == "Car")
                        {
                            try
                            {
                                car.Refuel(liters);
                            }
                            catch (ArgumentException ae)
                            {
                                Console.WriteLine(ae.Message);
                            }
                        }
                        else if(command[1] == "Truck")
                        {
                            try
                            {
                                truck.Refuel(liters);
                            }
                            catch(ArgumentException ae)
                            {
                                Console.WriteLine(ae.Message);
                            }
                        }
                        else
                        {
                            try
                            {
                                bus.Refuel(liters);
                            }
                            catch(ArgumentException ae)
                            {
                                Console.WriteLine(ae.Message);
                            }
                        }
                        break;                 
                }
            }
            Console.WriteLine($"Car: {car.FuelQty:f2}");
            Console.WriteLine($"Truck: {truck.FuelQty:f2}");
            Console.WriteLine($"Bus: {bus.FuelQty:f2}");
        }
    }
}
