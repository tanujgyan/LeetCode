using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
/// <summary>
/// https://leetcode.com/problems/find-the-smallest-divisor-given-a-threshold/
/// </summary>
namespace ALQ
{
    class SmallestDivisorClass
    {
        public int SmallestDivisor(int[] nums, int threshold)
        {
            int result = 0;
            double total = nums.ToList().Sum();
            if(threshold>=total)
            {
                return 1;
            }
            int largest = Int32.MaxValue;
            Array.Sort(nums);
            double divisor = Math.Ceiling(total / threshold);
            double divisorSum = 0;
            int start = 0;
            do
            {
                
               
                
                for (int i = start; i < nums.Length; i++)
                {
                    if (nums[i] <= divisor)
                    {
                        divisorSum++;
                    }
                    else
                    {
                        if (largest == Int32.MaxValue)
                        {
                            largest = i-1;
                        }
                        divisorSum += Math.Ceiling(nums[i] / divisor);
                    }
                }
                if (divisorSum <= threshold)
                {
                    result = (int)divisor;
                    break;
                }
                else
                {
                    divisor = nums[largest + 1];
                    start = largest+1;
                    divisorSum = largest + 1;
                    largest++;
                }
            } while (true);
            return result;
        }
    }
}
