using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Stack
{
    internal class LargestRectangleInHistogram
    {
        public int LargestRectangleArea1(int[] heights)//with tuples, but actually i dont need tuple, saving indices in stack is enough
        {
            Stack<(int height, int index)> stack = new Stack<(int height, int index)>();
            int maxArea = 0;
            for(int i = 0; i < heights.Length; i++)
            {
                while(stack.Count > 0 && stack.Peek().height > heights[i])
                {
                    var x =stack.Pop();
                    if(stack.Count>0) maxArea=Math.Max(maxArea, x.height * (i - stack.Peek().index-1));
                    else maxArea=Math.Max(maxArea,x.height*i);
                }
                stack.Push((heights[i], i));
            }
            while(stack.Count > 0)
            {
                var x = stack.Pop();
                if (stack.Count > 0) maxArea = Math.Max(maxArea, x.height * (heights.Length - x.index-1));
                else maxArea = Math.Max(maxArea, x.height*heights.Length);
            }
            return maxArea;
        }
        public int LargestRectangleArea2(int[] heights)//if we just add 0 as the last element in tha stack we won't need extra cleanup which is extra while loop 
        {
            Stack<int> stack = new Stack<int>();
            int maxArea = 0;
            for(int i = 0; i <= heights.Length; i++)
            {
                int currentHeight = (i == heights.Length) ? 0 : heights[i];
                while (stack.Count>0 && heights[stack.Peek()] > currentHeight)
                {
                    int height = heights[stack.Pop()];
                    int width = (stack.Count > 0) ? i - stack.Peek() - 1 : i;
                    maxArea = Math.Max(maxArea, height*width);
                }
                stack.Push(i);
            }
            return maxArea;
        }
    }
}
