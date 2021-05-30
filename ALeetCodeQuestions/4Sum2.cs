using System;
using System.Collections.Generic;
using System.Text;
/// <summary>
/// https://leetcode.com/problems/4sum-ii/
/// </summary>
namespace ALQ
{
    /// <summary>
    /// The idea for this question is based on handling 2 arrays at a time and getting their sum
    /// Here we need to find a+b+c+d=0 which can also be written as a+b=-(c+d)
    /// So if we find a+b first and store it in a hashmap and then find c+d and check if an equal negative number exists in hashmap then we can say this
    /// combination will fit our requirements
    /// </summary>
    class _4Sum2
    {
        public int FourSumCount(int[] nums1, int[] nums2, int[] nums3, int[] nums4)
        {
            int count = 0;
            Dictionary<int, int> dict = new Dictionary<int, int>();
            for (int i = 0; i < nums1.Length; i++)
            {
                for (int j = 0; j < nums2.Length; j++)
                {
                    if (dict.ContainsKey(nums1[i] + nums2[j]))
                    {
                        dict[nums1[i] + nums2[j]]++;
                    }
                    else
                    {
                        dict.Add(nums1[i] + nums2[j], 1);
                    }
                }
            }
            for (int i = 0; i < nums3.Length; i++)
            {
                for (int j = 0; j < nums4.Length; j++)
                {
                    if (dict.ContainsKey(-1 * (nums3[i] + nums4[j])))
                    {
                        count += dict[-1 * (nums3[i] + nums4[j])];
                    }
                }
            }
            return count;
        }
    }
}
