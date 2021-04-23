using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Amazon_Interview_Questions
{
    class LongestCommonPrefix
    {
        public string LongestCommonPrefixMethod(string[] strs)
        {
            int j = 0;
            string longestCommonPrefix = "";
            
            while (true)
            {
                if(strs[0].Length<=j)
                {
                    return longestCommonPrefix;
                }
                string tempCommonPrefix = strs[0][j].ToString();
                for (int i = 0; i < strs.Length - 1; i++)
                {
                    if (strs[i].Length < j || strs[i+1].Length<j)
                    {
                        return longestCommonPrefix;
                    }

                    if (strs[i][j] == strs[i + 1][j])
                    {

                    }
                    else
                    {
                        return longestCommonPrefix;
                    }
                }
                longestCommonPrefix += tempCommonPrefix;
                j++;
            }
        }
    }
}
