using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace HackerRank30Day
{
    class DayTwenty
    {
        static void Main(String[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            string[] a_temp = Console.ReadLine().Split(' ');
            int[] a = Array.ConvertAll(a_temp, Int32.Parse);
            bool flag = true;
            int count = 0;
            int temp;
            for (int i = 1; (i <= (n - 1)) && flag; i++)
            {
                flag = false;
                for (int j = 0; j < (n - 1); j++)
                {
                    if (a[j] > a[j + 1])
                    {
                        temp = a[j + 1];
                        a[j + 1] = a[j];
                        a[j] = temp;
                        flag = true;
                        count++;
                    }
                }
            }
            foreach (int num in a)
            {
                Console.Write("{0} ", num);
            }
            Console.WriteLine();
            Console.WriteLine("Array is sorted in " + count + " swaps.");
            Console.WriteLine("First Element: " + a[0]);
            Console.WriteLine("Last Element: " + a[a.Length - 1]);
            Console.ReadLine();
        }
    }
}
