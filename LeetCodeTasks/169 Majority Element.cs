using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeTasks
{
    public class Majority_Element
    {
        public static int MajorityElement(int[] nums)
        {
            Array.Sort(nums);

            int n = nums.Length;

            int max_count = 1, res = nums[0];
            int curr_count = 1;

            for (int i = 1; i < n; i++)
            {
                if (nums[i] == nums[i - 1])
                    curr_count++;
                else
                    curr_count = 1;

                // If last element is most frequent 
                if (curr_count > max_count)
                {
                    max_count = curr_count;
                    res = nums[i - 1];
                }
            }

            return res;
        }
        public static void Main()
        {
            MajorityElement(new int[] { 2, 2, 1, 1, 1, 2, 2 });
        }
    }
}
