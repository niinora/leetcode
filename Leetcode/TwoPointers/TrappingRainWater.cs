using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.TwoPointers
{
    internal class TrappingRainWater
    {
        public int Trap(int[] height)
        {
            int[] prefixMax = new int[height.Length];
            int[] sufixMax = new int[height.Length];
            int max = 0;
            int trappedWatter = 0;
            for(int i=0; i<height.Length; i++)
            {
                max = Math.Max(max, height[i]);
                prefixMax[i] = max;
            }
            max = 0;
            for(int i = height.Length-1; i>=0; i--)
            {
                max=Math.Max(max, height[i]);
                sufixMax[i] = max;
            }
            for(int i=1; i<height.Length-1; i++)
            {
                trappedWatter+= Math.Min(prefixMax[i], sufixMax[i]) - height[i];
            }
            return trappedWatter;
        }
    }
}
