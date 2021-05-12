using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace LeetCode.Amazon_Interview_Questions
{
    class GenerateParanthesis
    {
        Dictionary<string, bool> cache = new Dictionary<string, bool>();
        List<string> ans = new List<string>();
        public IList<string> GenerateParenthesis(int n)
        {
            StringBuilder sb = new StringBuilder();
            Dictionary<string, bool> result = new Dictionary<string, bool>();


            //create our initial string
            for (int i = 0; i < n; i++)
            {
                sb.Append("()");
            }
            GeneratePermutations(sb, 0, n * 2 - 1, result);
          
            return ans;
        }
        private string GeneratePermutations(StringBuilder sb, int start, int end, Dictionary<string, bool> result)
        {

            if (start == end)
            {
                Console.WriteLine(sb);
                //cache.Add(sb.ToString());
                if (!result.ContainsKey(sb.ToString()))
                {
                    if (IsValidCombination(sb))
                    {
                        result.Add(sb.ToString(), true);
                        ans.Add(sb.ToString());
                    }
                    else
                    {
                        result.Add(sb.ToString(), false);
                    }
                }


            }
            for (int i = start; i <= end; i++)
            {
                sb = Swap(sb, start, i);
                if (!cache.ContainsKey(sb.ToString()))
                {
                    var r = GeneratePermutations(sb, start + 1, end, result);
                    if(!cache.ContainsKey(r))
                    cache.Add(r, true);
                }
                sb = Swap(sb, start, i);
            }
            return sb.ToString();

        }
        private StringBuilder Swap(StringBuilder sb, int p1, int p2)
        {
            char temp = sb[p1];
            sb[p1] = sb[p2];
            sb[p2] = temp;
            return sb;
        }
        private bool IsValidCombination(StringBuilder sb)
        {
            Stack<char> s = new Stack<char>();
            int inputLength = sb.Length;
            for (int i = 0; i < inputLength; i++)
            {
                if (sb[i] == '(')
                {
                    s.Push(sb[i]);
                }
                else if (sb[i] == ')')
                {
                    if (s.Count > 0)
                    {
                        s.Pop();
                    }
                    else
                    {
                        return false;
                    }
                }
            }
            if (s.Count > 0)
            {
                return false;
            }
            return true;
        }
    }
}
