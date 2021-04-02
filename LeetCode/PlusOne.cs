using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCode
{
    public class PlusOne
    {
        /// <summary>
        /// Check if last digit is 9.
        /// If yes set it to 0 and check for the second last and so on. If we find a digit less than 9 break the loop.
        /// Once out of the loop check for the first digit if it is 0 it means the number was all 9s because the input cant start from 0
        /// Add 1 to the start of list
        /// </summary>
        /// <param name="digits"></param>
        /// <returns></returns>
        public int[] PlusOneMethod(int[] digits)
        {
            List<int> l = digits.ToList();
            for (int i = l.Count - 1; i >= 0; i--)
            {
                if(l[i]==9)
                {
                    l[i] = 0;

                }
                else
                {
                    l[i] = l[i] + 1;
                    break;
                }
            }
            if(l[0]==0)
            {
                l.Insert(0, 1);
            }
            return l.ToArray();
        }
    }
}
