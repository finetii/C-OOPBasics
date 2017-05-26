using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapesVolume
{
    class TriangularPrism
    {
        public double baseSide;
        public double heightFromBaseSide;
        public double length;

        public TriangularPrism(double baseSide, double heightFromBaseSide, double length)
        {
            this.baseSide = baseSide;
            this.heightFromBaseSide = heightFromBaseSide;
            this.length = length;
        }
    }

    class Cube
    {
        public double sideLength;
        public Cube(double sideLength)
        {
            this.sideLength = sideLength;
        }
    }

    class Cylinder
    {
        public double radius;
        public double heigth;

        public Cylinder(double radius,double heigth)
        {
            this.radius = radius;
            this.heigth = heigth;
        }
    }
    class VolumeCalculator
    {
        public static double TriangularPrismVolume(TriangularPrism t)
        {
            return (t.baseSide * t.heightFromBaseSide * t.length) / 2;
        }

        public static double CubeVolume(Cube c)
        {
            return Math.Pow(c.sideLength, 3);
        }

        public static double CylinderVolume(Cylinder cyl)
        {
            return Math.PI * Math.Pow(cyl.radius, 2) * cyl.heigth;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();

            while (command != "End")
            {
                string[] input = command.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                switch(input[0])
                {
                    case "TrianglePrism":
                        TriangularPrism t = new TriangularPrism(double.Parse(input[1]), double.Parse(input[2]), double.Parse(input[3]));
                        Console.WriteLine("{0:f3}", VolumeCalculator.TriangularPrismVolume(t));
                        break;
                    case "Cube":
                        Cube c = new Cube(double.Parse(input[1]));
                        Console.WriteLine("{0:f3}",VolumeCalculator.CubeVolume(c));
                        break;
                    case "Cylinder":
                        Cylinder cyl = new Cylinder(double.Parse(input[1]), double.Parse(input[2]));
                        Console.WriteLine("{0:f3}",VolumeCalculator.CylinderVolume(cyl));
                        break;
                }
                command = Console.ReadLine();
            }
        }
    }
}
