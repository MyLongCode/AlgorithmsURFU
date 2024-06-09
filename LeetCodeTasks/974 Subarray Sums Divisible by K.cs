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
            int[] sums = new int[k];
            sums[0] = 1;
            int prefix = 0;
            for(var i = 0; i < nums.Length; i++)
            {
                prefix = (prefix + nums[i]) % k;
                if (prefix < 0) prefix += k;
                sums[prefix]++;
            }

            foreach (int item in sums)
                ans += item * (item - 1) / 2;
            return ans;
        }
        public static void Main()
        {
            Console.WriteLine(SubarraysDivByK(new int[] {4,5,0,-2,-3,1}, 5));
        }
    }
}
