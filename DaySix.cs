using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank30Day
{
    class DaySix
    {
        static void Main(String[] args)
        {
            /* Enter your code here. Read input from STDIN. Print output to STDOUT. Your class should be named Solution */
            int T = Convert.ToInt16(Console.ReadLine());
            string temp1 = null, temp2 = null;
            if (T >= 1 && T <= 10)
            {
                for (int i = 1; i <= T; i++)
                {
                    string S = Console.ReadLine();
                    if (S != null && S.Length >= 2 && S.Length <= 10000)
                    {
                        string s = new string(S.ToCharArray());
                        for (int j = 0; j < s.Length; j++)
                        {
                            if (j%2 == 0)
                            {
                                temp1 = temp1 + s[j];
                            }
                            else
                            {
                                temp2 = temp2 + s[j];
                            }
                        }
                    }
                    Console.WriteLine(temp1 + " " + temp2);
                    temp1 = string.Empty;
                    temp2 = string.Empty;
                }
            }
            Console.ReadLine();
        }
    }
}