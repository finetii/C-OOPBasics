using System;
using System.Linq;


namespace MordorsCrueltyPlan
{
    class Program
    {
        static void Main(string[] args)
        {
            Gandalf g = new Gandalf();
            string[] input = Console.ReadLine().Split(new char[] { ',',' ' }, StringSplitOptions.RemoveEmptyEntries);
            g.Eat(input.Select(f => FoodFactory.GetFood(f)));

            Console.WriteLine(g);
        }
    }
}
