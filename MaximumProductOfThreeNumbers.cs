using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    /// <summary>
    /// https://leetcode.com/problems/maximum-product-of-three-numbers/
    /// </summary>
    class MaximumProductOfThreeNumbers
    {
        public int MaximumProduct(int[] nums)
        {
            
            if (nums.Length==3)
            {
                return nums[0] * nums[1] * nums[2];
            }
           
            int[] max = new int[3] { -1002, -1002, -1002 };
            //we have to find last two mins as product of two negative numbers is positive and depending on the absolute values of 
            //negative numbers they can make bigger product than just largest positive numbers
            int[] min = new int[2] { 1002,1002};
            for (int i = 0; i < nums.Length; i++)
            {
                //find the last two mins
                if(nums[i]<=min[0])
                {
                    min[1] = min[0];
                    min[0] = nums[i];
                }
                else if(nums[i]>min[0] && nums[i]<min[1])
                {
                    min[1] = nums[i];
                }
                //find last three max
                if (nums[i] >= max[0])
                {
                    max[2] = max[1];
                    max[1] = max[0];
                    max[0] = nums[i];
                }
                else if (nums[i] < max[0] && nums[i] >= max[1])
                {
                    max[2] = max[1];
                    max[1] = nums[i];
                }
                else if (nums[i] < max[1] && nums[i] > max[2])
                {
                    max[2] = nums[i];
                }

            }
            //check which one is bigger
            return Math.Max(max[0] * max[1] * max[2], max[0] * min[0] * min[1]);

        }
    }
}
