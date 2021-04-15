using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    class TwoSumArraySortedInput
    {
        public int[] TwoSum(int[] numbers, int target)
        {
           // int[] result = new int[2];
            int i = 0, j = numbers.Length - 1;
            while(true)
            {
                if(i>=j)
                {
                    break;
                }
                else if(numbers[i]+numbers[j]==target)
                {
                    return new int[] { i + 1, j + 1 };
                }
                else if(numbers[i] + numbers[j] > target)
                {
                    j--;
                }
                else
                {
                    i++;
                }
            }
            return new int[] { };
        }
    }
}
