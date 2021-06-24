using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCode.Amazon_Interview_Questions
{
    /// <summary>
    /// https://leetcode.com/problems/first-missing-positive/
    /// </summary>
    class FirstMissingPositiveClass
    {
        /// <summary>
        /// The idea of algorithm is to use a dictionary to keep track of positive integers we see
        /// Take a dict and initialize it with positive integers starting from 1 till lenght of array
        /// Parse the array from left to right and every positive integer found in array is marked as true in dict
        /// Once array parsing is done filter the dict to find the first element with false value
        /// </summary>
        /// <param name="nums"></param>
        /// <returns></returns>
        public int FirstMissingPositive(int[] nums)
        {
            Dictionary<int, bool> dict = new Dictionary<int, bool>();
            int inputLength = nums.Length;
            //initialize the dictionary with one extra value then the count of array
            //this will handle cases like [1]
            for (int i = 1; i <= inputLength+1; i++)
            {
                dict.Add(i, false);
            }
            //if we find the element in the input and also in dictionary mark it as true
            for(int i=0;i<inputLength;i++)
            {
                if(nums[i]>0)
                {
                    if(dict.ContainsKey(nums[i]))
                    {
                        dict[nums[i]] = true;
                    }
                }
            }
            //find the first dictionary key with value as false
            var val = dict.FirstOrDefault(x => x.Value == false);
            if(val.Key==0)
            {
                return 1;
            }
            return val.Key;
        }
    }
}
