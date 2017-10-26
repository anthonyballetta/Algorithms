using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures
{
    public class IsAnagram
    {
        public class Solution
        {
            public static void Main(String[] args)
            {
                bool answer = IsAnagram("apple","appel");
                Console.WriteLine(answer);
                Console.Read();
            }

            public static bool IsAnagram(string s, string t)
            {
                char[] firstWord = s.ToCharArray();
                char[] secondWord = t.ToCharArray();
                Array.Sort(firstWord);
                Array.Sort(secondWord);
                if (firstWord.Length == 0 && secondWord.Length == 0)
                {
                    return true;
                }
                return firstWord.SequenceEqual(secondWord);
            }
        }
    }
}
