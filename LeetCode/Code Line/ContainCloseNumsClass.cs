using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Code_Line
{
    /// <summary>
    /// https://app.codesignal.com/interview-practice/task/njfXsvjRthFKmMwLC/description
    /// </summary>
    class ContainCloseNumsClass
    {
        public bool containsCloseNums(int[] nums, int k)
        {
            Dictionary<int, List<int>> closeNumsDict = new Dictionary<int, List<int>>();
            int inputLength = nums.Length;
            for(int i=0;i<inputLength;i++)
            {
                if(!closeNumsDict.ContainsKey(nums[i]))
                {
                    closeNumsDict.Add(nums[i], new List<int> { i });
                }
                else
                {
                    //if key is already present check if the value present and current value is less than equal to k
                    if(Math.Abs(closeNumsDict[nums[i]][0]-i)<=k)
                    {
                        return true;
                    }
                    //if its not less than or equal to k, remove the 
                    else
                    {
                        closeNumsDict[nums[i]].RemoveAt(0);
                        closeNumsDict[nums[i]].Add(i);
                    }
                }
            }
            return false;
        }
    }
}
