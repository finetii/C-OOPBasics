using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemperatureConverter
{
    class Temperature
    {
        public static double convertCelsiusToFahrenheit(int degrees)
        {
            return ((9.0 / 5.0) * degrees) + 32;
        }

        public static double convertFahrenheitToCelsius(int degrees)
        {
            return (5.0 / 9.0) * (degrees - 32);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();

            while(command != "End")
            {
                string[] input = command.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                switch (input[1])
                {
                    case "Fahrenheit":
                        Console.WriteLine($"{Temperature.convertFahrenheitToCelsius(int.Parse(input[0])):f2} Celsius");
                         break;
                    case "Celsius":
                        Console.WriteLine($"{Temperature.convertCelsiusToFahrenheit(int.Parse(input[0])):f2} Fahrenheit"); break;

                }
                command = Console.ReadLine();
            }
        }
    }
}
