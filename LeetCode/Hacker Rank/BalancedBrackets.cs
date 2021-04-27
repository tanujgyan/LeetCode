using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Hacker_Rank
{
    class BalancedBrackets
    {
        public static string isBalanced(string s)
        {
            Stack<char> stack = new Stack<char>();
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == '(' || s[i] == '{' || s[i] == '[')
                {
                    stack.Push(s[i]);
                }
                else if (s[i] == ')')
                {
                    if (stack.Count==0 || stack.Pop() != '(')
                    {
                        return "NO";
                    }
                }
                else if ( s[i] == ']')
                {
                    if (stack.Count == 0 || stack.Pop() != '[')
                    {
                        return "NO";
                    }
                }
                else if ( s[i] == '}')
                {
                    if (stack.Count == 0 || stack.Pop() != '{')
                    {
                        return "NO";
                    }
                }
            }
            if (stack.Count == 0)
                return "YES";
            return "NO";
        }
    }
}
