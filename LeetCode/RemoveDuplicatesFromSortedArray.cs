using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace LeetCode
{

    public class RemoveDuplicatesFromSortedArray
    {
        /// <summary>
        /// The idea is to take two pointers i and j.
        /// Initialize j with i+1. this is where we start looping
        /// keep increasing j by 1 till we find a num[j] which is not equal to num[i]. Once found
        /// copy num[j] to num[i+1] and move the pointer i to next number. 
        /// Keep increasing j till we reach another mismatch and repeat the process.
        /// </summary>
        /// <param name="nums"></param>
        /// <returns></returns>
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
