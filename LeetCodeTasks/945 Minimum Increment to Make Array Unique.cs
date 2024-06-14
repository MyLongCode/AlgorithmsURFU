using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeTasks
{
    internal class _945_Minimum_Increment_to_Make_Array_Unique
    {
        public int MinIncrementForUnique(int[] nums)
        {
            Array.Sort(nums);
            int ans = 0;
            for(var i = 1; i < nums.Length; i++)
            {
                if (nums[i] <= nums[i - 1])
                {
                    nums[i] += nums[i - 1] - nums[i] + 1;
                    ans += nums[i - 1] - nums[i] + 1;
                }

            }
            GC.Collect();
            return ans;
        }

    }
}
