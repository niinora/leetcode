using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.ArrayHashing
{
    internal class ContainsDuplicate
    {
        public bool ContainsDuplicate1(int[] nums)
        {
            return new HashSet<int>(nums).Count != nums.Length;
        }

        public bool ContainsDuplicate2(int[] nums)
        {
            Array.Sort(nums);
            for(int i = 0; i<nums.Length-2; i++)
            {
                if (nums[i] == nums[i+1]) return true;
            }
            return false;
        }
    }
}
