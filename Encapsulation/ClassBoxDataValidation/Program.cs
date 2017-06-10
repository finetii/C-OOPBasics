using System;
using System.Linq;
using System.Reflection;

namespace Encapsulation
{
    class Box
    {
        double length;
        double width;
        double height;

        public double Length
        {
            get { return this.length; }
            private set
            {
                if (value <= 0)
                {
                    throw new ArgumentException($"{nameof(this.Length)} cannot be zero or negative.");
                }
                this.length = value;
            }
        }
        public double Width
        {
            get { return this.width; }
            private set
            {
                if (value <= 0)
                {
                    throw new ArgumentException($"{nameof(this.Width)} cannot be zero or negative.");
                }
                this.width = value;
            }
        }
        public double Height
        {
            get { return this.height; }
            private set
            {
                if (value <= 0)
                {
                    throw new ArgumentException($"{nameof(this.Height)} cannot be zero or negative.");
                }
                this.height = value;
            }
        }
        public Box(double length, double width, double height)
        {
            this.Length = length;
            this.Width = width;
            this.Height = height;
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

        public override string ToString()
        {
            return $"Surface Area - {SurfaceArea():f2}\r\n" + $"Lateral Surface Area - {LateralSurfaceArea():f2}\r\n" + $"Volume - {Volume():f2}";
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            Type boxType = typeof(Box);
            FieldInfo[] fields = boxType.GetFields(BindingFlags.NonPublic | BindingFlags.Instance);
            Console.WriteLine(fields.Count());


            double[] input = new double[3];
            input[0] = double.Parse(Console.ReadLine());
            input[1] = double.Parse(Console.ReadLine());
            input[2] = double.Parse(Console.ReadLine());

            try
            {
                Box box = new Box(input[0], input[1], input[2]);
                Console.WriteLine(box);
            }
            catch (ArgumentException ae)
            {
                Console.WriteLine(ae.Message);
            }
        }
    }
}
