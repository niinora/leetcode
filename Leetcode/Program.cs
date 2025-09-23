// See https://aka.ms/new-console-template for more information
using Leetcode.ArrayHashing;
using Leetcode.Stack;

//Console.WriteLine(11%9*4);

//var enc = new encodeanddecodestrings();
//list<string> ne = new list<string>() { "neet", "code", "love", "you" };
//string test = enc.encode(ne);
//console.writeline(test);
//foreach (string s in enc.decode2(test))
//{
//    console.writeline(s);
//}
//var postfix = new EvaluateReversePolishNotation();
//string[] arr = { "10", "6", "9", "3", "+", "-11", "*", "/", "*", "17", "+", "5", "+" };

//Console.WriteLine(postfix.EvalRPN(arr));


int[] arr = new int[] { 1, 2, 3 };
Stack<int> stack = new Stack<int>(arr);
Console.WriteLine(stack.Peek());