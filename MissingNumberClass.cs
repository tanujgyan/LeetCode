using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Amazon_Interview_Questions
{
    /// <summary>
    /// https://leetcode.com/problems/missing-number/
    /// </summary>
    class MissingNumberClass
    {
        public int MissingNumber(int[] nums)
        {
           
            int min = -1;
            int sum = nums[0];
            min = nums[0];
            for(int i=1;i<nums.Length;i++)
            {
               if(nums[i]<min)
                {
                    min = nums[i];
                }
                sum += nums[i];
            }
            //this is a special case when 0 is missing. since the number will always start from 0 so min should always be 0
            //if it is not that means 0 is missing.
            if(min!=0)
            {
                return 0;
            }
            //Arithematic progression sum formula
            //remember to take nums.Length+1 as there is a missing number
            int idealsum = Convert.ToInt32(((decimal)(nums.Length+1) / 2) * ((2 * min) + (nums.Length)));
            return idealsum - sum;
        }
    }
}
