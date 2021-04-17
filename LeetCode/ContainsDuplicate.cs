using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    /// <summary>
    /// https://leetcode.com/problems/contains-duplicate/
    /// </summary>
    class ContainsDuplicateClass
    {
        /// <summary>
        /// Parse the array and put the element in a dictionary.
        /// If element already exits return false
        /// if looping is done return true
        /// </summary>
        /// <param name="nums"></param>
        /// <returns></returns>
        public bool ContainsDuplicate(int[] nums)
        {
            Dictionary<int, int> dict = new Dictionary<int, int>();
            int i = 0;

            while(i<nums.Length)
            {
                if(dict.ContainsKey(nums[i]))
                {
                    return true;
                }
                else
                {
                    dict.Add(nums[i], i);
                }
                i++;
            }
            return false;
        }
    }
}
