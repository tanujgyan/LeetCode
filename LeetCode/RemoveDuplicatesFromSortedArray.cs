using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace LeetCode
{
    public class RemoveDuplicatesFromSortedArray
    {
        public int RemoveDuplicates(int[] nums)
        {
            int j = 0, i = 0, sum = 0;
            if (nums.Length >= 1)
                sum++;
           while(i<nums.Length && j<nums.Length)
            {
                if (j == i)
                {
                    j = i + 1;
                    if (j >= nums.Length)
                        break;
                }
                if(nums[i]!=nums[j])
                {
                    nums[++i] = nums[j];
                    j++;
                    sum++;
                }
                else
                {
                    j++;
                }
            }

            return sum;
        }
    }
}
