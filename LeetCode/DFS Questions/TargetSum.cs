using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCode.DFS_Questions
{
    class TargetSum
    {
        public int numberOfWays = 0;
        public int FindTargetSumWays(int[] nums, int target)
        {
            FindTargetSumWaysDFS(nums, target, 0, 0,1);
            FindTargetSumWaysDFS(nums, target, 0, 0, -1);
            return numberOfWays;
        }
        public void FindTargetSumWaysDFS(int[] nums,int target,int sum,int index,int multiplier)
        {
            if(index>=nums.Length)
            {
               
                return;
            }
            sum += nums[index]*multiplier;
           
            FindTargetSumWaysDFS(nums, target, sum, index + 1, 1);
            
            FindTargetSumWaysDFS(nums, target, sum, index + 1,-1);
            if (sum == target && index==nums.Length-1)
            {
                numberOfWays++;
            }
        }

        public int TargetSumTopDown(int[] nums,int target)
        {
            int inputLength = nums.Length;
            int sum = nums.Sum();
            if ((sum + target) % 2!=0)
            {
                return 0;
            }
            int targetSum = (sum + target) / 2;
            int[][] dpMatrix = new int[inputLength+1][];
            //initialize dp matrix
           
            for(int i=0;i<=inputLength;i++)
            {
                dpMatrix[i] = new int[targetSum + 1];

                for(int j=0;j<= targetSum; j++)
                {
                    if(i==0 && j==0)
                    {
                        dpMatrix[i][j] = 1;
                    }
                    else if(i>0 && j==0)
                    {
                        dpMatrix[i][j] = 1;
                    }
                    else if(i==0 && j>0)
                    {
                        dpMatrix[i][j] = 0;
                    }
                    else
                    {
                        dpMatrix[i][j] = -1;
                    }
                }
            }
            for(int i=1;i<=inputLength;i++)
            {
                for (int j = 0; j <= targetSum; j++)
                {
                    if (nums[i-1] <= j)
                    {
                        dpMatrix[i][j] = dpMatrix[i-1][j- nums[i-1]] + dpMatrix[i-1][j];
                    }
                    else
                    {
                        dpMatrix[i][j]= dpMatrix[i-1][j];
                    }
                   
                }
            }
            return dpMatrix[inputLength][targetSum];
        }
    }
}
