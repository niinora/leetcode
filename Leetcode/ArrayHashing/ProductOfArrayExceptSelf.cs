using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.ArrayHashing
{
    internal class ProductOfArrayExceptSelf
    {
        public int[] ProductExceptSelf(int[] nums)
        {
            int[] result = new int[nums.Length];
            result[0] = 1;
            for(int i= 0; i<nums.Length-1; i++)
            {
                result[i+1] = result[i] * nums[i];
            }
            int temp=1;
            for (int i = nums.Length-1; i >0; i++)
            {
                temp = temp * nums[i];
                result[i - 1] = result[i-1] * temp;
            }
            return result;
        }
    }
}
