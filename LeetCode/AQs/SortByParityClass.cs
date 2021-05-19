using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Amazon_Interview_Questions
{
    class SortByParityClass
    {
        /// <summary>
        /// https://leetcode.com/problems/k-closest-points-to-origin/
        /// </summary>
        /// <param name="A"></param>
        /// <returns></returns>
        public int[] SortArrayByParity(int[] A)
        {
            int start = -1;
            int end = A.Length;
            int[] result = new int[end];
            for(int i=0;i<A.Length;i++)
            {
                //if even add it to start
                if(A[i]%2==0)
                {
                    result[++start] = A[i];
                }
                //if odd add it to end
                else
                {
                    result[--end] = A[i];
                }
            }
            return result;
        }
    }
}
