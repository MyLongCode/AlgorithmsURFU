using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeTasks
{
    internal class _383_Ransom_Note
    {
        public bool CanConstruct(string ransomNote, string magazine)
        {
            Hashtable hashtable = new Hashtable();
            foreach (var item in magazine)
            {
                if (!hashtable.ContainsKey(item)) hashtable.Add(item, 1);
                else hashtable[item] = (int)hashtable[item] + 1;
            }
                
            foreach (var item in ransomNote)
            {
                if (hashtable.ContainsKey(item) && (int)hashtable[item] > 0) hashtable[item] = (int)hashtable[item] - 1;
                else return false;
            }
            return true;
        }
    }
}
