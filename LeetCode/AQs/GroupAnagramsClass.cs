using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
/// <summary>
/// https://leetcode.com/problems/group-anagrams/
/// </summary>
namespace LeetCode.Amazon_Interview_Questions
{
    /// <summary>
    /// The idea behind this algorithm is to sort and check if the sorted string exists as key already, if yes
    /// then add it as value otherwise add a new key
    /// </summary>
    class GroupAnagramsClass
    {
        public IList<IList<string>> GroupAnagrams(string[] strs)
        {
            Dictionary<string, List<string>> dict = new Dictionary<string, List<string>>();
            List<IList<string>> groupAnagrams = new List<IList<string>>();
            for (int i = 0; i < strs.Length; i++)
            {
                var s = String.Concat(strs[i].OrderBy(c => c));
                if (!dict.ContainsKey(s))
                {
                    dict.Add(s, new List<string>() { strs[i] });
                }
                else
                {
                    dict[s].Add(strs[i]);
                }
            }


            return new List<IList<string>>(dict.Values);
        }
    }
}
