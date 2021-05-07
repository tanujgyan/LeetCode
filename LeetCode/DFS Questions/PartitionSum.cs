using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCode.DFS_Questions
{
    class PartitionSum
    {
        
        public bool CanPartition(int[] nums)
        {
            bool?[][] dpMatrix = new bool?[nums.Length+1][];
            for(int i=0;i<=nums.Length;i++)
            {
                dpMatrix[i] = new bool?[20000];
            }
            int totalSum = nums.Sum();
            if (totalSum % 2 != 0)
            {
                return false;
            }
            int targetSum = totalSum / 2;
            var result = CanPartitionDFS(nums, targetSum, nums.Length, targetSum,dpMatrix);
            return result;
        }
        public bool CanPartitionDFS(int[] nums, int targetSum, int length, int currentSum, bool?[][] dpMatrix)
        {
            if (currentSum == 0)
            {
                return true;
            }
            if (length == 0)
            {
                return false;
            }
            if(dpMatrix[length][currentSum]!=null)
            {
               return (bool)dpMatrix[length][currentSum];
            }
            if (nums[length - 1] < currentSum)
            {
                var v1 = CanPartitionDFS(nums, targetSum, length - 1, currentSum - nums[length - 1],dpMatrix);

                var v2 = CanPartitionDFS(nums, targetSum, length - 1, currentSum,dpMatrix);
                dpMatrix[length][currentSum] = v1 || v2;
                return (bool)dpMatrix[length][currentSum];
            }
            else if (nums[length - 1] == currentSum)
            {
                return true;
            }
            else
            {
                dpMatrix[length][currentSum] = CanPartitionDFS(nums, targetSum, length - 1, currentSum,dpMatrix);
                return (bool)dpMatrix[length][currentSum];
            }
        }

    }
}
