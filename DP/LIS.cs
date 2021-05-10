using System;
using System.Collections.Generic;
using System.Text;

namespace DP
{
    /// <summary>
    /// https://leetcode.com/problems/longest-increasing-subsequence/
    /// </summary>
    class LIS
    {
        public int CalculateLIS(int[] n)
        {
            int[] dparray = new int[n.Length+1];
            dparray[0] = 0;
            dparray[1] = 1;
            int result = 1;
            for(int i=1;i<n.Length;i++)
            {
                int maxval = 0;
                for(int j=0;j<i;j++)
                {
                    if(n[j]<n[i])
                    {
                       maxval = Math.Max(dparray[j+1],maxval);
                    }
                }
                dparray[i + 1] = maxval + 1;
                result = Math.Max(dparray[i + 1], result);
            }
            return result;
        }
    }
}
