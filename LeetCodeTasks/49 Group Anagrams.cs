using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeTasks
{
    internal class _49_Group_Anagrams
    {
        public static IList<IList<string>> GroupAnagrams(string[] strs)
        {
            var dict = new Dictionary<string, List<string>>();
            foreach (var str in strs)
            {
                var sortStr = String.Concat((str)
                      .OrderBy(c => char.ToUpper(c)) 
                      .ThenBy(c => c));
                if (!dict.ContainsKey(sortStr)) dict[sortStr] = new List<string> { str};
                else dict[sortStr].Add(str);
            }

            var ans = new List<IList<string>>();
            foreach(var list in dict.Values)
                ans.Add(list);
            return ans;
        }

        public static void Main()
        {
            GroupAnagrams(new string[] { "eat", "tea", "tan", "ate", "nat", "bat" });
        }
    }
}
