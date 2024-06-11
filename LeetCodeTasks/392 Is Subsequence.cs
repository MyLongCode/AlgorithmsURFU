using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeTasks
{
    public class _392_Is_Subsequence
    {
        public static bool IsSubsequence(string s, string t)
        {
            if (s == "") return true;
            if (s.Length > t.Length) return false;
            int i = 0;
            int res = 0;
            foreach(char c in t)
            {
                if (c == s[i])
                {
                    i++;
                    res++;
                    if (i == s.Length) return true;
                }
            }

            return false;
        }
        public static void Main()
        {
            Console.WriteLine(IsSubsequence("abc", "afbsdfc"));
        }
    }
}
