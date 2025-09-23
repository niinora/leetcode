using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Stack
{
    internal class ValidParentheses
    {
        public bool IsValid(string s)
        {
            if((s.Length & 1) == 1) return false;
            Stack<char> stack = new Stack<char>();
            foreach(char c in s)
            {
                if(c == '(' || c == '{' || c == '[') stack.Push(c);
                else if(c == ')') 
                {
                    if (stack.Count > 0 && stack.Pop() == '(') continue;
                    return false;
                }
                else if (c == '}' )
                {
                    if (stack.Count>0 && stack.Pop() == '{') continue;
                    return false;
                }
                else if (c == ']')
                {
                    if (stack.Count > 0 && stack.Pop() == '[' ) continue;
                    return false;
                }
            }
            return stack.Count == 0;
        }
    }
}
