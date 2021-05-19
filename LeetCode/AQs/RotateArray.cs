using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Amazon_Interview_Questions
{
    /// <summary>
    /// https://leetcode.com/problems/rotate-array/
    /// </summary>
    class RotateArray
    {
     /// <summary>
     /// this is solved using an algorithm
     /// 1. step 1 is divide the array in two parts - part 1 from 0 to totalcount - k
     /// so if there are 7 elements and have to rotate it by 2 the first part will be 5 elements so index 0 to 4
     /// Step 2: divide the rest of elements into second array
     /// Step 3: reverse array 1 and array 2
     /// Step 4: reverse whole array
     /// </summary>
     /// <param name="nums"></param>
     /// <param name="k"></param>
        public void Rotate(int[] nums, int k)
        {
            int inputLength = nums.Length;
            //calculate the actual rotation needed.
            k %= inputLength;
           
                Array.Reverse(nums, 0, nums.Length - k);
                Array.Reverse(nums, nums.Length - k, k);
         
            Array.Reverse(nums);
        }

    }
}
