using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
/// <summary>
/// https://leetcode.com/discuss/interview-question/749799/Amazon-Interview-Vancouver
/// </summary>
namespace ALQ
{
    /// <summary>
    /// The idea behind this algorithm is to use DFS and backtracking.
    /// It will create all possible strings and keep matching them against target.
    /// Once a match is found it will stop processing.
    /// Note: I have created a stack to keep track of all combinations for debugging purposes. ITS NOT NEEDED FOR OUTPUT
    /// </summary>
    class BabyBlocksClass
    {
        bool matchFound = false;
        HashSet<string> s = new HashSet<string>();
        public void BabyBlocks(char[][] pairs, string target)
        {
            int k = 3;
            for (int i = 0; i < pairs.Length; i++)
            {
                BabyBlocksHelper(pairs, target, target.Length, new List<string>(), i, pairs.Length, k);
            }
        }
        private void BabyBlocksHelper(char[][] pairs, string target, int targetLength, List<string> sb, int index, int pairLength, int k)
        {
            //if(sb.Length>=targetLength)
            //{
            //    sb.ToString().Substring(sb.Length-targetLength,)
            //    CheckForMatch(target,)
            //}
            if (sb.Count == targetLength)
            {
                string temp = "";
                foreach (var e in sb)
                {
                    temp += e;
                }
                s.Add(temp);
               return;
            }
            else if(sb.Count>target.Length)
            {

            }
            if (matchFound)
            {
                return;
            }
            if (index >= pairLength)
            {
                return;
            }

            
            for (int i = 0; i < pairs[index].Length; i++)
            {
                    sb.Add(Convert.ToString(pairs[index][i]));
                    BabyBlocksHelper(pairs, target, targetLength, sb, index + 1, pairLength, k - 1);
                    sb.RemoveAt(sb.Count - 1);
            }



        }
        private void CheckForMatch(string target, string toBeMatched)
        {

        }
    }
}
