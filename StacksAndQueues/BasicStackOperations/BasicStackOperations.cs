using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicStackOperations
{
    class BasicStackOperations
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int n = input[0];
            int s = input[1];
            int x = input[2];

            int[] numbers = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            Stack<int> stack = new Stack<int>();

            foreach (var number in numbers)
            {
                stack.Push(number);
            }
            for (int i = 0; i < s; i++)
            {
                stack.Pop();
            }
            if (stack.Count == 0)
            {
                Console.WriteLine(0);
                return;
            }
            bool numberFound = false;
            foreach (var number in stack)
            {
                if (number == x)
                {
                    Console.WriteLine("true");
                    numberFound = true;
                    break;
                }               
            }
            if (!numberFound)
            {
                Console.WriteLine(stack.Min());
            }
          
        }
    }
}
