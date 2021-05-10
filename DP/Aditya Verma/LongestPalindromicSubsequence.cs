using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DP.Aditya_Verma
{
    /// <summary>
    /// https://leetcode.com/problems/longest-palindromic-subsequence/
    /// </summary>
    class LongestPalindromicSubsequence
    {
        /// <summary>
        /// The idea is to reverse the string and then run LCS algorithm
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public int LongestPalindromeSubseq(string s)
        {
            int inputLength = s.Length;
            char[] tempreverse = s.ToCharArray();
            Array.Reverse(tempreverse);
            string reverse = new string(tempreverse);
            int[][] dpMatrix = new int[inputLength+1][];
            for(int i=0;i<inputLength+1;i++)
            {
                dpMatrix[i] = new int[inputLength + 1];
                for(int j=0;j<inputLength+1;j++)
                {
                    if(i==0 || j==0)
                    {
                        dpMatrix[i][j] = 0;
                    }
                }
            }
            for (int i = 1; i < inputLength + 1; i++)
            {
                for (int j = 1; j < inputLength + 1; j++)
                {
                    if(s[i-1]==reverse[j-1])
                    {
                        dpMatrix[i][j] = 1 + dpMatrix[i - 1][j - 1];
                    }
                    else
                    {
                        dpMatrix[i][j] = Math.Max(dpMatrix[i - 1][j], dpMatrix[i][j - 1]);
                    }
                }
            }
            return dpMatrix[inputLength][inputLength];
        }
    }
}
