using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank30Day
{
    class DayTwentyFive
    {
        static void Main(String[] args)
        {
            /* Enter your code here. Read input from STDIN. Print output to STDOUT. Your class should be named Solution */
            int n = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                int num = Convert.ToInt32(Console.ReadLine());
                var result = isPrime(num) ? "Prime" : "Not prime";
                Console.WriteLine(result);
            }
            Console.ReadLine();
            //while (n-- > 0)
            //{
            //    int num = Convert.ToInt32(Console.ReadLine());
            //    var result = isPrime(num) ? "Prime" : "Not prime";
            //    Console.WriteLine(result);
            //    Console.ReadLine();
            //}
        }

        private static bool isPrime(int num)
        {
            if (num == 2)
                return true;
            if (num < 2 || num % 2 == 0)
                return false;

            for (int i = 2; i <= Math.Floor(Math.Sqrt(num)); i++)
            {
                if (num % i == 0)
                    return false;
            }

            return true;
        }
    }
}
