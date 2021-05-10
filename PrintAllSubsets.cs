using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Amazon_Interview_Questions
{


    /// <summary>
    /// Runtime Complexity: Exponential, O(2^n*n)
    /// Memory Complexity: Exponential, O(2^n* n)
    /// https://leetcode.com/problems/subsets/
    /// </summary>
    class PrintAllSubsets
    {
        /// <summary>
        /// n = size of given integer set
        ////        subsets_count = 2^n
        ////for i = 0 to subsets_count
        ////    form a subset using the value of 'i' as following:
        ////        bits in number 'i' represent index of elements to choose from original set,
        ////        if a specific bit is 1 choose that number from original set and add it to current subset,
        ////        e.g. if i = 6 i.e 110 in binary means that 1st and 2nd elements in original array need to be picked.
        //    add current subset to list of all subsets
        /// </summary>
        /// <param name="nums"></param>
        /// <returns></returns>
    public IList<IList<int>> Subsets(int[] nums)
        {
            IList<IList<int>> result = new List<IList<int>>();
            int inputLength = nums.Length;
            int totalsubs = (int)Math.Pow(2, inputLength);
            for(int i=0;i<totalsubs;i++)
            {
                string binary = Convert.ToString(i, 2).PadLeft(inputLength,'0');
                var tempList = new List<int>();
                for(int j=0;j<binary.Length;j++)
                {
                    if(binary[j]=='1')
                    {
                        tempList.Add(nums[j]);
                    }
                }
                result.Add(tempList);
            }
            return result;
        }
    }
}
