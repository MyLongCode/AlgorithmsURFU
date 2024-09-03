using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeTasks
{
    public class _242_Valid_Anagram
    {
        public bool IsAnagram(string s, string t)
        {
            Dictionary<char, int> dict = new Dictionary<char, int>();
            for(var i = 0; i < s.Length; i++)
            {
                if (!dict.ContainsKey(s[i])) dict.Add(s[i], 1);
                else dict[s[i]]++;
            }
            for(var i = 0; i < t.Length; i++)
            {
                if (!dict.ContainsKey(t[i])) dict.Add(t[i], -1);
                else dict[t[i]]--;
            }
            foreach (KeyValuePair<char, int> entry in dict)
            {
                if (entry.Value != 0) return false;
            }
            return true;
        }

        public static void Main()
        {

        }
    }
}
