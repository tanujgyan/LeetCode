using System;
using System.Collections.Generic;
using System.Text;

namespace DP
{
    /// <summary>
    /// https://www.hackerrank.com/challenges/max-array-sum/problem?h_l=interview&playlist_slugs%5B%5D=interview-preparation-kit&playlist_slugs%5B%5D=dynamic-programming
    /// </summary>
    class MaxSumArray
    {
        public static int maxSubsetSum(int[] arr)
        {
            int inputLength = arr.Length;
            int[] dparray = new int[inputLength];
            if(inputLength==0)
            {
                return 0;
            }
            if(inputLength==1)
            {
                return Math.Max(arr[0], 0);
            }
            //define the base cases
            dparray[0] = Math.Max(arr[0], 0);
            dparray[1]= Math.Max(dparray[0], arr[1]);
            int result = Math.Max(dparray[0], dparray[1]);
            //now lets the fill the dp array. we have to compare the element in array with non adjacent 
            //element of dparray and update the value in dparray
            for(int i=2;i<inputLength;i++)
            {
                //if adding a value from non adjacent dparray and input will give us worse result than the previous dparray
                //we will copy the previous dparray here because the constraint is just not to add to
                //next element 
                dparray[i] = Math.Max(dparray[i-1], dparray[i - 2] + arr[i]);
                //keep updating results
                result = Math.Max(dparray[i], result);
            }
            Console.WriteLine(result);
            return result;
        }

    }
}
