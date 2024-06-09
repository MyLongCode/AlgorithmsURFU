using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace LeetCodeTasks
{
    public class _125_Valid_Palindrome
    {
        public static bool IsPalindrome(string s)
        {
            s = s.ToLower();
            s = new string(s.Where(c => char.IsLetterOrDigit(c)).ToArray());
            int left = 0, right = s.Length - 1;
            while(left < right)
            {
                if (s[left] == s[right])
                {
                    left++;
                    right--;
                }
                else return false;
            }
            return true;
        }
        public static void Main()
        {
            var b = IsPalindrome("A man, a plan, a canal: Panama");
            Console.WriteLine(b);
        }
    }
}
