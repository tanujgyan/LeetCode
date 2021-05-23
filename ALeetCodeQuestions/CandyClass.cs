using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
/// <summary>
/// https://leetcode.com/problems/candy/
/// </summary>
namespace ALQ
{
    /// <summary>
    /// The idea behind this algorithm is to first compare the element to its left neghibor and assign the value accordingly
    /// Then compare to right neghibor and assign appropriately
    /// If the a value increases because of right neghibor we need to propagate the changes back because we are not going back using
    /// for loop. So for that we will write a helper method.
    /// 
    /// Time complexity will become O(N2)
    /// 
    /// A better method is to use two arrays one left to right in that track only left neghibors. Then use another array and track right neghibors 
    /// going right to left.
    /// At the end make a result array and fill it up with results from left and right array whichever is max
    /// This will give us O(N) complexity
    /// </summary>
    class CandyClass
    {
        public int Candy(int[] ratings)
        {
            int[] result = new int[ratings.Length];
            InitializeCandies(result);
            for (int i = 0; i < ratings.Length; i++)
            {
                if (i - 1 >= 0 && ratings[i - 1] < ratings[i])
                {
                    result[i] = Math.Max(result[i - 1] + 1, result[i]);
                }
                if (i + 1 <= ratings.Length - 1 && ratings[i + 1] < ratings[i])
                {
                    result[i] = Math.Max(result[i + 1] + 1, result[i]);
                    PropagateChangesToLeft(i, ratings, result);
                }
            }
            return result.Sum();

        }
        private void PropagateChangesToLeft(int index, int[] ratings, int[] result)
        {
            for (int j = index; j >= 0; j--)
            {
                if (j - 1 >= 0 && ratings[j - 1] > ratings[j])
                {
                    result[j - 1] = Math.Max(result[j] + 1,result[j-1]);
                }
                else
                {
                    break;
                }
            }
        }
        private void InitializeCandies(int[] result)
        {
            for (int i = 0; i < result.Length; i++)
            {
                result[i] = 1;
            }
        }
    }
}
