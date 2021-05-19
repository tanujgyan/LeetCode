using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCode.Amazon_Interview_Questions
{
    /// <summary>
    /// https://leetcode.com/problems/k-closest-points-to-origin/
    /// </summary>
    class KClosestPointClass
    {
        public int[][] KClosest(int[][] points, int k)
        {
            Dictionary<int, double> dict = new Dictionary<int, double>();
            int[][] result = new int[k][];
            for(int i=0;i<points.Length;i++)
            {
                var distance = Math.Sqrt(Math.Pow(points[i][0], 2) + Math.Pow(points[i][1], 2));
                dict.Add(i, distance);               
            }
            var sorted = dict.OrderBy(x => x.Value).ToDictionary(x => x.Key, x => x.Value);
            for(int i=0;i<k;i++)
            {
                result[i] = points[sorted.ElementAt(i).Key];
            }
            return result;
        }
    }
}
