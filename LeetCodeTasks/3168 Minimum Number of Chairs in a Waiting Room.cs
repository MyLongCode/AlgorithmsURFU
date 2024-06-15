using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeTasks
{
    internal class _3168_Minimum_Number_of_Chairs_in_a_Waiting_Room
    {
        public int MinimumChairs(string s)
        {
            int max = 0;
            int count = 0;
            for(var i = 0; i < s.Length; i++)
            {
                if (s[i] == 'E')
                {
                    count++;
                    max = Math.Max(count, max);
                }
                else count--;
            }
            return max;
        }
    }
}
