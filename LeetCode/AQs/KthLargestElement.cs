using HeapImplementation;
using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Amazon_Interview_Questions
{
    class KthLargestElement
    {
        public int FindKthLargest(int[] nums, int k)
        {
            MinHeap minHeap = new MinHeap();
            int counter = 0;
            for(int i =0;i<nums.Length;i++)
            {
                if(counter>=k)
                {
                    if (minHeap.Peek() < nums[i])
                    {
                        minHeap.Pop();
                        minHeap.Add(nums[i]);
                    }
                }
                else
                {
                    minHeap.Add(nums[i]);
                }
                counter++;
            }
            return minHeap.Peek();
        }
    }
}
