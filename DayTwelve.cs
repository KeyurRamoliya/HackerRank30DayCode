using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank30Day
{
    class DayTwelve
    {
        private static void Main()
        {
            string[] inputs = Console.ReadLine().Split();
            string firstName = inputs[0];
            string lastName = inputs[1];
            int id = Convert.ToInt32(inputs[2]);
            int numScores = Convert.ToInt32(Console.ReadLine());
            inputs = Console.ReadLine().Split();
            int[] scores = new int[numScores];
            for (int i = 0; i < numScores; i++)
            {
                scores[i] = Convert.ToInt32(inputs[i]);
            }

            Student s = new Student(firstName, lastName, id, scores);
            s.printPerson();
            Console.WriteLine("Grade: " + s.calculate() + "\n");
            Console.ReadLine();
        }
    }

    internal partial class Person
    {
        protected string firstName;
        protected string lastName;
        protected int id;

        public Person() { }
        public Person(string firstName, string lastName, int identification)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.id = identification;
        }
        public void printPerson()
        {
            Console.WriteLine("Name: " + lastName + ", " + firstName + "\nID: " + id);
        }
    }

    internal class Student : Person
    {
        private int[] testScores;

        private int sum = 0;
        public Student(string firstName, string lastName, int id, int[] scores)
        {
            base.firstName = firstName;
            base.lastName = lastName;
            base.id = id;
            testScores = scores;
        }

        public string calculate()
        {
            foreach (int score in testScores)
            {
                sum = sum + Convert.ToInt16(score);
            }
            sum = sum/testScores.Length;
            if (sum >= 90 && sum <= 100)
            {
                return "O";
            }
            if (sum >= 80 && sum < 90)
            {
                return "E";
            }
            if (sum >= 70 && sum < 80)
            {
                return "A";
            }
            if (sum >= 55 && sum < 70)
            {
                return "P";
            }
            if (sum >= 40 && sum < 55)
            {
                return "D";
            }
            if (sum < 40)
            {
                return "T";
            }
            return null;
        }
    }
}
