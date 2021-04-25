using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCode.Amazon_Interview_Questions
{
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
