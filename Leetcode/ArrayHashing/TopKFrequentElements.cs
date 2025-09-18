using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.ArrayHashing
{
    internal class TopKFrequentElements
    {
        public int[] TopKFrequent1(int[] nums, int k)
        {
            Dictionary<int, int> map = new Dictionary<int, int>();
            foreach (int i in nums)
            {
                if (!map.ContainsKey(i)) map[i] = 0;
                map[i]++;
            }
            return map.OrderByDescending(x => x.Value).Take(k).Select(x => x.Key).ToArray();
        }
        public int[] TopKFrequent2(int[] nums, int k)
        {
            Dictionary<int, int> dic = new Dictionary<int, int>();
            foreach(int i in nums)
            {
                if(!dic.ContainsKey(i)) dic[i] = 0;
                dic[i]++;
            }
            List<int>[] frequency = new List<int>[nums.Length+1];
            for (int i = 0; i < frequency.Length; i++)
            {
                frequency[i] = new List<int>();
            }
            foreach (var i in dic)
            {
                frequency[i.Value].Add(i.Key);
            }
            List<int> topFrequency = new List<int> ();
            int counter = 0;
            for (int i = nums.Length ; i >= 0; i--)
            {
                
                if (frequency[i].Count != 0)
                {
                    topFrequency.AddRange(frequency[i]);
                    counter++;
                    if (counter == k) break;
                }
               
                
            }
            return topFrequency.ToArray();
        }
    }
}
