using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeTasks
{
    public class _189_Rotate_Array
    {
        public static void Rotate(int[] nums, int k)
        {
            var arr = new int[nums.Length];
            for (int i = 0; i < nums.Length; i++)
                arr[(i + k) % nums.Length] = nums[i];
            for(int i = 0; i < arr.Length; i++)
                nums[i] = arr[i];
            return;
        }
        public static void Main()
        {
            Rotate(new int[] { 1, 2, 3, 4, 5, 6, 7 }, 10);
        }
    }
}
