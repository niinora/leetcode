using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.ArrayHashing
{
    internal class ValidAnagram
    {
        public bool IsAnagram1(string s, string t)
        {
            char[] chars1 = s.ToCharArray();
            Array.Sort(chars1);
            char[] chars2 = t.ToCharArray();
            Array.Sort(chars2);

            return chars1.SequenceEqual(chars2);
        }

        public bool IsAnagram2(string s, string t)
        {
            return s.OrderBy(c => c).SequenceEqual(t.OrderBy(c => c));
        }

        public bool IsAnagram3(string s, string t)
        {
            if (s.Length != t.Length) return false;
            Dictionary<char, int> dic = new Dictionary<char, int>();
            for (int i = 0; i < s.Length; i++)
            {
                dic.TryAdd(s[i], 0);
                dic[s[i]]++;
                dic.TryAdd(t[i], 0);
                dic[t[i]]--;
            }
            return dic.Values.All(c => c == 0);
        }

        public bool IsAnagram4(string s, string t)
        {
            if (s.Length != t.Length) return false;
            char[] letters = new char[26];
            foreach(char c in s) letters[c - 'a']++;
            foreach(char c in t) letters[c - 'a']--;
            return letters.All(c=>c==0);
        }

    }
}
