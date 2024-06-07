using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeTasks
{
    public class _122_Best_Time_to_Buy_and_Sell_Stock_II
    {
        public static int MaxProfit(int[] prices)
        {
            int index = 0;
            int ans = 0;
            for (var i = 0; i < prices.Length; i++)
            {
                if (prices[i] < prices[index]) index = i;
                if (prices[i] > prices[index])
                {
                    ans += prices[i] - prices[index];
                    index = i;
                }
            }
            return ans;
        }

        public static void Main()
        {
            MaxProfit(new int[] { 1,2,3,4,5 });
        }
    }
}
