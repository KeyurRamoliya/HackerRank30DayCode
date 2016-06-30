using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank30Day
{
    class DayTwo
    {
        static void Main(string[] args)
        {
            double mealCost;
            int tipPersent;
            int taxPersent;
            int totalCost;
            mealCost = Convert.ToDouble(Console.ReadLine());
            tipPersent = Convert.ToInt16(Console.ReadLine());
            taxPersent = Convert.ToInt16(Console.ReadLine());
            totalCost = Convert.ToInt16(mealCost + ((mealCost * tipPersent) / 100) + ((mealCost * taxPersent) / 100));
            Console.WriteLine("The total meal cost is " + totalCost + " dollars.");
        }
    }
}