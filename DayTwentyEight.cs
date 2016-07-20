using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace HackerRank30Day
{
    class DayTwentyEight
    {
        static void Main(String[] args)
        {
            int N = Convert.ToInt32(Console.ReadLine());

            List<string> names = new List<string>();

            for (int a0 = 0; a0 < N; a0++)
            {
                string[] tokens_firstName = Console.ReadLine().Split(' ');
                string firstName = tokens_firstName[0];
                string emailID = tokens_firstName[1];

                string pattern = @"@gmail.com$";
                Match match = Regex.Match(emailID, pattern);

                if (match.Success) { names.Add(firstName); }
            }

            names.Sort();

            foreach (string name in names)
            {
                Console.WriteLine(name);
            }
        }
    }
}
