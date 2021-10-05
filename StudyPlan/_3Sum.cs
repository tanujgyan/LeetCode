using System;
using System.Collections.Generic;
using System.Text;

namespace StudyPlan
{
    //Time complexity will be O(nlogn)+O(n2)=O(n2)
    class _3Sum
    {
        Dictionary<int, List<int>> dict = new Dictionary<int, List<int>>();
        public IList<IList<int>> ThreeSum(int[] nums)
        {
            IList<IList<int>> result = new List<IList<int>>();
            Array.Sort(nums); //O(nlogn)
            //CreateDictionary(nums);
            
            for (int i = 0; i < nums.Length-1; i++) //this for loop will run n times
            {
                if(i>0 && nums[i]==nums[i-1])
                {
                    continue;
                }
                int[] arr = new int[nums.Length - i - 1];
                Array.Copy(nums, i + 1, arr,0, nums.Length - i - 1);
                var twosumresult=  TwoSum(arr, nums[i] * -1); // this will run n times or less O(n)
                if(twosumresult!=null && twosumresult.Count>0)
                {
                   foreach(var r in twosumresult)
                    {
                        result.Add(new List<int> { nums[i],r[0],r[1]});
                    }
                }
            }
            return result;
            
        }
        public List<List<int>> TwoSum(int[] nums,int target)
        {
            List<List<int>> result = new List<List<int>>();
            if (nums[0] > target)
            {
                return null;
            }
            int low = 0;
            int high = nums.Length - 1;
            while(low<high)
            {


                if (nums[low] + nums[high] > target)
                {
                    high--;
                }
                else if (nums[low] + nums[high] < target)
                {
                    low++;
                }
                else if (nums[low] + nums[high] == target)
                {
                   if(result.Count==0)
                   result.Add (new List<int> { nums[low], nums[high] });
                   else if(result[result.Count - 1][0] != nums[low] && result[result.Count - 1][1] != nums[high])
                    {
                        result.Add(new List<int> { nums[low], nums[high] });
                    }
                    low++;
                    high--;
                  
                }
            }
            return result;
        }

        public void CreateDictionary(int[] nums)
        {
            for (int i = 0; i < nums.Length; i++)
            {
                if (dict.ContainsKey(nums[i]))
                {
                    dict[nums[i]].Add(i);
                }
                else
                {
                    dict.Add(nums[i], new List<int> { i });
                }
            }

        }
    }
}
