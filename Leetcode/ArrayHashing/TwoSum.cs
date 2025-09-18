using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.ArrayHashing
{
    internal class TwoSum
    {
        public int[] TwoSum1(int[] nums, int target)
        {
            Array.Sort(nums);
            int p1 = 0;
            int p2 = nums.Length - 1;
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[p1] + nums[p2] == target) return [nums[p1], nums[p2]];
                else if (nums[p1] + nums[p2] < target) p1++;
                else p2--;
            }
            throw new Exception("complements not found!");
        }
        // First solution works well but hat little problem which is returning first array indexes it returns numbers from sorted array so its
        // indexes won't match. second solution doesn't have this problem.

        public int[] TwoSum2(int[] nums, int target) 
        {
            Dictionary<int, int> dic = new Dictionary<int, int>();
            for (int i = 0; i< nums.Length; i++)
            {
                if (dic.ContainsKey(target-nums[i]))
                {
                    return [dic[target - nums[i]], i];
                }
                dic[nums[i]] = i;
            }
            throw new Exception("complements not found!");
        }
    }
}
