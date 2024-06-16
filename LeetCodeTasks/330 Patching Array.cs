using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeTasks
{
    internal class _330_Patching_Array
    {
        public int MinPatches(int[] nums, int n)
        {
            int patches = 0;
            long maxSumCovered = 0;
            int i = 0;

            while (maxSumCovered < n)
            {
                if (i < nums.Length && nums[i] <= maxSumCovered + 1)
                {
                    maxSumCovered += nums[i];
                    i++;
                }
                else
                {
                    maxSumCovered += maxSumCovered + 1;
                    patches++;
                }
            }
            GC.Collect();
            return patches;
        }
    }
}
