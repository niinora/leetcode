using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Stack
{
    internal class DailyTemperatures
    {
        public int[] DailyTemperatures1(int[] temperatures)//with tuples, not efficent
        {
            int[] answer = new int[temperatures.Length];
            Stack<(int temp, int index)> stack = new Stack<(int temp, int index)> ();
            for(int i = 0; i<temperatures.Length; i++)
            {
                while(stack.Count() > 0 && temperatures[i] > stack.Peek().temp)
                {
                    var x = stack.Pop();
                    answer[x.index] = i - x.index;
                }
                stack.Push((temperatures[i], i));
            }
            return answer;
        }

        public int[] DailyTemperatures2(int[] temperatures)
        {
            int[] answer = new int[temperatures.Length];
            Stack<int> stack = new Stack<int>();  // when i initialised stack capacity by temperatures.Length it took 5-8ms more to run
            for(int i = 0; i<temperatures.Length; i++)
            {
                while(stack.Count>0 && temperatures[i] > temperatures[stack.Peek()])
                {
                    int x = stack.Pop();
                    answer[x] = i - x;
                }
                stack.Push(i);
            }
            return answer;
        }
    }
}
