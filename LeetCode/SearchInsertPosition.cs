using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    public class SearchInsertPosition
    {
        /// <summary>
        /// Check first two edge cases if target is the smallest number or target is the largest number
        /// Then start parsing the array and see if target is found if not check if target is greater than next number continue if true
        /// If not true it means target is either the next number or lies in between the current index and next index
        /// </summary>
        /// <param name="nums"></param>
        /// <param name="target"></param>
        /// <returns></returns>
        public int SearchInsert(int[] nums, int target)
        {
            if (target < nums[0])
            {
                return 0;
            }
            if (target > nums[nums.Length - 1])
            {
                return nums.Length;
            }
            for(int i=0;i<nums.Length;i++)
            {
                if (target == nums[i])
                {
                    return i;
                }
                else if(target>nums[i])
                {
                    if(target>nums[i+1])
                    {
                        continue;
                    }
                    else
                    {
                        return i + 1;
                    }
                }
            }
            return -99;
           
            
        }
    }
}
