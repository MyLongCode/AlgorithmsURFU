using ForAlgorithms.Sorts;
using ForAlgorithms.Structures;
using System.Buffers.Binary;

namespace Algorithms
{
    class Algorithms
    {

        public static Tuple<int, List<int>, List<int>> GetMaxSubsequence(int[] arr1, int[] arr2)
        {
            var indexes1 = new List<int>();
            var indexes2 = new List<int>();
            int[][] dp = new int[arr1.Length+1][];
            for (var i = 0; i <= arr1.Length; i++)
                dp[i] = (new int[arr2.Length+1]);

            for (var i = 1; i <= arr1.Length; i++)
                for(var j = 1; j <= arr2.Length; j++)
                {
                    if (arr1[i - 1] == arr2[j - 1])
                        dp[i][j] = dp[i - 1][j - 1] + 1;
                    else
                        dp[i][j] = Math.Max(dp[i - 1][j], dp[i][j - 1]);
                }
            int x = arr1.Length;
            int y = arr2.Length;
            while (x > 0 && y > 0)
            {
                if (arr1[x - 1] == arr2[y - 1])
                {
                    indexes1.Add(x);
                    indexes2.Add(y);
                    x--;
                    y--;
                }
                else
                {
                    if (dp[x][y] == dp[x - 1][y])
                    {
                        x--;
                    }
                    else y--;
                }
            }
            indexes1.Reverse();
            indexes2.Reverse();
            return new Tuple<int, List<int>, List<int>>(dp[dp.Length - 1][0], indexes1, indexes2);
        
        }

        

        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            string[] input1 = Console.ReadLine().Split();
            int[] arr1 = input1.Select(m => int.Parse(m)).ToArray();
            int m = int.Parse(Console.ReadLine());
            string[] input2 = Console.ReadLine().Split();
            int[] arr2 = input1.Select(m => int.Parse(m)).ToArray();
            var ans = GetMaxSubsequence(arr1, arr2);
            Console.WriteLine(ans.Item1);
            foreach (int x in ans.Item2)
                Console.Write(x + " ");
            Console.WriteLine();
            foreach (int x in ans.Item3)
                Console.Write(x + " ");


        }
    }
        
}
