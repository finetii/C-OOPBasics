using System;
using System.Collections.Generic;


namespace StackFibonnaci
{
    class StackFibonnaci
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());
            Stack<long> fibonnaciNumbers = new Stack<long>();

            fibonnaciNumbers.Push(1);
            fibonnaciNumbers.Push(1);

            for(int i = 2; i < input; i++)
            {
                long n1 = fibonnaciNumbers.Pop();
                long n2 = fibonnaciNumbers.Peek();
                fibonnaciNumbers.Push(n1);
                fibonnaciNumbers.Push(n1 + n2);
            }
            if (input ==0 || input ==1)
            {
                Console.WriteLine("1");
            }
            else
                Console.WriteLine(fibonnaciNumbers.Peek());

        }
    }
}
