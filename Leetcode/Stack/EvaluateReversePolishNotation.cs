using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Stack
{
    internal class EvaluateReversePolishNotation
    {
        public int EvalRPN(string[] tokens)
        {
            Stack<int> stack = new Stack<int>();
            int result=0;
            int temp = 0;
            if (tokens.Length == 1) return int.Parse(tokens[0]);
            foreach(string token in tokens)
            {
                switch (token)
                {
                    case "+": 
                        result = stack.Pop() + stack.Pop(); 
                        stack.Push(result);
                        break;
                    case "-":
                        temp = stack.Pop();
                        result = stack.Pop() - temp;
                        stack.Push(result);
                        break;
                    case "*":
                        result = stack.Pop() * stack.Pop();
                        stack.Push(result);
                        break;
                    case "/":
                        temp = stack.Pop();
                        result = stack.Pop() / temp;
                        stack.Push(result);
                        break;
                    default:
                        stack.Push(int.Parse(token));
                        break;
                }
            }
            return result;
        }
    }
}
