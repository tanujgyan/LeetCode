using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    class TwoSum
    {
        /// <summary>
        /// This is a brute force method and has a time complexity of O(n2)
        /// </summary>
        /// <param name="nums"></param>
        /// <param name="target"></param>
        /// <returns></returns>
        public int[] TwoSumCalculator(int[] nums, int target)
        {
            int[] result = new int[2];
            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = i + 1; j < nums.Length; j++)
                {
                    if (nums[i] + nums[j] == target)
                    {
                        result[0] = i;
                        result[1] = j;
                    }
                }
            }
            return result;
        }
        /// <summary>
        /// This has a time complexity of O(n)
        /// </summary>
        /// <param name="nums"></param>
        /// <param name="target"></param>
        /// <returns></returns>
        public int[] TwoSumCalculatorUsingDictionary(int[] nums, int target)
        {
            int[] result = new int[2];
            Dictionary<int, int> dict = new Dictionary<int, int>();
            for (int i = 0; i < nums.Length; i++)
            {
                if (dict.ContainsKey(target - nums[i] ))
                {
                    result[0] = dict[target - nums[i]];
                    result[1] = i;
                    break;
                }
                dict.Add(nums[i], i);
            }
            return result;
        }
    }
}
