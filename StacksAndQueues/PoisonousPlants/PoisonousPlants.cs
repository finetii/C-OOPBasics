using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PoisonousPlants
{
    class PoisonousPlants
    {
        static void Main(string[] args)
        {
            int numberOfPlants = int.Parse(Console.ReadLine());
            int[] plants = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            int[] days = new int[numberOfPlants];
            Stack<int> indexStack = new Stack<int>();
            indexStack.Push(0);
            
            for (int i = 0; i < plants.Length; i++)
            {
                int maxDays = 0;
                while(indexStack.Count > 0 && plants[indexStack.Peek()] >= plants[i])
                {
                    maxDays = Math.Max(maxDays, days[indexStack.Pop()]);
                }
                if (indexStack.Count > 0)
                {
                    days[i] = maxDays + 1;
                }
                indexStack.Push(i);
            }

            Console.WriteLine(days.Max());
        }
    }
}
