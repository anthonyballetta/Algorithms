using System;

namespace Practice
{
    class Program
    {
        static void Main(string[] args)
        {

            string word = "otto";

            if(checkPalindrome(word))
            {
                Console.WriteLine("This word is a palindrome");
            }
            else
            {
                Console.WriteLine("This word is NOT a palindrome");
            }
            Console.Read();
        }

       public static bool checkPalindrome(string inputString)
        {
            int length = inputString.Length;

            for (int i = 0; i < length / 2; i++)
            {
                if (inputString[i] != inputString[length - i - 1])
                {
                    return false;
                }
            }
            return true;
        }

    }
}