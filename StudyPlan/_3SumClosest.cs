using System;
using System.Collections.Generic;
using System.Text;

namespace StudyPlan
{
    //Time complexity will be O(nlogn)+O(n2)=O(n2)
    class _3SumClosest
    {
        public int ThreeSumClosest(int[] nums, int target)
        {
            Array.Sort(nums); //O(nlogn)
            int? result = null;
            for (int i = 0; i < nums.Length - 1; i++) //this for loop will run n times
            {
                int[] arr = new int[nums.Length - i - 1];
                Array.Copy(nums, i + 1, arr, 0, nums.Length - i - 1);// this will run n times or less O(n)
                if (result==null)
                {
                    result =  TwoSum(arr, target, null,nums[i]);
                    if (result == target)
                    {
                        return (int)result;
                    }
                }
                else
                {
                    if(result==target)
                    {
                        return (int)result;
                    }
                    else
                    {
                        int tempResult = TwoSum(arr, target, result, nums[i]);
                        if(Math.Abs((int)result-target)>Math.Abs(tempResult-target))
                        {
                            result = tempResult;
                        }

                    }
                }
            }
            return (int)result;
        }
        public int TwoSum(int[] nums, int target, int? potentialResult,int constant)
        {
            int low = 0;
            int high = nums.Length - 1;
            while (low < high)
            {
                int sum = constant+nums[low] + nums[high];
                if (sum >target)
                {
                    if(potentialResult==null)
                    {
                        potentialResult = sum;
                    }
                    else
                    {
                        if((Math.Abs((int)potentialResult-target))>Math.Abs(sum-target))
                        {
                            potentialResult = sum;
                        }
                    }
                    high--;
                }
                else if(sum<target)
                {
                    if (potentialResult == null)
                    {
                        potentialResult = sum;
                    }
                    else
                    {
                        if ((Math.Abs((int)potentialResult - target)) > Math.Abs(sum - target))
                        {
                            potentialResult = sum;
                        }
                    }
                    low++;
                }
                else
                {
                    return sum;
                }
            }
            return (int)potentialResult;
        }
    }
}
