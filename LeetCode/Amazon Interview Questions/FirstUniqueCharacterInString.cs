using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCode.Amazon_Interview_Questions
{
    /// <summary>
    /// https://leetcode.com/problems/first-unique-character-in-a-string/
    /// </summary>
    class FirstUniqueCharacterInString
    {
        public int FirstUniqChar(string s)
        {
            Dictionary<char, int> dict = new Dictionary<char, int>();
            for(int i=0;i<s.Length;i++)
            {
                if(!dict.ContainsKey(s[i]))
                {
                    dict.Add(s[i], i);
                }
                else if(dict.ContainsKey(s[i]))
                {
                    //represents a repeat char is already found
                    dict[s[i]] = -99;
                }
            }
            try
            {
                return dict.Values.First(x => x != -99);
            }
            //if no matching element is found return -1
            catch
            {
                return -1;
            }
        }
    }
}
