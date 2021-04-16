using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    /// <summary>
    /// https://leetcode.com/problems/majority-element/
    /// </summary>
    class MajorityElementClass
    {
        public int MajorityElement(int[] nums)
        {
            int? majorityElement = null;
            int sum = 0;
            Array.Sort(nums);
            for(int i=0;i<nums.Length;i++)
            {
                if(majorityElement==null)
                {
                    majorityElement = nums[i];
                    sum++;
                }
                else if(majorityElement==nums[i])
                {
                    sum++;
                }
                else if(majorityElement!=nums[i])
                {
                    
                    sum = 0;
                    sum++;
                    majorityElement = nums[i];
                }
                if (sum > nums.Length / 2)
                {
                    return nums[i];
                }


            }
            return 0;

        }
    }
}
