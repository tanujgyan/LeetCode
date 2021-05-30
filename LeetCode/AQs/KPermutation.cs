using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCode.Amazon_Interview_Questions
{
    class KPermutation
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="n">Total number of elements. Can be between 1 to 9</param>
        /// <param name="k">kth element that we want to find</param>
        /// <returns></returns>
        public string GetPermutation(int n, int k)
        {
            int[] factorialArray = new int[n+1];
            List<int> digits = new List<int>();//this is total digits remember the digits will be unique in permutation
            for(int i=0;i<n;i++)
            {
                digits.Add(i + 1);
            }
            for(int i=0;i<n+1;i++)
            {
                factorialArray[i] = -1;
            }
            int totalPermutations = FactorialHelper(n, factorialArray);
            var ans = GetPermutationsHelper(factorialArray, n, k, digits, new StringBuilder());
            return ans;
        }
        private string GetPermutationsHelper(int[] factorialArray,int n,int k, List<int> digits,StringBuilder sb)
        {
            int blockSize = factorialArray[n - 1];
            int index = k / blockSize;
            if(n==1)
            {
                sb.Append(digits[0]);
                return sb.ToString();
            }
            //handle edge case where the result is at the end of the block
            if (k % blockSize == 0)
            {
                index--;
            }
            sb.Append(digits.ElementAt(index));
            digits.RemoveAt(index);
            k = k - (blockSize * index);
           return GetPermutationsHelper(factorialArray, n - 1, k, digits, sb);
        }
        private int FactorialHelper(int n, int[] factorial)
        {
            if(n==0)
            {
                factorial[0] = 1;
                return factorial[0];
            }
              return factorial[n] = n * FactorialHelper(n - 1,factorial);
            
        }
    }
}
