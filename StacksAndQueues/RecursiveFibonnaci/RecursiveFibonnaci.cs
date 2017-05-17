using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecursiveFibonnaci
{
    class RecursiveFibonnaci
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());

            //Console.WriteLine(recursiveFibonnaci2(input));
            Console.WriteLine("result -> " + getFibonnaci(input));
            Console.WriteLine(calcFib[input]);
        }
        public static Dictionary<int, long> calcFib = new Dictionary<int, long>();
        private static long getFibonnaci(int input)
        {
            if (input == 1 || input == 0)
            {
                if (!calcFib.ContainsKey(input))
                    calcFib.Add(input, input);
                return calcFib[input];
            }

            if (calcFib.ContainsKey(input))
            {
                return calcFib[input];
            }
            else
            {
                long result = getFibonnaci(input - 1) + getFibonnaci(input - 2);
                calcFib[input] = result;
                return result;
            }
            /*/
            private static long recursiveFibonnaci2(int input)
            {
                long[] fibonnaciNumbers = new long[input + 1];

                fibonnaciNumbers[0] = 1;
                fibonnaciNumbers[1] = 1;

                for (int i = 2; i <= input; i++)
                {
                    fibonnaciNumbers[i] = fibonnaciNumbers[i - 1] + fibonnaciNumbers[i - 2];
                }
                return fibonnaciNumbers[input];
            }/*/
        }
    }
}
