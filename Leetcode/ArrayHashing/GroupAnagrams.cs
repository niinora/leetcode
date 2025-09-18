using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.ArrayHashing
{
    internal class GroupAnagrams
    {
        public IList<IList<string>> GroupAnagrams1(string[] strs)
        {
            Dictionary<int, string> dic = new Dictionary<int, string>();
            for (int i = 0; i < strs.Length; i++)
            {
                int[] letters = new int[26];
                foreach (char c in strs[i])
                    letters[c - 'a']++;
                dic[i] = String.Join(",", letters); 
            }

            var group = dic
                .GroupBy(kvp => kvp.Value)
                .Select(g => (IList<string>)g.Select(kvp => strs[kvp.Key]).ToList())
                .ToList();

            return group;
        }
        
        public IList<IList<string>> GroupAnagrams2(string[] strs)
        {
            Dictionary<string, List<string>> anagrams = new Dictionary<string, List<string>>();
            foreach(string str in strs)
            {
                char[] chars = str.ToCharArray();
                Array.Sort(chars);
                string sorted = new string(chars);
                if (!anagrams.ContainsKey(sorted))
                {
                    anagrams[sorted]= new List<string>();
                }
                anagrams[sorted].Add(str);
                
            }
            return anagrams.Select(x=>x.Value).ToList<IList<string>>();  
        }
    }
}
