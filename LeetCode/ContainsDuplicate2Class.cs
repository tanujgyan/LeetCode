using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    /// <summary>
    /// https://leetcode.com/problems/contains-duplicate-ii/
    /// Given an integer array nums and an integer k, return true 
    /// if there are two distinct indices i and j in the array such that nums[i] == nums[j] and abs(i - j) <= k.
    /// </summary>
    class ContainsDuplicate2Class
    {
        /// <summary>
        /// Create a dictionary
        /// Iterate through array and if the value is not in dictionary add it with key as value and value as index
        /// If key is found check if value-currentindex<=k. Return true if yes
        /// otherwise delete the key and add it again with new value as current index
        /// </summary>
        /// <param name="nums"></param>
        /// <param name="k"></param>
        /// <returns></returns>
        public bool ContainsNearbyDuplicate(int[] nums, int k)
        {
            Dictionary<int, int> dict = new Dictionary<int, int>();
            for(int i=0;i<nums.Length;i++)
            {
                if(!dict.ContainsKey(nums[i]))
                {
                    dict.Add(nums[i], i);
                }
                else
                {
                    if(Math.Abs(dict[nums[i]]-i)<=k)
                    {
                        return true;
                    }
                    else
                    {
                        dict.Remove(nums[i]);
                        dict.Add(nums[i], i);
                    }
                }
            }
            return false;
            
           
        }
    }
}
