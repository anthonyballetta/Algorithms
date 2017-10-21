using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures
{
    public class DiagonalDifference
    {
        static void Main(String[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            int[][] a = new int[n][];
            for (int a_i = 0; a_i < n; a_i++)
            {
                string[] a_temp = Console.ReadLine().Split(' ');
                a[a_i] = Array.ConvertAll(a_temp, Int32.Parse);
            }
            int d1Sum = 0, d2Sum = 0;
            for (int i = 0; i < n; i++)
            {
                d1Sum += a[i][i];
                d2Sum += a[i][n - 1 - i];
            }
            Console.WriteLine(Math.Abs(d1Sum - d2Sum));
        }
    }
}
