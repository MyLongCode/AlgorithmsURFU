using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeTasks
{
    public class _121_Best_Time_to_Buy_and_Sell_Stock
    {
        public static int MaxProfit(int[] prices)
        {
            int index = 0;
            int maxDif = 0;
            for(var i = 0; i < prices.Length; i++)
            {
                if (prices[i] < prices[index]) index = i;
                if (prices[i] > prices[index])
                {
                    if (prices[i] - prices[index] > maxDif) maxDif = prices[i] - prices[index];
                }
            }
            return maxDif;
        }

        public static void Main()
        {

        }
    }
}
