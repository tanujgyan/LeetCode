using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCode
{
    /// <summary>
    /// https://leetcode.com/problems/minimum-deletions-to-make-character-frequencies-unique/
    /// Microsoft Interview Question
    /// </summary>
    class MinDeletionUniqueString
    {
        /// <summary>
        /// Add all the elements to dictionary with key as character and value as frequency
        /// Iterate over each element of dict and inside the inner while check for elements that has same frequency as current element
        /// decrement the current element frequency and check again till it reaches 0 or becomes unique.
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public int MinDeletions(string s)
        {
            Dictionary<char, int> dict = new Dictionary<char, int>();
            for(int i=0;i<s.Length;i++)
            {
                if(!dict.ContainsKey(s[i]))
                {
                    dict.Add(s[i], 1);
                }
                else
                {
                    dict[s[i]]++;
                }
            }
            int sum = 0;
            for (int i = 0; i < dict.Count; i++)
            {
                while(dict.ElementAt(i).Value!=0)
                {
                    if (dict.Count(x => x.Value == dict.ElementAt(i).Value)>1)
                    {
                        dict[dict.ElementAt(i).Key]--;
                        sum++;
                    }
                    else
                    {
                        break;
                    }
                }
            }
            return sum;
        }
    }
}
