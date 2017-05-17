using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LastDigitName
{
    class Number
    {
        public int number;

        public Number (int num)
        {
            this.number = num;
        }

        public string PrintLastDigit()
        {
            int digit = number % 10;
            switch (digit)
            {
                case 0: return "zero";
                case 1: return "one";
                case 2: return "two";
                case 3: return "three";
                case 4: return "four";
                case 5: return "five";
                case 6: return "six";
                case 7: return "seven";
                case 8: return "eight";
                case 9: return "nine";
                default: return "error";
            }
        }
    }
    class LastDigitName
    {
        static void Main(string[] args)
        {
            Number num = new Number(int.Parse(Console.ReadLine()));
            Console.WriteLine(num.PrintLastDigit());
        }
    }
}
