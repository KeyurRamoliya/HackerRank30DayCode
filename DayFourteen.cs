using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank30Day
{
    class DayFourteen
    {
        static void Main(string[] args)
        {
            Convert.ToInt32(Console.ReadLine());

            int[] a = Console.ReadLine().Split(' ').Select(x => Convert.ToInt32(x)).ToArray();

            Difference d = new Difference(a);

            d.computeDifference();

            Console.Write(d.maximumDifference);
            Console.ReadLine();
        }
    }

    class Difference
    {
        private int[] elements;
        public int maximumDifference;
        public int result = 0;

        public Difference(int[] numbers)
        {
            elements = numbers;
        }

        public int computeDifference()
        {
            Array.Sort(elements);
            for (int i = (elements.Length - 1); i >= 0; i--)
            {
                if (elements[i] > result)
                {
                    result = elements[i];
                }
                int temp = Math.Abs(result - elements[i]);
                if (temp > maximumDifference)
                {
                    maximumDifference = temp;
                }
            }
            return maximumDifference;
        }
    }
}
