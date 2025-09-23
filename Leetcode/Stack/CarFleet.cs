using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Stack
{
    internal class CarFleet
    {
        public int CarFleet1(int target, int[] position, int[] speed) //we can do the same with tuples(position, speed) insted of dictionary, and use LINQ to sort tuples bu position
        {
            Stack<double> stack = new Stack<double>();
            SortedDictionary<int, int> dic = new SortedDictionary<int, int>();
            for(int i = 0; i<position.Length; i++)
            {
                if (dic.ContainsKey(position[i]))
                {
                    if (dic[position[i]] > speed[i])
                    {
                        dic[position[i]] = speed[i];
                    }
                }
                else dic[position[i]] = speed[i];

            }
            foreach(var x in dic.Reverse())
            {
                var hours = (double)(target - x.Key) / x.Value;
                if (stack.Count == 0)
                {
                    stack.Push(hours); 
                    continue;
                }
                if(stack.Peek() < hours) stack.Push(hours);

            }
            return stack.Count;
        }

        public int CarFleet2(int target, int[] position, int[] speed) //as I observed, using float was 15ms quicker than double
        {
            float[] allPositions = new float[target];
            for (int i = 0; i < position.Length; i++)
            {
                allPositions[position[i]] = (float)(target - position[i]) / speed[i];
            }
            double previousFleet = 0;
            int fleesCount = 0;
            for(int i = target-1; i >= 0; i--)
            {
                if (allPositions[i] > previousFleet)
                {
                    previousFleet = allPositions[i];
                    fleesCount++;
                }
            }
            return fleesCount;
        }
    }
}
