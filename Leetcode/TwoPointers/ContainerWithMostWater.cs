using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.TwoPointers
{
    internal class ContainerWithMostWater
    {
        public int MaxArea(int[] height)
        {
            int left = 0;
            int right = height.Length - 1;
            int maxContainer = 0;
            int currentContainer;
            for(int i=0; i<height.Length; i++)
            {
                currentContainer = (right - left) * Math.Min(height[left], height[right]);
                maxContainer = maxContainer < currentContainer ? currentContainer : maxContainer;
                if (height[left] <= height[right]) left++;
                else right--;
            }
            return maxContainer;
        }
    }
}
