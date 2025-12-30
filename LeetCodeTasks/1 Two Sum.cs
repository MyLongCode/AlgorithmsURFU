using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeTasks
{
    public class _1_Two_Sum
    {
        public static int[] TwoSum(int[] nums, int target)
        {
            var ans = new int[2];
            var dict = new Dictionary<int, int>();
            for(var i = 0; i < nums.Length; i++)
            {
                var num = nums[i];
                if (dict.ContainsKey(num) && num * 2 == target) return new int[] { dict[num], i };
                dict[num] = i;
            }
            foreach(var item in dict.Keys)
            {
                if (target - item != item && dict.ContainsKey(target - item)) 
                    return new int[] { dict[item], dict[target - item] };
            }
            return ans;
        }

        public static void Main()
        {
            TwoSum(new int[] { -1, -2, -3, -4, -5 }, -8);
        }
    }
}
