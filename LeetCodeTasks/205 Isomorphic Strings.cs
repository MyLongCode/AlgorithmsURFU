using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeTasks
{
    internal class _205_Isomorphic_Strings
    {
        public bool IsIsomorphic(string s, string t)
        {
            Dictionary<char,char> map = new Dictionary<char,char>();
            for(var i = 0; i < s.Length; i++)
            {
                if ((map.ContainsKey(s[i]) && map[s[i]] != t[i]) 
                    || (!map.ContainsKey(s[i]) && map.ContainsValue(t[i]))) return false;
                if (!map.ContainsKey(s[i])) map.Add(s[i], t[i]);
            }
            return true;
        }
    }
}

