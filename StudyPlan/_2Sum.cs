using System;
using System.Collections.Generic;
using System.Text;

namespace StudyPlan
{
    class _2Sum
    {
        Dictionary<int, List<int>> dict = new Dictionary<int, List<int>>();
        public int[] TwoSum(int[] nums, int target)
        {
            CreateDictionary(nums);
            Array.Sort(nums);
            if(nums[0]>target)
            {
                return new int[2];
            }
            int low = 0;
            int high = nums.Length - 1;
            for(int i=0;i<nums.Length;i++)
            {
                
                
                if(nums[low]+nums[high]>target)
                {
                    high--;
                }
                else if(nums[low]+nums[high]<target)
                {
                    low++;
                }
                if(nums[low] + nums[high] == target)
                {
                    if(nums[low]==nums[high])
                    {
                        return new int[] { dict[nums[low]][0], dict[nums[low]][1] };
                    }
                    else
                    {
                        return new int[] { dict[nums[low]][0], dict[nums[high]][0] };
                    }
                }
            }
            return new int[2];
        }
        private void CreateDictionary(int[] nums)
        {
           for(int i=0;i<nums.Length;i++)
            {
                if(dict.ContainsKey(nums[i]))
                {
                    dict[nums[i]].Add(i);
                }
                else
                {
                    dict.Add(nums[i], new List<int>() { i });
                }
            }
        }
    }
}
