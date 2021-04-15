 using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    class SingleNumberClass
    {
        public int SingleNumber(int[] nums)
        {
            Dictionary<int, int> r = new Dictionary<int, int>();
            for(int i=0;i<nums.Length;i++)
            {
                if(r.ContainsKey(nums[i]))
                {
                    r[nums[i]]++;
                }
                else
                {
                    r.Add(nums[i], 1);
                }
            }
            foreach(var i in r)
            {
                if(i.Value==1)
                {
                    return i.Key;
                }
            }
            return 0;
        }
        
    }
}
