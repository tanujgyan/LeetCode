using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    class ThirdMaxClass
    {
        /// <summary>
        /// https://leetcode.com/problems/third-maximum-number/
        /// </summary>
        /// <param name="nums"></param>
        /// <returns></returns>
        public int ThirdMax(int[] nums)
        {
            SortedSet<int> vs = new SortedSet<int>();
            for(int i=0;i<nums.Length;i++)
            {
                if(vs.Count < 3)
                {
                    vs.Add(nums[i]);
                }
                else if(vs.Count==3)
                {
                    if(nums[i]>vs.Min && !vs.Contains(nums[i]))
                    {
                        vs.RemoveWhere(x => x == vs.Min);
                        vs.Add(nums[i]);
                    }
                }
            }
            if (vs.Count < 3)
                return vs.Max;
            return vs.Min;
        }
    }
}
