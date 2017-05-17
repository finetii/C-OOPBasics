using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberInReversedOrder
{
    public class ReversedNumber
    {
        public string number;

        public ReversedNumber(string number)
        {
            this.number = number;
        }

        public string PrintReversedNumber()
        {
            char[] numbers = number.ToCharArray();
            Array.Reverse(numbers);
            return new string (numbers);
        }

    }
    class NumberInReversedOrder
    {
        static void Main(string[] args)
        {
            ReversedNumber num = new ReversedNumber(Console.ReadLine());
            Console.WriteLine(num.PrintReversedNumber());
        }
    }
}
