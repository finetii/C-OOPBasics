using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicMath
{
    static class MathUtil
    {
        public static double Sum(double a, double b)
        {
            return a + b;
        }

        public static double Subtract(double a, double b)
        {
            return a - b;
        }

        public static double Multiply(double a, double b)
        {
            return a * b;
        }

        public static double Divide(double a, double b)
        {
            return a / b;
        }

        public static double Percentage(double a, double b)
        {
            return (a * b) / 100;
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
                double a = double.Parse(input[1]);
                double b = double.Parse(input[2]);
                switch (input[0])
                {
                    case "Sum":
                        Console.WriteLine("{0:f2}",MathUtil.Sum(a,b));
                        break;
                    case "Subtract":
                        Console.WriteLine("{0:f2}",MathUtil.Subtract(a,b));
                        break;
                    case "Multiply":
                        Console.WriteLine("{0:f2}",MathUtil.Multiply(a,b));
                        break;
                    case "Divide":
                        Console.WriteLine("{0:f2}",MathUtil.Divide(a,b));
                        break;
                    case "Percentage":
                        Console.WriteLine("{0:f2}",MathUtil.Percentage(a,b));
                        break;
                }
                command = Console.ReadLine();
            }
        }
    }
}
