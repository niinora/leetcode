using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.TwoPointers
{
    internal class ValidPalindrome
    {
        public bool IsPalindrome(string s)
        {

            char[] chars = s.ToLower().Where(c=>char.IsLetterOrDigit(c)).ToArray();
            for (int i = 0; i < chars.Length  / 2; i++)
            {
                Console.WriteLine(chars[i]+ "  "+ chars[chars.Length-1-i]);
                if (chars[i] != chars[chars.Length - 1 - i]) return false;
            }
            return true;
        }
    }
}
