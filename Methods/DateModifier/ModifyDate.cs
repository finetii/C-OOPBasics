using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateModifier
{
    public class DateModifier
    {
        public static void CalculateDays(string d1, string d2)
        {
            DateTime date1 = DateTime.ParseExact(d1, "yyyy MM dd", System.Globalization.CultureInfo.InvariantCulture);
            DateTime date2 = DateTime.ParseExact(d2, "yyyy MM dd", System.Globalization.CultureInfo.InvariantCulture);

            TimeSpan difference = date1 - date2;
            double diff = difference.TotalDays;
            //if (diff < 0)
            //{
            //    diff += 1;
            //}

            Console.WriteLine(Math.Abs(diff));
        }
    }
    class ModifyDate
    {
        static void Main(string[] args)
        {
            string date1 = Console.ReadLine();
            string date2 = Console.ReadLine();

            DateModifier.CalculateDays(date1, date2);
        }
    }
}
