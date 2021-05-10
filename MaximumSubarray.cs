using System;
using System.Collections.Generic;
using System.Text;

namespace DP
{
    class MaximumSubarray
    {
        public static int MaxSubArray(int[] nums)
        {
            int[] dparray = new int[nums.Length + 1];
            dparray[0] = 0;//this indicates that if we take 0 elements from array the max sum we can make is 0
            dparray[1] = nums[0];//this indicates that if we take the first element of input the sum will be input
            int result = nums[0];//initialize the result variable. if there is only one element in array the result will be this
            int inputLength = nums.Length;
            for(int i=1;i< inputLength; i++)
            {
                int maxSum = 0;
                //this loop will run only once because we have
                //to compare just against the previous value
                //its a contiguous subarray so we cannot skip indexes
                for (int j=i-1;j<i;j++)
                {
                    maxSum = Math.Max(dparray[j+1] + nums[i], nums[i]);
                }
                //here either the dparray value will be its own value or sum with the previous value
                //depending on which is bigger
                dparray[i+1] = maxSum;
                //keep track of results
                result = Math.Max(result, maxSum);
            }
            Console.WriteLine(result);
            return result;
        }
    }
}
