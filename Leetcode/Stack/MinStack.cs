using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Stack
{
    internal class MinStack
    {
        Stack<int> stack;
        Stack<int> mins;
        public MinStack()
        {
            stack = new Stack<int>();
            mins = new Stack<int>();
        }

        public void Push(int val)
        {
            stack.Push(val);
            if (mins.Count == 0) mins.Push(val);
            else mins.Push(Math.Min(mins.Peek(), val));
        }

        public void Pop()
        {
            stack.Pop(); 
            mins.Pop();
        }

        public int Top()
        {
            return stack.Peek();
        }

        public int GetMin()
        {
            return mins.Peek();
        }
        /**
         * Your MinStack object will be instantiated and called as such:
         * MinStack obj = new MinStack();
         * obj.Push(val);
         * obj.Pop();
         * int param_3 = obj.Top();
         * int param_4 = obj.GetMin();
         */
    }
}
