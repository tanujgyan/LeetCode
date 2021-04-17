using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    class NumberOfGoodPairs
    {
        public int NumIdenticalPairs(int[] nums)
        {
            Dictionary<int, List<int>> dict = new Dictionary<int, List<int>>();
            int goodPairs = 0;
            for(int i=0;i<nums.Length;i++)
            {
                if(!dict.ContainsKey(nums[i]))
                {
                    dict.Add(nums[i], new List<int> { i });
                }
                else
                {
                    dict[nums[i]].Add(i);
                }
            }
            foreach(var element in dict)
            {
                if (element.Value.Count > 1)
                {

                    //int f1 = Factorial(element.Value.Count);
                    //int f2 = Factorial(element.Value.Count - 2);

                   goodPairs = goodPairs + (int)(Factorial(element.Value.Count) / (2 * Factorial(element.Value.Count - 2)));

                   // goodPairs = goodPairs + ((element.Value.Count) * (element.Value.Count - 1) / 2);
                }
            }
            return goodPairs;
        }
        public double Factorial(int n)
        {
            if (n == 0)
                return 1;
            else
                return n * Factorial(n - 1);
        }
    }
}
