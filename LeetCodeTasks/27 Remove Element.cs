using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeTasks
{
    public class _27
    {
		public static int RemoveElement(int[] nums, int val)
		{
			var ans = 0;
			for(var i = 0; i < nums.Length; i++)
			{
				if (nums[i] == val)
				{
					ans++;
					nums[i] = -1;
				}
			}
			Array.Sort(nums);
			nums.Reverse();
			return ans;
		}

		public static void Main()
		{
			var i = RemoveElement(new int[] { 3, 2, 2, 3 }, 3);
		}
	}
}
