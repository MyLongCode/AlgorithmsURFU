using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgLabs.Laba4
{
    public class Task1
    {
        public static long GetSum(long[] array, int start, int finish)
        {
            if (start == 0) return array[finish];
            return array[finish] - array[start - 1];
        }

        public static void GetSumArray(long[] array1, long[] array2)
        {
            array2[0] = array1[0];
            for (int i = 1; i < array2.Length; i++)
            {
                array2[i] = array2[i - 1] + array1[i];
            }
        }

        public static void Solution()
        {
            string[] input = Console.ReadLine().Split();
            int n = int.Parse(input[0]);
            int m = int.Parse(input[1]);
            long[] V = new long[n];
            for (int i = 0; i < n; i++)
                V[i] = long.Parse(Console.ReadLine());

            long[] sumArray = new long[n];
            bool flag = true;
            GetSumArray(V, sumArray);

            for (int i = 0; i < m; i++)
            {
                string[] x = Console.ReadLine().Split();
                int p1 = int.Parse(x[1]);
                int p2 = int.Parse(x[2]);
                if (x[0] == "1") Console.WriteLine(GetSum(sumArray, p1, p2));
                else
                {
                    flag = false;
                    V[p1] = p2;
                    GetSumArray(V, sumArray);
                }

            }

        }
    }
}
