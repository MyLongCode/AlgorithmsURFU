using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeTasks
{
    internal class _20_Valid_Parentheses
    {
        public bool IsValid(string s)
        {
            var stack = new Stack<char>();
            foreach (char c in s)
            {
                if (c == '(') { stack.Push(')'); continue; }
                if (c == '{') { stack.Push('}'); continue; }
                if (c == '[') { stack.Push(']'); continue; }
                if (stack.Count == 0 || c != stack.Pop()) return false;
            }
            return true;

        }
    }
}
