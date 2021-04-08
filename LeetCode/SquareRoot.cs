using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    public class SquareRoot
    {
        /// <summary>
        /// The idea is to find the middle number and see if the square of the number is greater than or less than the input
        /// If it is greater than input that means the sqrt is less than middle number. Decrease the mid by 1 and assign it to high and continue
        /// If it is less than input that means sqrt is greater than middle number. Increase the mid by 1 and assign it to low and continue
        /// We have to keep going till low is less than high
        /// After coming out of loop get the integer of low and check low^2. If low^2 is less than or equal to input return low else return low-1
        /// </summary>
        /// <param name="x"></param>
        /// <returns></returns>
        public int Sqrt(int x)
        {
            long low = 0, high = x, mid;

            while (low < high)
            {
                mid = (low + high) / 2;
                long mul = mid * mid;

                if (mul == x)
                {
                    return (int)mid;
                }

                if (mul < x)
                {
                    low = mid + 1;
                }
                else
                {
                    high = mid - 1;
                }
            }

            int ans = (int)low;
            return (ans * ans <= x) ? ans : ans - 1;
        }
    }
}
