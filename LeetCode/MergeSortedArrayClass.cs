using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    //https://leetcode.com/problems/merge-sorted-array/
    public class MergeSortedArrayClass
    {
        /// <summary>
        /// Take a new array with length m+n
        /// Start comparing the elements of nums1 and nums2 and putting it in new array
        /// Once loop is completed check for any remaining items in nums1 or nums2 and copy them
        /// At the end copy new array to nums1
        /// 
        /// </summary>
        /// <param name="nums1"></param>
        /// <param name="m"></param>
        /// <param name="nums2"></param>
        /// <param name="n"></param>
        public void Merge(int[] nums1, int m, int[] nums2, int n)
        {
            int[] nums3 = new int[m + n];
            int i = 0;
            int j = 0;
            int k = 0;
            while(i<m && j<n)
            {
                if(nums1[i]<nums2[j])
                {
                    nums3[k] = nums1[i];
                    i++;
                    k++;
                }
                else if(nums2[j]<nums1[i])
                {
                    nums3[k] = nums2[j];
                    k++;
                    j++;
                }
                else if(nums1[i] == nums2[j])
                {
                    nums3[k] = nums1[i];
                    i++;
                    k++;
                    nums3[k] = nums2[j];
                    k++;
                    j++;
                }
            }
            if(i!=m)
            {
                while(i<m)
                {
                    nums3[k] = nums1[i];
                    i++;
                    k++;
                }
            }
            else if(j!=n)
            {
                while(j<n)
                {
                    nums3[k] = nums2[j];
                    k++;
                    j++;
                }
            }
            nums1 = nums3;
        }
    }
}
