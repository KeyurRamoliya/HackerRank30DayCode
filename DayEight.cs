using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank30Day
{
    class DayEight
    {
        static void Main(String[] args)
        {
            /* Enter your code here. Read input from STDIN. Print output to STDOUT. Your class should be named Solution */
            int n = Convert.ToInt16(Console.ReadLine());
            Dictionary<string, string> phoneBook = new Dictionary<string, string>();
            if (n >= 1 && n <= 100000)
            {
                for (int i = 1; i <= n; i++)
                {
                    string readLine = Console.ReadLine();
                    if (readLine != null)
                    {
                        string[] words = readLine.Split(' ');
                        for (int j = 0; j < 1; j++)
                        {
                            phoneBook.Add(words[j], words[j + 1]);
                        }
                    }
                }
            }
            for (int i = 0;; i++)
            {
                string readLine = Console.ReadLine();
                if (readLine != null)
                {
                    foreach (var contact in phoneBook)
                    {
                        if (contact.Key == readLine)
                        {
                            Console.WriteLine(contact.Key + "=" + contact.Value);
                            goto Outer;
                        }
                        else
                        {
                            for (int j = 0; j < 1; j++)
                            {
                                Console.WriteLine("Not found");
                                goto Outer;
                            }
                        }
                    }
                Outer:
                    continue;
                }
            }
        }
    }
}