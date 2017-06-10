using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation
{
    class Box
    {
        double length;
        double width;
        double height;

        public Box(double length, double width, double height)
        {
            this.length = length;
            this.width = width;
            this.height = height;
        }
        public double SurfaceArea()
        {
            return 2 * length * width + 2 * length * height + 2 * width * height;
        }

        public double LateralSurfaceArea()
        {
            return 2 * length * height + 2 * width * height;
        }

        public double Volume()
        {
            return length * width * height;
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            Type boxType = typeof(Box);
            FieldInfo[] fields = boxType.GetFields(BindingFlags.NonPublic | BindingFlags.Instance);
            Console.WriteLine(fields.Count());

            //double length = double.Parse(Console.ReadLine());
            double[] input = new double[3];
            input[0] = double.Parse(Console.ReadLine());
            input[1] = double.Parse(Console.ReadLine());
            input[2] = double.Parse(Console.ReadLine());
            Box box = new Box(input[0], input[1], input[2]);

            Console.WriteLine("Surface Area - {0:f2}\nLateral Surface Area - {1:f2}\nVolume - {2:f2}",box.SurfaceArea(),box.LateralSurfaceArea(),box.Volume());
        }
    }
}
