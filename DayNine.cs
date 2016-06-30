using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank30Day
{
    class DayNine
    {
        static void Main(String[] args)
        {
            /* Enter your code here. Read input from STDIN. Print output to STDOUT. Your class should be named Solution */
            int n = Convert.ToInt32(Console.ReadLine());
            if (n >= 2 && n <= 12)
            {
                long fact = factorial(n);
                Console.WriteLine(fact);
            }
        }
        private static long factorial(int number)
        {
            if (number == 0)
            {
                return 1;
            }
            return number * factorial(number - 1);
        }
    }
}
