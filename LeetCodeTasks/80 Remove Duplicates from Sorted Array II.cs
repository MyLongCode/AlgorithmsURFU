using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeTasks
{
    public class Remove_Duplicates_from_Sorted_Array_II
    {
        public static int RemoveDuplicates(int[] nums)
        {
            if (nums.Length == 1) return 1;
            var index = 1;
            var repeat = nums[0];
            int count = 1;
            for (var i = 1; i < nums.Length; i++)
            {
                if ((nums[i] == repeat && count < 2) || (nums[i] != repeat))
                {
                    nums[index] = nums[i];
                    index++;
                    count++;
                    
                }
                if (nums[i] != repeat)
                {
                    repeat = nums[i];
                    count = 1;
                }
            }
            return index;
        }
        public static void Main()
        {
            RemoveDuplicates(new int[] { 1,2});
        }
    }
}
