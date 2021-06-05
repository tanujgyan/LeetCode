using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
/// <summary>
/// https://leetcode.com/problems/generate-parentheses/
/// </summary>
namespace LeetCode.Amazon_Interview_Questions
{
    /// <summary>
    /// My solution was to generate all possible pairs and then validate them. This goes into TLE on Leetcode
    /// Found a great solution which makes sense also
    /// The idea behind this solution is to add ( and ) only when needed to produce only correct pairs. The time complexity of this
    /// is hard to explain
    /// 
    /// public List<String> generateParenthesis(int n) {
//    List<String> list = new ArrayList<String>();
//    backtrack(list, "", 0, 0, n);
//        return list;
//    }

//public void backtrack(List<String> list, String str, int open, int close, int max)
//{

//    if (str.length() == max * 2)
//    {
//        list.add(str);
//        return;
//    }

//    if (open < max)
//        backtrack(list, str + "(", open + 1, close, max);
//    if (close < open)
//        backtrack(list, str + ")", open, close + 1, max);
//}
/// </summary>
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
            bool[] visited = new bool[sb.Length];
            GeneratePermutationsWithDFS(sb.ToString(), new StringBuilder(), -1, visited,result);
           // GeneratePermutations(sb, 0, n * 2 - 1, result);
          
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

        private void GeneratePermutationsWithDFS(string s, StringBuilder sb, int index, bool[] visited, Dictionary<string, bool> result)
        {
            if (index == s.Length - 1)
            {
                Console.WriteLine(sb.ToString());
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
                return;
            }

            for (int i = 0; i < s.Length; i++)
            {
                if (!visited[i])
                {
                    sb.Append(s[i]);
                    index++;
                    visited[i] = true;
                    GeneratePermutationsWithDFS(s, sb, index, visited,result);
                    visited[i] = false;
                    index--;
                    sb.Remove(sb.Length - 1, 1);
                }
            }
            
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
