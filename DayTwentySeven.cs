using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using static System.Convert;
using System.Text;

public class Tester
{
    static void Main()
    {
        TestCaseGenerator();
    }

    static string TestCaseGenerator()
    {
        //StringBuilder for testing
        StringBuilder final = new StringBuilder();

        //Print T
        Random rnd = new Random();
        int T = 5;

        final.Append($"{T}\n");
        Console.WriteLine(T);

        //Print Test Cases
        for (int k = 0; k < T; k++)
        {
            //Whether or not the Test Case should print Yes or No
            bool canceled = k % 2 == 0;

            //Print N and K, maxN is supposed to be 200
            int maxN = 201;
            int N = rnd.Next(3, maxN);
            int K = 0;

            //This makes it possible to have a class if we must produce a "NO", we will have one late kid
            if (!canceled) { K = rnd.Next(1, N); }

            //We are guaranteed at least 2 kids in class. We need this in order to force a canceled situation
            else if (K < 3 && canceled) { K = rnd.Next(3, N); }
            else { K = rnd.Next(1, N+1); }

            final.Append($"{N} {K}\n");
            Console.WriteLine($"{N} {K}");

            //Create cases so there is at least ONE of each
            int guaranteedZero = rnd.Next(0,N);
            int guaranteedPositive;
            int guaranteedNegative;

            do { guaranteedPositive = rnd.Next(0,N); }
            while (guaranteedPositive == guaranteedZero);

            do { guaranteedNegative = rnd.Next(0,N); }
            while (guaranteedNegative == guaranteedZero || guaranteedNegative == guaranteedPositive); 

            int studentsOnTime = 0;
            int mandatoryStudentsLeft = 2;
            int lateStudents = 1;

            for (int i = 0; i < N; i++)
            {
                int toPrint;

                if (i == guaranteedZero)
                {
                    toPrint = 0;
                    studentsOnTime++;
                    mandatoryStudentsLeft--;
                }
                else if (i == guaranteedPositive) 
                {
                    toPrint = rnd.Next(1, 1001);
                    lateStudents--; //No double counting
                }
                else if (i == guaranteedNegative)
                {
                    toPrint = rnd.Next(-1000, 0);
                    studentsOnTime++;
                    mandatoryStudentsLeft--;
                }
                else 
                {
                    int totalStudents = studentsOnTime + mandatoryStudentsLeft;

                    if (canceled && totalStudents + 1 >= K) 
                    {
                        toPrint = rnd.Next(1,1001);
                    }
                    else if (!canceled && N - lateStudents == K) 
                    {
                        toPrint = rnd.Next(-1000, 1);
                    }
                    else 
                    {
                        toPrint = rnd.Next(-1000, 1001);
                    }
                }

                if (toPrint <= 0) { studentsOnTime++; }
                else { lateStudents++; }

                if (i == 0) 
                {
                    final.Append(toPrint);
                    Console.Write(toPrint); 
                }
                else 
                {
                    final.Append($" {toPrint}");
                    Console.Write($" {toPrint}");
                }
            }

            final.Append("\n");
            Console.WriteLine();
        }
        return final.ToString();
    }

    static void Solver(string toRead)
    {
        StringReader str = new StringReader(toRead);

        int T = Int32.Parse(str.ReadLine()); // Number of Test Cases

        for (int i = 0; i < T; i++)
        {
            int K = Array.ConvertAll(str.ReadLine().Split(' '), Int32.Parse)[1];
            int[] arrivalTimes = Array.ConvertAll(str.ReadLine().Split(' '), Int32.Parse);
            int n = (from time in arrivalTimes where time <= 0 select time).Count();

            string canceled = n < K ? "YES" : "NO";
            Console.WriteLine(canceled);
        }
    }
}