using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ALQ
{
    /// <summary>
    /// An Amazon Fulfillment Associate has a set of items that need to be packed into two boxes. Given an integer array of the item weights (arr) to be packed, divide the item weights into two subsets, A and B, for packing into the associated boxes, while respecting the following conditions:

//• The intersection of A and B is null.
//• The union A and B is equal to the original array.The number of elements in subset A is minimal.
//• The sum of A's weights is greater than the sum of B's weights.

//Return the subset A in increasing order where the sum of A's weights is greater than the sum of B's weights. If more than one subset A exists, return the one with the maximal total weight.

//Example:
//n = 5
//arr = [3, 7, 5, 6, 2]
//The 2 subsets in arr that satisfy the conditions for A are [5, 7] and[6, 7]:
//• A is minimal (size 2)
//• Sum(A) = (5 + 7) = 12 > Sum(B) = (2 + 3 + 6) = 11 
//• Sum(A) = (6 + 7) = 13 > Sum() = (2 + 3 + 5) = 10 
//• The intersection of A and B is null and their union is equal to arr.
//The subset A where the sum of its weight is maximal is [6, 7]. 
    /// </summary>
    class OptimizingBoxWeight
    {
        /// <summary>
        /// The idea behind this algorithm is to make sure that we add to A only if NECESSARY and always from back because the arr is sorted
        /// So we will first see if we add head item to B will the sum be less than sum of A if yes we add it to B
        /// otherwise we add the tail item to A
        /// </summary>
        /// <param name="arr"></param>
        public void OptimizeBoxWeightMethod(int[] arr)
        {
            Array.Sort(arr);
            int head = 0;
            int tail = arr.Length - 1;
            List<int> A = new List<int>();
            List<int> B = new List<int>();
            while (head <= tail)
            {
                if (arr[head] + B.Sum() < A.Sum())
                {
                    B.Add(arr[head]);
                    head++;
                }
                else
                {
                    A.Add(arr[tail]);
                    tail--;
                }
            }
        }
    }
}
