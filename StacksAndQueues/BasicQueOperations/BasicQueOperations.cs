using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicQueOperations
{
    class BasicQueOperations
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            int n = input[0];
            int s = input[1];
            int x = input[2];

            Queue<int> myQue = new Queue<int>();
            int[] numbers = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

            foreach (var number in numbers)
            {
                myQue.Enqueue(number);
            }

            for (int i = 0; i < s; i++)
            {
                myQue.Dequeue();
            }

            if(myQue.Count == 0)
            {
                Console.WriteLine(0);
                return;
            }
               

            bool isNumberPresent = false;
            foreach (var number in myQue)
            {
                if (number == x)
                {
                    Console.WriteLine("true");
                    isNumberPresent = true;
                    break;
                }
            }

            if(!isNumberPresent)
            {
                Console.WriteLine(myQue.Min());
            }
          

        }
    }
}
