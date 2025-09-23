using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Stack
{
    internal class GenerateParentheses
    {
        public IList<string> GenerateParenthesis(int n)
        {
            List<string> result = new List<string>();
            void gen(string current, int opening, int closing)
            {
                if(current.Length == 2 * n)
                {
                    result.Add(current);
                    return;
                }
                if(opening<n) gen(current+"(", opening+1, closing);
                if(closing<n) gen(current+")", opening, closing+1);
            }
            gen("", 0, 0);
            return result;
        }

    }
}
