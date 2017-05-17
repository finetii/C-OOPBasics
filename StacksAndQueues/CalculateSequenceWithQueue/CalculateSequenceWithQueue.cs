using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculateSequenceWithQueue
{
    class CalculateSequenceWithQueue
    {
        static void Main(string[] args)
        {
            long n = long.Parse(Console.ReadLine());
            Queue<long> myQue = new Queue<long>();
           
            List<long> result = new List<long>();
            myQue.Enqueue(n);
            result.Add(n);

            while (result.Count < 50)
            {
                long currentNumber = myQue.Dequeue();
                long firstNumber = currentNumber + 1;
                long secondNumber = (currentNumber * 2) + 1;
                long thirdNumber = currentNumber + 2;

                myQue.Enqueue(firstNumber);
                myQue.Enqueue(secondNumber);
                myQue.Enqueue(thirdNumber);
               

                result.Add(firstNumber);
                result.Add(secondNumber);
                result.Add(thirdNumber);
            }

            for (int i = 0; i < 50; i++)
            {
                Console.Write(result[i] + " ");
            }
        }
    }
}
