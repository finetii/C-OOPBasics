using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mordor_sCrueltyPlan
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> input = new List<string>();
            input = Console.ReadLine().Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries).ToList();
            Gandalf g = new Gandalf();
            foreach (string item in input)
            {
                g.EatFood(item);
            }
            Console.WriteLine(g.Happiness + Environment.NewLine + g.Mood);
        }
    }
}
