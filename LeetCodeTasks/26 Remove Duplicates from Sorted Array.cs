using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeTasks
{
    public class Remove_Duplicates_from_Sorted_Array
    {
        public static int RemoveDuplicates(int[] nums)
        {
            var index = 0;
            var repeat = nums[0];
            for (var i = 0; i < nums.Length; i++)
            {
                if (nums[i] != repeat)
                {
                    index++;
                    nums[index] = nums[i];
                    repeat = nums[i];

                }
            }
            return index+1;
        }
        public static void Main()
        {
            RemoveDuplicates(new int[] { 0, 0, 1, 1, 1, 2, 2, 3, 3, 4 });
        }
    }
}
