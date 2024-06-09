using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeTasks
{
    public class _974_Subarray_Sums_Divisible_by_K
    {
        public static int SubarraysDivByK(int[] nums, int k)
        {
            int ans = 0;
            int[] summs = new int[nums.Length + 1];
            for(var i = 1; i < nums.Length + 1; i++)
                summs[i] = summs[i - 1] + nums[i - 1];
            for(var i = 0; i < nums.Length + 1; i++)
            {
                for(var j = 0; j < i; j++)
                {
                    if ((summs[i] - summs[j]) % k == 0)
                        ans++;
                }
            }
            return ans;
        }
        public static void PrintSub(int[] nums, int start, int end)
        {
            for(var i = start; i <= end; i++)
            {
                if (i < nums.Length)
                    Console.Write(nums[i] + " ");
            }
            Console.WriteLine();
        }
        public static void Main()
        {
            Console.WriteLine(SubarraysDivByK(new int[] {4,5,0,-2,-3,1}, 5));
        }
    }
}
