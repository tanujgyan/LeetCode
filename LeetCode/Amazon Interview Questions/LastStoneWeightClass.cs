using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCode.Amazon_Interview_Questions
{
    /// <summary>
    /// https://leetcode.com/problems/last-stone-weight/
    /// </summary>
    class LastStoneWeightClass
    {
        public int LastStoneWeight(int[] stones)
        {
            
            var stoneset = stones.ToList();
            while (stoneset.Count > 1)
            {
                stoneset= stoneset.OrderBy(x => x).ToList();

                //take difference of last two elements
                var last = stoneset.ElementAt(stoneset.Count - 1);
                var secondlast = stoneset.ElementAt(stoneset.Count - 2);
                var diff = last - secondlast;
                //remove last two elements
                stoneset.Remove(last);
                stoneset.Remove(secondlast);
                //add the difference
                stoneset.Add(diff);
            }
            //return the last left element
            return stoneset.ElementAt(0);
            
        }
    }
}
