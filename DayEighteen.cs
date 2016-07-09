using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank30Day
{
    class DayEighteen
    {
        Stack<char> numbers = new Stack<char>();
        Queue<char> strings = new Queue<char>();
        static void Main(String[] args)
        {   
            // read the string s.
            string s = Console.ReadLine();

            // create the Solution class object p.
            DayEighteen obj = new DayEighteen();

            // push/enqueue all the characters of string s to stack.
            foreach (char c in s)
            {
                obj.pushCharacter(c);
                obj.enqueueCharacter(c);
            }

            bool isPalindrome = true;

            // pop the top character from stack.
            // dequeue the first character from queue.
            // compare both the characters.
            for (int i = 0; i < s.Length / 2; i++)
            {
                if (obj.popCharacter() != obj.dequeueCharacter())
                {
                    isPalindrome = false;

                    break;
                }
            }

            // finally print whether string s is palindrome or not.
            if (isPalindrome)
            {
                Console.Write("The word, {0}, is a palindrome.", s);
            }
            else
            {
                Console.Write("The word, {0}, is not a palindrome.", s);
            }
            Console.ReadLine();
        }

        private char dequeueCharacter()
        {
            char deq;
            deq = strings.Dequeue();
            return deq;
        }

        private char popCharacter()
        {
            char pop;
            pop = numbers.Pop();
            return pop;
        }

        private void enqueueCharacter(char c)
        {
            strings.Enqueue(c);
        }

        private void pushCharacter(char c)
        {
            numbers.Push(c);
        }
    }
}
