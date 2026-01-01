using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeTasks
{
    internal class _347_Top_K_Frequent_Elements
    {
        public static int[] TopKFrequent(int[] nums, int k)
        {
            var dict = new Dictionary<int, int>();
            var queue = new PriorityQueue<int, int>();
            var ans = new int[k];
            foreach (var item in nums)
                dict[item] = dict.GetValueOrDefault(item, 0) + 1;
            foreach(var item in dict)
            {
                queue.Enqueue(item.Key, item.Value);
                if (queue.Count > k)
                    queue.Dequeue();
            }
            for (var i = 0; i < k; i++)
                ans[i] = queue.Dequeue();
            return ans;
        }

        public static void Main(string[] args)
        {
            TopKFrequent(new int[] { 1, 1, 1,4,4,4,4, 2, 2, 3 }, 2);
        }
    }
}
