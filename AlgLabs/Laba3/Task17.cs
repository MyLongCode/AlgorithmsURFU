using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgLabs.Laba3
{ 

    public class Task17
    {
        public static int IntersectionTwoArrays(int[] a1, int[] a2)
        {
            Dictionary<long, byte> dict = new Dictionary<long, byte>();
            foreach(var item in a1)
            {
                if (dict.ContainsKey(item)) dict[item]++;
                else dict[item] = 1;
            }
            foreach (var item in a2)
            {
                if (dict.ContainsKey(item)) dict[item]++;
                else dict[item] = 1;
            }
            int res = 0;
            foreach (var item in dict)
                if (item.Value > 1) res++;
            return res;

        }
        public static void Solution()
        {
            string[] input = Console.ReadLine().Split();
            int n = int.Parse(input[0]);
            int m = int.Parse(input[1]);
            int[][] ints = new int[n][];
            for(var i = 0; i < n; i++)
            {
                string[] line = Console.ReadLine().Split();
                ints[i] = new int[m];
                for (var j = 0; j < m; j++)
                    ints[i][j] = int.Parse(line[j]);
            }
            int ans = 0;
            for (var i = 0; i < n; i++)
                for (var j = i + 1; j < n; j++)
                    ans = Math.Max(ans, IntersectionTwoArrays(ints[i], ints[j]));
            Console.WriteLine(ans);
        }
    }
}
