using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank30Day
{
    class DayTwentyNine
    {
        static void Main(String[] args)
        {
            int t = Convert.ToInt32(Console.ReadLine());
            for (int a0 = 0; a0 < t; a0++)
            {
                int max = 0;
                string[] tokens_n = Console.ReadLine().Split(' ');
                int n = Convert.ToInt32(tokens_n[0]);
                int k = Convert.ToInt32(tokens_n[1]);
                for (int i = 1; i <= n; i++)
                {
                    int m;
                    for (int j = m = i + 1; j <= n; j++)
                    {
                        var bitand = i & j;
                        if (bitand < k)
                        {
                            if (bitand > max)
                            {
                                max = bitand;
                            }
                        }
                    }
                }
                Console.WriteLine(max);
            }
            Console.ReadLine();
        }
    }
}
