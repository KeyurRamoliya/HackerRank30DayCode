using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank30Day
{
    class DayFive
    {
        static void Main(String[] args)
        {
            int N = Convert.ToInt32(Console.ReadLine());
            if (N >= 2 && N <= 20)
            {
                for (int i = 1; i <= 10; i++)
                {
                    Console.WriteLine(N + " " + "x " + i + " = " + N * i);
                }
            }
        }
    }
}
