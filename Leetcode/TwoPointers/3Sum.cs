using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.TwoPointers
{
    internal class _3Sum
    {
        public IList<IList<int>> ThreeSum(int[] nums)
        {
            List<IList<int>> triplets = new List<IList<int>>();
            Array.Sort(nums);
            int target;
            int left;
            int right = nums.Length - 1;
            for(int i=0; i<nums.Length; i++)
            {
                left = i + 1;             
                right = nums.Length - 1;
                target = -nums[i];
                if (i > 0 && nums[i] == nums[i - 1]) continue;
                while (left < right)
                {
                    if (nums[left] + nums[right] == target)
                    {
                        triplets.Add(new List<int>() { nums[i], nums[left], nums[right] });
                        while (left < right && nums[left] == nums[left + 1]) left++;
                        while (left < right && nums[right] == nums[right - 1]) right--;
                        left++;
                        right--;
                    }
                    else if (nums[left] + nums[right] < target) left++;
                    else right--;
                }
            }
            return triplets;
        }
    }
}
