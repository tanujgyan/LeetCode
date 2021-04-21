using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Amazon_Interview_Questions
{
    /// <summary>
    /// https://leetcode.com/problems/power-of-two/
    /// </summary>
    class PowerOfTwo
    {
        public bool IsPowerOfTwo(int n)
        {
            //2 to the power 0 is 1
            if (n == 1)
            {
                return true;
            }
            //quick check to filter out odd numbers and 0
            if (n % 2 != 0 || n == 0)
            {
                return false;
            }

            while (n != 1)
            {
                if (n % 2 == 0)
                {
                    n /= 2;
                }
                else
                {
                    return false;
                }
            }
            return true;
        }
    }
}
