using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank30Day
{
    class DaySeven
    {
        static void Main(String[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            string[] arr_temp = Console.ReadLine().Split(' ');
            int[] arr = Array.ConvertAll(arr_temp, Int32.Parse);
            Array.Reverse(arr);
            for (int i = 0; i < n; i++)
            {
                Console.Write(arr[i].ToString() + " ");
            }
            Console.ReadLine();
        }
    }
}