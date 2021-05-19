using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Amazon_Interview_Questions
{
    /// <summary>
    /// https://leetcode.com/problems/replace-elements-with-greatest-element-on-right-side/
    /// </summary>
    class ReplaceElementFromRight
    {
        /// <summary>
        /// the idea is that the first element will always be replaced.Create an empty array of same length
        /// start parsing the arr from 2nd element (index 1). If arr[i]>result[j] replace
        /// the inner for loop will run 1 less than i because you can only replace elements on left excluding the element you are on
        /// return result
        /// </summary>
        /// <param name="arr"></param>
        /// <returns></returns>
        public int[] ReplaceElements(int[] arr)
        {
            int[] result = new int[arr.Length];
            for(int i=1;i<arr.Length;i++)
            {
                for(int j=0;j<i;j++)
                {
                    if(arr[i]>result[j])
                    {
                        result[j] = arr[i];
                    }
                }
            }
            result[result.Length - 1] = -1;
            return result;
        }
    }
}
