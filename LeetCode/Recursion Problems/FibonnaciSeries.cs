using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Recursion_Problems
{
    class FibonnaciSeries
    {
        Dictionary<int, int> dict = new Dictionary<int, int>();
        public int CalculateFibonnaci(int n)
        {
            if (dict.ContainsKey(n))
            {
                return dict[n];
            }
            if (n == 0 || n == 1)
            {
                return n;
            }

            dict.Add(n, CalculateFibonnaci(n - 2) + CalculateFibonnaci(n - 1));
            return dict[n];
        }
    }
}
