using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeChecker
{
    class Number
    {
        public long number;
        public bool prime;

        public Number(long number, bool prime)
        {
            this.number = number;
            this.prime = prime;
        }

        public bool PrimeCheck(long number)
        {
            for (int i = 2; i <= Math.Sqrt(number); i++)
            {
                prime = true;
                if (number % i == 0)
                {
                    prime = false;
                    break;
                }
            }
            return prime;
        }
        public long GetNextPrime(long numb)
        {
            long nextNumber = numb + 1;
            if (number == 0 || numb == 1)
            {
                return numb + 1;
            }
            while (PrimeCheck(nextNumber)==false)
            {
                nextNumber++;
            }
            return nextNumber;
        }
    }
    class PrimeChecker
    {
        static void Main(string[] args)
        {
            long num = long.Parse(Console.ReadLine());
            bool isPrime = true;
            
            Number numb = new Number(num, isPrime);
                Console.WriteLine("{0}, {1}", numb.GetNextPrime(num), numb.PrimeCheck(num) ? "true" : "false");
        }
    }
}
