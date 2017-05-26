using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlanckConstant
{
    class Calculation
    {
        static readonly double planck = 6.62606896e-34;
        static readonly double pi = 3.14159;
        public static void Calculate()
        {
            Console.WriteLine(planck / (2 * pi));
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Calculation.Calculate();
        }
    }
}
