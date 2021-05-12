using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Amazon_Interview_Questions
{
    class SearchRotatedArray
    {
        int pivot = -1;
        int answer = -1;
        Dictionary<string, int> cache = new Dictionary<string, int>();
        public int Search(int[] nums, int target)
        {
            if (nums.Length == 1)
            {
                if (nums[0] == target)
                {
                    answer = 0;
                }
                else
                    answer = -1;
            }
            else
            {
                SearchHelper(nums, 0, nums.Length - 1);
                Console.WriteLine("Pivot " + pivot);
                if (pivot == -1)
                {
                    SearchTarget(nums, target, 0, nums.Length - 1);
                }
                else
                {
                    if (target == nums[pivot])
                    {
                        answer = pivot;
                    }
                    else if (pivot == 0 && target > nums[pivot])
                    {
                        answer = -1;
                    }
                    else if ((pivot == 0 && target < nums[pivot]))
                    {
                        int[] newarr = new int[nums.Length - 1];
                        Array.Copy(nums, 1, newarr, 0, newarr.Length);
                        SearchTarget(newarr, target, 0, newarr.Length - 1);
                        if(answer!=-1)
                        {
                            answer++;
                        }

                    }
                    else if ((target > nums[pivot] && target <= nums[nums.Length - 1]))
                    {
                        int[] newarr = new int[nums.Length - pivot];
                        Array.Copy(nums, pivot, newarr, 0, newarr.Length);
                        SearchTarget(newarr, target, 0, newarr.Length - 1);
                        if (answer != -1)
                        {
                            answer += pivot;
                        }
                    }
                    else if (target <= nums[pivot - 1] && target >= nums[0])
                    {
                        int[] newarr = new int[pivot];
                        Array.Copy(nums, 0, newarr, 0, newarr.Length);
                        SearchTarget(newarr, target, 0, newarr.Length - 1);
                    }

                }
            }
            Console.WriteLine("Answer " + answer);
            return answer;
        }
        private void SearchTarget(int[] arr, int target, int low, int high)
        {
            if (low > high)
            {
                return;
            }
            if (answer != -1)
            {
                return;
            }
            int mid = (high + low) / 2;
            if (target == arr[mid])
            {
                answer = mid;
            }
            else if (target > arr[mid])
            {
                SearchTarget(arr, target, mid + 1, high);
            }
            else if (target < arr[mid])
            {
                SearchTarget(arr, target, 0, mid - 1);
            }

        }
        private void SearchHelper(int[] nums, int low, int high)
        {
            if (pivot != -1)
            {
                return;
            }
            if(!cache.ContainsKey(low+"_"+high))
            {
                cache.Add(low + "_" + high, 1);
            }
            else
            {
                return;
            }
            int mid = (high + low) / 2;

            if (low >= high || mid == 0 || mid == nums.Length - 1)
            {
                if (low == 0)
                {
                    if (nums[0] > nums[1])
                    {
                        pivot = 0;
                    }
                }
                else if (low == nums.Length - 1)
                {
                    if (nums[low] < nums[low - 1])
                    {
                        pivot = low;
                    }
                }
                return;

            }
            if (nums[mid - 1] > nums[mid])
            {
                pivot = mid;
                return;
            }
            else
            {
                SearchHelper(nums, 0, mid);
                SearchHelper(nums, mid + 1, high);
            }

        }
    }
}

