using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StacksAndQueues
{
    class ReverseNumbers
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

            Stack<int> stack = new Stack<int>();

            foreach (var number in input)
            {
                stack.Push(number);
            }
            Console.WriteLine(string.Join(" ", stack));
        }
    }
}
