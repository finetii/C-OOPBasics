using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FibonacciNumbers
{
    public class Fibonacci
    {
        private List<long> numbers;
        
        public List<long> GetNumbersInRange(int startPosition, int endPosition)
        {
            getFibonacciToRange(endPosition);
            return this.numbers.Skip(startPosition).ToList();
        }

        private void getFibonacciToRange(int endPosition)
        {
            List<long> fib = new List<long>();
            fib.Add(0);
            fib.Add(1);

            for (int i = 2; i < endPosition; i++)
            {
                
                fib.Add(fib[i-1] + fib[i-2]);
            }
            numbers = fib;
        }
    }
    class FibonacciNumbers
    {
        static void Main(string[] args)
        {
            int startPosition = int.Parse(Console.ReadLine());
            int endPosition = int.Parse(Console.ReadLine());
            Fibonacci fib = new Fibonacci();
            Console.WriteLine(string.Join(", ", fib.GetNumbersInRange(startPosition, endPosition)));

            /*
            var collection = fib.GetNumbersInRange(startPosition, endPosition);
            foreach (var l in collection)
            {
                Console.Write(string.Join(", ",l));
            }/*/
            
        }
    }
}
