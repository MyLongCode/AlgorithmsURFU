using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeTasks
{
    internal class _704_Binary_Search
    {
        public static int Search(int[] nums, int target)
        {
            var left = 0;
            var right = nums.Length - 1;
            int point;
            while(left <= right)
            {
                point = left + (right - left) / 2;
                if (nums[point] == target) return point;
                if (nums[point] < target) left = point + 1;
                else right = point - 1;
                point = (left + right) / 2;
            }
            return -1;


            // 1 2 4 5 6 7 8 #3
        }

        public static void Main (string[] args)
        {
            Search(new int[] { -1, 0, 3, 5, 9, 12 }, 9);
        }
    }
}
