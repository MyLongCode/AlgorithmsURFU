using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeTasks
{
    internal class _633_Sum_of_Square_Numbers
    {
        public bool JudgeSquareSum(int c)
        {
            int start = 0;
            int end = (int)(Math.Round(Math.Sqrt(c) + 1) - 1);
            while(start <= end)
            {
                if (start * start + end * end == c) return true;
                if (start * start + end * end > c) end--;
                else start++;
            }
            return false;
        }
    }
}
