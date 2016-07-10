using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank30Day
{
    public interface AdvancedArithmetic
    {
        int divisorSum(int n);
    }
    class DayNineteen
    {
        static void Main(string[] args)
        {
            int n = Int32.Parse(Console.ReadLine());
            AdvancedArithmetic myCalculator = new Calculator();
            int sum = myCalculator.divisorSum(n);
            Console.WriteLine("I implemented: AdvancedArithmetic\n" + sum);
            Console.ReadLine();
        }
    }

    partial class Calculator : AdvancedArithmetic
    {
        public int divisorSum(int n)
        {
            int sum = 0;
            if (n >= 1)
            {
                for (int i = 1; i <= n; i++)
                {
                    if (n % i == 0)
                    {
                        sum = sum + i;
                    }
                }
            }
            return sum;
        }
    }
}
