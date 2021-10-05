using System;
using System.Collections.Generic;
using System.Text;

namespace StudyPlan
{
    class BinarySearch
    {
        public int Search(int[] nums, int target)
        {
            int low = 0;
            int high = nums.Length - 1;
            if(low==high && nums[low]==target)
            {
                return low;
            }
            int mid = (low + high) / 2;
            while(low<=high)
            {
                if(target==nums[mid])
                {
                    return mid;
                }
                else if(target<nums[mid])
                {
                    high = mid-1;
                }
                else if(target>nums[mid])
                {
                    low = mid+1;
                }
                mid = (low + high) / 2;
            }
            return -1;
        }
    }
}
