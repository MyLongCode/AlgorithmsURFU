using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeTasks
{
    public class Reverse_String
    {
        public static void ReverseString(char[] s)
        {
            int c1 = 0;
            int c2 = s.Length - 1;
            while(c1 < c2)
            {
                char temp = s[c1];
                s[c1] = s[c2];
                s[c2] = temp;
                c1++;
                c2--;
            }
            return;
        }
        public static void Main()
        {
            ReverseString(new char[] { 'h', 'e', 'l', 'l', 'o' });
        }
    }
}
