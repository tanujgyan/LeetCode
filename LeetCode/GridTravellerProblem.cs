using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace LeetCode
{
    /// <summary>
    /// https://leetcode.com/problems/unique-paths/
    /// </summary>
    public class GridTravellerProblem
    {
        
        Dictionary<string, int> dict = new Dictionary<string, int>();
        /// <summary>
        /// Solved using recursion and memoization
        /// Define a  base case of 1, 1 where return will be 1
        /// We have an option of going down which will decrease the row by 1 and keep the column same
        /// We have option of going right which will decrease column by 1 and keep row same
        /// we have to recursively call the two options and keep saving results into a dictionary to serve memoization
        /// </summary>
        /// <param name="m"></param>
        /// <param name="n"></param>
        /// <returns></returns>
        public int UniquePaths(int m, int n)
        {
            if (dict.ContainsKey(m + "," + n))
            {
                return dict[m + "," + n];
            }
            if (m == 1 && n == 1)
            {
                if (!dict.ContainsKey(m + "," + n))
                {
                    dict.Add(m + "," + n, 1);
                }
                return 1;
            }
            if (m == 0 || n == 0)
            {
                return 0;
            }
            dict.Add(m + "," + n, (UniquePaths(m - 1, n) + UniquePaths(m, n - 1)));
            return dict[m + "," + n];
        }
    }
}
