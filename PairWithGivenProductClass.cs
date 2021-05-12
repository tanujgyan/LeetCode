using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Amazon_Interview_Questions
{
    /// <summary>
    /// https://www.geeksforgeeks.org/pair-with-given-product-set-1-find-if-any-pair-exists/
    /// </summary>
    class PairWithGivenProductClass
    {
        public bool PairWithGivenProduct(int[] arr,int product)
        {
            Dictionary<int, int> dict = new Dictionary<int, int>();
            for(int i=0;i<arr.Length;i++)
            {
                if (product % arr[i] == 0)
                {
                    var key = product / arr[i];
                    if(dict.ContainsKey(arr[i]))
                    {
                        return true;
                    }
                    if (!dict.ContainsKey(key))
                    {
                        dict.Add(key, arr[i]);
                    }
                }
            }
            return false;
        }
    }
}
