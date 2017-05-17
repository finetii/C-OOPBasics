using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7CarSalesman
{
    public class Engine
    {
        public string model;
        public int power;
        public int displacement;
        public string efficiency;

        public Engine(string model, int power) : this (model, power, -1, @"n/a")
        {
           
        }
        public Engine(string model, int power, int displacement) : this (model, power, displacement, @"n/a")
        {

        }

        public Engine(string model, int power, string efficiency) : this (model, power, -1, efficiency)
        {
 
        }

        public Engine(string model, int power, int displacement, string efficiency)
        {
            this.model = model;
            this.power = power;
            this.displacement = displacement;
            this.efficiency = efficiency;       
        }
        public override string ToString()
        {
            if (displacement == -1)
            {
                return $"\n  {model}:\n    Power: {power}\n    Displacement: n/a\n    Efficiency: {efficiency}";
            }
            else
                return $"\n  {model}:\n    Power: {power}\n    Displacement: {displacement}\n    Efficiency: {efficiency}";
        }
    }
    public class Car
    {
        public string model;
        public Engine engine;
        public int weight;
        public string color;

        public Car (string model, Engine engine) : this (model, engine, -1, @"n/a")
        {

        }

        public Car(string model, Engine engine, int weight) : this (model, engine, weight, @"n/a")
        {

        }

        public Car(string model, Engine engine, string color) : this (model, engine, -1, color)
        {

        }
        public Car(string model, Engine engine, int weight, string color)
        {
            this.model = model;
            this.engine = engine;
            this.weight = weight;
            this.color = color;
        }
        public override string ToString()
        {
            if (weight == -1)
                return $"{model}:{engine.ToString()}\n  Weight: n/a\n  Color: {color}";
            else
                return $"{model}:{engine.ToString()}\n  Weight: {weight}\n  Color: {color}";
        }
    }
    public class CarSalesman
    {
        
        public static List<Car> cars = new List<Car>();
        public static List<Engine> engines = new List<Engine>();
        static void Main()
        {            
            int numberOfInputs = int.Parse(Console.ReadLine());
            
            for (int i = 0; i < numberOfInputs; i++)
            {
                string[] engineInfo = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                if (engineInfo.Length == 2)
                {
                    engines.Add(new Engine(engineInfo[0], int.Parse(engineInfo[1])));
                }
                else if (engineInfo.Length == 3)
                {
                    int engineDisplacement;
                    if (int.TryParse(engineInfo[2], out engineDisplacement))
                    {
                        engines.Add(new Engine(engineInfo[0], int.Parse(engineInfo[1]), engineDisplacement));
                    }
                    else
                        engines.Add(new Engine(engineInfo[0], int.Parse(engineInfo[1]), engineInfo[2]));
                }
                else if (engineInfo.Length == 4)
                    engines.Add(new Engine(engineInfo[0], int.Parse(engineInfo[1]), int.Parse(engineInfo[2]), engineInfo[3]));
                
            }
            
            numberOfInputs = int.Parse(Console.ReadLine());

            for (int i = 0; i < numberOfInputs; i++)
            {
                string[] carinfo = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                if (carinfo.Length == 2)
                {
                    cars.Add(new Car(carinfo[0], choseEngine(carinfo[1])));
                }
                else if (carinfo.Length == 3)
                {
                    int carWeight;
                    if (int.TryParse(carinfo[2], out carWeight))
                    {
                        cars.Add(new Car(carinfo[0], choseEngine(carinfo[1]), carWeight));
                    }
                    else
                        cars.Add(new Car(carinfo[0], choseEngine(carinfo[1]), carinfo[2]));
                }
                else if (carinfo.Length == 4)
                {
                    cars.Add(new Car(carinfo[0], choseEngine(carinfo[1]), int.Parse(carinfo[2]), carinfo[3]));
                }
            }
            foreach (var car in cars)
            {
                /*Console.WriteLine("{0}: \n\t{1}: \n\t\tPower: {2} \n\t\tDisplacement: {3}\n\t\tEfficiency: {4} \n\tWeight: {5} \n\tColor: {6}", car.model, car.engine.model,car.engine.power,car.engine.displacement,car.engine.efficiency,car.weight,car.color);//*/
                Console.WriteLine(car.ToString());
            }     
        }
        private static Engine choseEngine(string model)
        {
            return engines.FirstOrDefault(e => e.model == model);
        }
    }
}
