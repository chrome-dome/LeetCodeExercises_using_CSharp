using System;
using System.Collections.Generic;

class Solution
{
    public bool IsValid(string s)
    {
        Stack<char> stack = new Stack<char>();
        foreach (char c in s)
        {
            if (c == '(' || c == '{' || c == '[')
            {
                stack.Push(c);
            }
            else
            {
                if (stack.Count == 0) return false;
                if (c == ')' && stack.Peek() != '(') return false;
                if (c == '}' && stack.Peek() != '{') return false;
                if (c == ']' && stack.Peek() != '[') return false;
                stack.Pop();
            }
        }
        return stack.Count == 0;
    }
}

class Program
{
    static void Main(string[] args)
    {
        Solution sol = new Solution();
        Console.WriteLine(sol.IsValid("()")); // true
        Console.WriteLine(sol.IsValid("()[]{}")); // true
        Console.WriteLine(sol.IsValid("(]")); // false
        Console.WriteLine(sol.IsValid("([)]")); // false
        Console.WriteLine(sol.IsValid("{[]}")); // true

        Console.ReadLine();
    }
}
