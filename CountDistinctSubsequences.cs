using System;
using System.Collections.Generic;
using System.Text;

namespace DP
{
    /// <summary>
    /// https://leetcode.com/problems/distinct-subsequences/
    /// </summary>
    class CountDistinctSubsequences
    {
        /// <summary>
        /// This is based on LCS. The tabulation algorithm will be a little different
        /// We will initialize first row as 1. This is based on logic that if t is an empty string then the number of distinct 
        /// subsets of t in s will be 1
        /// The first column will be 0 as usual because if we dont have a s then we can't use anything from t to create subset.
        /// The filling logic will be if we find a matching char then we need to look for number of that matching char previously and
        /// also the number above it previously because both these boxes will contribute to the total number of subsequences
        /// If we dont find a matching char then we simply copy the number behind it because the current char wont contribute to the result
        /// </summary>
        /// <param name="s"></param>
        /// <param name="t"></param>
        /// <returns></returns>
        public int NumDistinct(string s, string t)
        {
            int rowLength = t.Length;
            int columnLength = s.Length;
            int[,] dpMatrix = new int[rowLength + 1, columnLength + 1];
            for(int i=0;i<rowLength+1;i++)
            {
                for(int j=0;j<columnLength+1;j++)
                {
                    if(i==0)
                    {
                        dpMatrix[i,j] = 1;
                    }
                    if(j==0 && i!=0)
                    {
                        dpMatrix[i, j] = 0;
                    }
                }
            }
            for(int i=1;i<rowLength+1;i++)
            {
                for(int j=1;j<columnLength+1;j++)
                {
                    if(s[j-1]==t[i-1])
                    {
                        dpMatrix[i, j] = dpMatrix[i - 1, j - 1] + dpMatrix[i, j - 1];
                    }
                    else
                    {
                        dpMatrix[i, j] = dpMatrix[i, j - 1];
                    }
                }
            }
            return dpMatrix[rowLength, columnLength];
        }
    }
}
