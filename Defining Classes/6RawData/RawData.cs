using System;
using System.Collections.Generic;
using System.Linq;


namespace _6RawData
{
    public class Car
    {
        public string model;
        public Engine engine;
        public Cargo cargo;
        public List<Tire> tires;

        public Car(string model, Engine engine, Cargo cargo, List<Tire> tires)
        {
            this.model = model;
            this.engine = engine;
            this.cargo = cargo;
            this.tires = tires;
        }
    }

    public class Tire
    {
        public double tirePressure;
        public int tireAge;

        public Tire(double tirePressure, int tireAge)
        {
            this.tirePressure = tirePressure;
            this.tireAge = tireAge;
        }
    }

    public class Cargo
    {
        public int cargoWeight;
        public string cargoType;

        public Cargo(int cargoWeight, string cargoType)
        {
            this.cargoWeight = cargoWeight;
            this.cargoType = cargoType;
        }
    }

    public class Engine
    {
        public int engineSpeed;
        public int enginePower;

        public Engine(int engineSpeed, int enginePower)
        {
            this.engineSpeed = engineSpeed;
            this.enginePower = enginePower;
        }
    }

    public class RawData
    {
        static void Main()
        {
            int numberOfCars = int.Parse(Console.ReadLine());
            List<Car> cars = new List<Car>();

            for (int i = 0; i < numberOfCars; i++)
            {
                string[] carDetails = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                Engine engine = new Engine(int.Parse(carDetails[1]), int.Parse(carDetails[2]));
                Cargo cargo = new Cargo(int.Parse(carDetails[3]), carDetails[4]);
                /*List<Tire> tires = new List<Tire>() { new Tire(double.Parse(carDetails[5]), int.Parse(carDetails[6])), new Tire(double.Parse(carDetails[7]), int.Parse(carDetails[8])), new Tire(double.Parse(carDetails[9]), int.Parse(carDetails[10])), new Tire(double.Parse(carDetails[11]), int.Parse(carDetails[12])) };//*/

                List<Tire> tires = new List<Tire>();
                
                for (int j = 5; j < carDetails.Length; j++)
                {
                    tires.Add(new Tire(double.Parse(carDetails[j++]), int.Parse(carDetails[j])));
                }
                
                cars.Add(new Car(carDetails[0], engine, cargo, tires));
            }
            string command = Console.ReadLine();
            List<Car> sortedCars = new List<Car>();
            if (command == "fragile")
            {
                sortedCars = cars.Where(c => c.cargo.cargoType == "fragile" && c.tires.Any(t => t.tirePressure < 1)).ToList();
            }
            else
                sortedCars = cars.Where(c => c.cargo.cargoType == "flamable" && c.engine.enginePower > 250).ToList();

            foreach (var item in sortedCars)
            {
                Console.WriteLine(item.model);
            }
        }
    }
}
