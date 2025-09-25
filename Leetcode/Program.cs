// See https://aka.ms/new-console-template for more information
using Leetcode.ArrayHashing;
using Leetcode.Stack;
using Leetcode.TwoPointers;

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


string s = "race ae car";
var pal = new ValidPalindrome();
bool b = pal.IsPalindrome(s);
Console.WriteLine(b);