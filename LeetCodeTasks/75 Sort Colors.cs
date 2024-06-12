using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeTasks
{
    internal class _75_Sort_Colors
    {
        public static void SortColors(int[] nums)
        {
            var arr = new int[3];
            foreach(int i in nums)
                arr[i]++;
            var index = 0;

            for(int i = 0; i < arr.Length; i++)
                for(int j = 0; j < arr[i]; j++)
                    nums[index++] = i;
            return;
        }

        public static void Main()
        {
            SortColors(new int[] { 2, 0, 2, 1, 1, 0 });
        }
    }
}
