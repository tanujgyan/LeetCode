using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    public class RemoveElement
    {
        /// <summary>
        /// The idea is to start two pointers i and j with 0
        /// Start a loop and check if nums[i] is val and then check if nums[j] is not val
        /// if a match is found swap the numbers and continue
        /// if nums[i] is not val continue after increasing the sum, i and j
        /// </summary>
        /// <param name="nums"></param>
        /// <param name="val"></param>
        /// <returns></returns>
        public int RemoveElementMethod(int[] nums, int val)
        {
            int j = 0, i = 0, sum = 0;
            if (nums.Length == 1 && nums[0] != val)
                return ++sum;
            while (i < nums.Length && j < nums.Length)
            {
                if (nums[i]==val)
                {
                    if(nums[j]==val)
                    {
                        j++;
                        continue;
                    }
                    int temp = 0;
                    temp = nums[i];
                    nums[i] = nums[j];
                    nums[j] = temp;
                    ++i;
                    j++;
                    sum++;
                }
                else
                {
                    j++;
                    i++;
                    sum++;
                }
            }

            return sum;
        }
    }
}
