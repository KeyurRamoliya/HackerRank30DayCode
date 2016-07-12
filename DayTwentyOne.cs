using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank30Day
{
    class DayTwentyOne
    {
        static void Main(string[] args)
        {
            int[] vInt = new int[] { 1, 2, 3 };
            string[] vString = new string[] { "Hello", "World" };

            printArray<int>(vInt);
            printArray<string>(vString);
            Console.ReadLine();
        }

        private static void printArray<T>(T[] vInt)
        {
            foreach (var item in vInt)
            {
                Console.WriteLine(item);
            }
        }
    }
}
