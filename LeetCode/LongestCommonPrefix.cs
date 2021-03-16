using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    class LongestCommonPrefix
    {
        public string FindLongestCommonPrefix(string[] strs)
        {
            if(strs.Length==0)
            {
                return "";
            }
            string firstString = strs[0];
            int flag = 0;
            string longestCommonPrefix = "";
            for (int i = 0; i < firstString.Length; i++)
            {
               foreach(string s in strs)
                {
                    if(i<s.Length && s[i]==firstString[i])
                    {

                    }
                    else
                    {
                        flag = 1;
                        break;
                    }
                }
                if(flag==0)
                {
                    longestCommonPrefix = longestCommonPrefix + firstString[i];
                }
                else
                {
                    return longestCommonPrefix;
                }
            }
            return longestCommonPrefix;

        }
    }
}
