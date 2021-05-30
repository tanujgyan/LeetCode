using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Amazon_Interview_Questions
{
    /// <summary>
    /// https://www.geeksforgeeks.org/given-binary-string-count-number-substrings-start-end-1/
    /// </summary>
    class CountOfSubstringsStartAndEndWith1
    {
        public int CountOfSubstrings(string s)
        {
            int counter = 0;
            int inputLength = s.Length;
            for(int i=0;i< inputLength; i++)
            {
                if(s[i]=='1')
                {
                    counter++;
                }
            }
            return counter * (counter - 1) / 2;
        }
    }
}
