using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Code_Line
{
    class WordPatternClass
    {
        public bool WordPattern(string pattern, string s)
        {
            Dictionary<char, List<int>> dict = new Dictionary<char, List<int>>();
            int pLength = pattern.Length;
            string[] input = s.Split(" ");
            if(input.Length!=pattern.Length)
            {
                return false;
            }
            //this will contain all the unique words of pattern
            HashSet<string> counter = new HashSet<string>();
            for(int i=0;i< pLength; i++)
            {
                if (!dict.ContainsKey(pattern[i]))
                {
                    dict.Add(pattern[i], new List<int>() { i });
                    counter.Add(input[i]);
                }
                else
                {
                    dict[pattern[i]].Add(i);
                    var val = dict[pattern[i]][0];
                    if(input[val]!=input[i])
                    {
                        return false;
                    }
                }
            }
            //the count of dictionary and number of unique words should be same
            if(dict.Count!=counter.Count)
            {
                return false;
            }
            return true;
        }
    }
}
