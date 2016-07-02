using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank30Day
{
    class DayEleven
    {
        static void Main(String[] args)
        {
            int[][] arr = new int[6][];
            for (int arr_i = 0; arr_i < 6; arr_i++)
            {
                string[] arr_temp = Console.ReadLine().Split(' ');
                arr[arr_i] = Array.ConvertAll(arr_temp, Int32.Parse);
            }
            int maxHourGlass = Int32.MinValue;
            int temp = Int32.MinValue;

            for (int i = 0; i < 6; i++)
            {
                for (int j = 0; j < 6; j++)
                {
                    if (i <= 3 && j <= 3)
                    {
                        temp = (arr[i][j] + arr[i][j + 1] +
                        arr[i][j + 2]) +

                        (arr[i + 2][j] + arr[i + 2][j + 1] +
                        arr[i + 2][j + 2]) +

                        (arr[i + 1][j + 1]);

                        if (temp > maxHourGlass)
                        {
                            maxHourGlass = temp;
                        }

                    }
                }
            }
            Console.WriteLine(maxHourGlass);
        }
    }
}