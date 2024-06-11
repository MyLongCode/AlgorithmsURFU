using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeTasks
{
    internal class _209_Minimum_Size_Subarray_Sum
    {
        public static int MinSubArrayLen(int target, int[] nums)
        {
            int curSum = 0;
            int res = int.MaxValue;
            int start = 0;
            int i = 0;
            while(i < nums.Length)
            {
                curSum += nums[i];
                while( curSum >= target)
                {
                    res = Math.Min(res, i - start + 1);
                    curSum -= nums[start];
                    start++;
                }
                i++;
            }
            if (res == int.MaxValue) return 0;
            return res;
        }
        public static void Main()
        {
            MinSubArrayLen(7,new int[] { 2, 3, 1, 2, 4, 3 });
        }
    }
}
