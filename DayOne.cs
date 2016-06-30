using System;

namespace HackerRank30Day
{
    class DayOne
    {
        static void Main(String[] args)
        {
            int i = 4;
            double d = 4.0;
            string s = "HackerRank ";
            int k;
            double j = 4.0;
            string r;
            // Declare second integer, double, and String variables.
            k = Convert.ToInt16(Console.ReadLine());
            //j = Convert.ToDouble($"{Console.ReadLine():0.0}");
            r = Console.ReadLine();
            // Read and save an integer, double, and String to your variables.
            Console.WriteLine(i + k);
            // Print the sum of both integer variables on a new line.
            Console.WriteLine((d + j).ToString("F1"));
            // Print the sum of the double variables on a new line.
            Console.WriteLine(s + r);
            Console.ReadLine();
            // Concatenate and print the String variables on a new line
            // The 's' variable above should be printed first.
        }
    }
}