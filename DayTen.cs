using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank30Day
{
    class DayTen
    {
        static void Main(String[] args)
        {
            int count = 0;
            int n = Convert.ToInt32(Console.ReadLine());
            if (n >= 1 && n <= 1000000)
            {
                var binaryNum = Convert.ToString(n, 2);
                char[] list = binaryNum.ToCharArray();
                for (int i = 1; i < list.Length; i++)
                {
                    int c = String.CompareOrdinal(list[i].ToString(), list[i - 1].ToString());
                    if (c == 0)
                    {
                        count++;
                    }
                }
                if (count == 0)
                {
                    Console.WriteLine(1);
                }
                else
                {
                    Console.WriteLine(count + 1);
                }
            }
            Console.ReadLine();
        }
    }
}
