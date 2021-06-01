using System;
using System.Collections.Generic;
using System.Text;
/// <summary>
/// 
/// You're given an array, and you can update elements in that array by performing integer division with divisor d. 
/// What is the minimum number of divisions needed so that there are T numbers that are the same in the array.
//E.g. [1, 2, 3, 4, 5], threshold T = 3, d = 2.We want the min number of divisions needed so that 3 numbers are the same in the array. 
//The answer is 2. We can divide 2 // 2 = 1 and 3 // 2 = 1 to get 3 1's with 2 operations, or 4 // 2 = 2 and 5 // 2 = 2 to get 3 2's. 
//Another example is [16, 32, 64], T = 3, d = 2, answer is 3. 32 // 2 = 16, and 64 // 2 = 32, then 32 // 2 = 16, 3 divisions needed.
//I tried taking the largest number and dividing that each time but when I realized it fails for cases like [1, 2, 10000000], T = 2, d = 2, 
//I ran out of time.
/// </summary>
namespace ALQ
{

    /// <summary>
    /// The idea is to divide each number by divisor till we reach 0. While dividing we keep the intermediate values in a 
    /// dictionary. The value for a dictionary is a list which indicates how many divisons did it take to reach the key
    /// Once the dictionary is filled, parse the dictionary for list which has more than threshold elements and take sum of threshold 
    /// elements. Find the minimum such sum
    /// </summary>
    class MinimumDivisonsToReachThreshold
    {
        public int MinimumDivisonsToReachThresholdMethod(int[] input, int t, int d)
        {

            Dictionary<int, List<int>> dict = new Dictionary<int, List<int>>();

            for (int i = 0; i < input.Length; i++)
            {

                MinimumDivisonsToReachThresholdMethodHelper(input[i], dict, d);

            }

            int min = Int32.MaxValue;
            foreach (var divisions in dict.Values)
            {

                if (divisions.Count >= t)
                {
                    divisions.Sort();
                    int total = 0;
                    for (int i = 0; i < t; i++)
                    {
                        total += divisions[i];
                    }
                    min = Math.Min(min, total);

                }

            }

            return min;
        }
        public void MinimumDivisonsToReachThresholdMethodHelper(int i, Dictionary<int, List<int>> dict, int d)
        {
            int count = 0;
            while (i > 0)
            {
                List<int> tmp = new List<int>();
                if (dict.ContainsKey(i))
                {
                    tmp = dict[i];
                }

                tmp.Add(count);
                dict[i] = tmp;
                i /= d; 
                count++;

            }
        }
    }
}
