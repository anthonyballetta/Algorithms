using System;
using System.Collections.Generic;

namespace DataStructures
{
    public class Solution
    {

       public static void Main(String[] args)
        {
            Solution s = new Solution();
            IList<String> i = s.FizzBuzz(15);
            foreach(var value in i)
            {
                Console.WriteLine(value);
            }
            Console.Read();

        }

        public IList<string> FizzBuzz(int n)
        {
            IList<string> ilist = new List<string>();
            for (int i = 1; i <= n; i++)
            {
                if ((i % 3 == 0) && (i % 5 == 0))
                {
                    ilist.Add("FizzBuzz");
                }
                else if (i % 3 == 0)
                {
                    ilist.Add("Fizz");
                }
                else if (i % 5 == 0)
                {
                    ilist.Add("Buzz");
                }
                else
                {
                    ilist.Add(i.ToString());
                }
            }
            return ilist;
        }
    }
}