using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCode.Amazon_Interview_Questions
{
    class FirstAndLastOfArray
    {
        SortedSet<int> res = new SortedSet<int>();
        public int[] SearchRange(int[] nums, int target)
        {

            int[] arr = new int[2];
            if (res.Count > 0)
            {
                arr[0] = res.ElementAt(0);
                arr[1] = res.ElementAt(res.Count - 1);
            }
            else
            {
                arr[0] = -1;
                arr[1] = -1;
            }
            return arr;
        }
        private void SearchRangeHelper(int[] nums, int target, int low, int high)
        {
            if (low > high)
            {
                return;
            }
            int mid = (low + high) / 2;

            if (nums[mid] == target)
            {
                if (res.Count == 0)
                {
                    int tempMid = mid;
                    while (tempMid >= 0 && nums[tempMid] == nums[mid])
                    {
                        --tempMid;
                    }
                    res.Add(tempMid + 1);
                    tempMid = mid + 1;
                    while (tempMid <= nums.Length - 1 && nums[tempMid] == nums[mid])
                    {
                        ++tempMid;
                    }
                    res.Add(tempMid - 1);
                }
                return;
            }
            if (nums[mid] < target)
            {
                SearchRangeHelper(nums, target, mid + 1, high);
            }
            if (nums[mid] > target)
            {
                if (low == mid)
                    return;
                SearchRangeHelper(nums, target, low, mid);
            }
        }
    }
}
