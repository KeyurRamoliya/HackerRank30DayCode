using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace HackerRank30Day
{
    class DayTwentySix
    {
        private static void Main(String[] args)
        {
            var culture = CultureInfo.CreateSpecificCulture("bg-BG");
            Thread.CurrentThread.CurrentCulture = culture;
            Thread.CurrentThread.CurrentUICulture = culture;

            DateTime returnDate = Convert.ToDateTime(Console.ReadLine());
            DateTime expectedDate = Convert.ToDateTime(Console.ReadLine());

            int returnDay = returnDate.Day;
            int returnMonth = returnDate.Month;
            int returnYear = returnDate.Year;

            int expectedDay = expectedDate.Day;
            int expectedMonth = expectedDate.Month;
            int expectedYear = expectedDate.Year;
            if (DateTime.Compare(returnDate, expectedDate) < 0)
            {
                Console.WriteLine(0);
            }
            else
            {
                if (returnMonth == expectedMonth &&
                    returnYear == expectedYear)
                    Console.WriteLine(15 * (returnDay - expectedDay));
                else if (returnYear == expectedYear)
                {
                    int diff = returnMonth > expectedMonth ?
                        returnMonth - expectedMonth : expectedMonth - returnMonth;
                    Console.WriteLine(500 * diff);
                }
                else
                    Console.WriteLine(10000);
            }

            Console.ReadLine();
        }
    }
}