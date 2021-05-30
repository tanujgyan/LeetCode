using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Amazon_Interview_Questions
{
    /// <summary>
    /// https://leetcode.com/problems/maximum-product-of-two-elements-in-an-array/
    /// </summary>
    class MaximumProductOfTwoElementsInArray
    {
        /// <summary>
        /// the idea is to find 4 numbers 2 max positives and 2 max negatives
        /// </summary>
        /// <param name="nums"></param>
        /// <returns></returns>
        public int MaxProduct(int[] nums)
        {
            int positive1 = Int32.MinValue;
            int positive2 = Int32.MinValue;
            int negative1 = Int32.MaxValue;
            int negative2 = Int32.MaxValue;
            for (int i=0;i<nums.Length;i++)
            {
                //positive numbers
                if(nums[i]>0)
                {
                    if(nums[i]>=positive1)
                    {
                        int temp = positive1;
                        positive1 = nums[i];
                        positive2 = temp;
                    }
                    else if(nums[i]<positive1 && nums[i]>positive2)
                    {
                        positive2 = nums[i];
                    }

                }
                //negative number
                if(nums[i]<0)
                {
                    if (nums[i] < negative1)
                    {
                        int temp = negative1;
                        negative1 = nums[i];
                        negative2 = temp;
                    }
                    else if (nums[i] > negative1 && nums[i] < negative2)
                    {
                        negative2 = nums[i];
                    }
                }
            }
            return Math.Max(positive2-1 * positive1-1, negative2 * negative1);
        }
    }
}
