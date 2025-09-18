using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.ArrayHashing
{
    internal class LongestConsecutiveSequence
    {
        public int LongestConsecutive(int[] nums)
        {
            HashSet<int> set = new HashSet<int>(nums);
            int max = 0;
            foreach (int x in set)
            {
                int counter = 1;
                if (!set.Contains(x - 1))
                {
                    while (set.Contains(x + counter)) counter++;
                    if (counter > max) max = counter;
                    counter = 1;
                }
            }
            return max;
        }
    }
}
