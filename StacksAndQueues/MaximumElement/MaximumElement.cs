using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaximumElement
{
    class MaximumElement
    {
        static void Main(string[] args)
        {
            Stack<int> stack = new Stack<int>();
            Stack<int> maxElements = new Stack<int>();
            int maxElement = int.MinValue;

            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                string command = input[0];

                switch (command)
                {
                    case "1":
                        stack.Push(int.Parse(input[1]));
                        if (maxElements.Count == 0 ||  int.Parse(input[1]) >= maxElements.Peek())
                        {
                            maxElement = int.Parse(input[1]);
                            maxElements.Push(maxElement);
                        }
                        break;

                    case "2":
                        int elementAtTop = stack.Pop();
                        int currentMaxNumber = maxElements.Peek();
                        if (elementAtTop == currentMaxNumber)
                        {
                            maxElements.Pop();
                            if (maxElements.Count > 0)
                            {
                                maxElement = maxElements.Peek();
                            }
                        }
                        break;

                    case "3":
                        Console.WriteLine(maxElements.Peek());
                        break;
                }
            }
        }
    }
}
