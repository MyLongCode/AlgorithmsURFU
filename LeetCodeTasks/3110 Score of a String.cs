using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeTasks
{
    public class Score_of_a_String
    {
        public static int ScoreOfString(string s)
        {
            int res = 0;
            for(var i = 0; i < s.Length - 1; i++)
            {
                res += Math.Abs(s[i] - s[i+1]);
            }
            return res;
        }
        public static void Main()
        {
            ScoreOfString("zaz");
        }
    }
}
