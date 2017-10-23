using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures
{
    public class SingleNumber
    {
        class Solution
        {
            public static void Main(String[] args)
            {
                Solution s1 = new Solution();

                int[] a = { 1, 1, 2, 2, 3 };

                int answer = s1.singleNumber(a);
                Console.WriteLine("test");
                Console.WriteLine(answer.ToString());

                Console.Read();
            }

            public int singleNumber(int[] A)
            {
                int result = A[0];
                for (int i = 1; i < A.Length; i++)
                {
                    result = result ^ A[i];  /* Get the xor of all elements */
                }
                return result;
            }
        }
    }
}