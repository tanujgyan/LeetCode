using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCode.Amazon_Interview_Questions
{
    /// <summary>
    /// You are given an array of numbers and a target number you have to find a set of numbers which can sum up to target number
    /// you can use any number from array multiple times
    /// </summary>
    class HowSum
    {

        Stack<int> s = new Stack<int>(); //for debugging only
        Dictionary<int, List<int>> dict = new Dictionary<int, List<int>>();
        List<int> shortComb = new List<int>();
        //    /// <summary>
        //    /// The idea is to use recursion
        //    /// Start from top element which is target sum and loop through the array to subtract from target sum
        //    /// we will either reach a negative number or 0.
        //    /// if we reach negative number return null because this means that this combination cant generate a result
        //    /// if we reach 0 return empty array which represents success
        //    /// in the recursive calls when success is encountered we will start unravelling the stack and the numbers will be stored
        //    /// in recursive call if null is encountered number will not be stored because its not a valid combo
        //    /// </summary>
        //    /// <param name="num"></param>
        //    /// <param name="targetsum"></param>
        //    /// <returns></returns>
        //    //public List<int> HowSumMethod(int[] coins, int amount)
        //    //{
        //    //    //if(dict.ContainsKey(amount))
        //    //    //{
        //    //    //    return dict[amount];
        //    //    //}
        //    //    //s.Push(amount);
        //    //    //if (amount == 0)
        //    //    //    return new List<int>();
        //    //    //if (amount < 0)
        //    //    //    return null;
        //    //    //for (int i = coins.Length-1; i >=0; i--)
        //    //    //{
        //    //    //    var remainder = amount - coins[i];
        //    //    //    var remainderResult = HowSumMethod(coins, remainder);
        //    //    //    if(!dict.ContainsKey(amount))
        //    //    //    {
        //    //    //        dict.Add(amount, remainderResult);
        //    //    //    }
        //    //    //    if (remainderResult != null)
        //    //    //    {
        //    //    //        remainderResult.Add(coins[i]);
        //    //    //        return remainderResult;
        //    //    //    }
        //    //    //}
        //    //    //return null;
        //    //    return HowSumMethodOptimal(coins, amount);
        //    //}

        //public List<int> HowSumMethodOptimal(int[] coins, int amount)
        //{
        //    List<int> shortestCombination = new List<int>();
        //    if (amount == 0)
        //        return new List<int>();
        //    if (amount < 0)
        //        return null;
        //    foreach (var coin in coins)
        //    {
        //        var remainder = amount - coin;
        //        var remainderResult = HowSumMethodOptimal(coins, remainder);
                
        //        if (remainderResult != null)
        //        {
        //           remainderResult.Add(coin);
        //            var currentCombination = remainderResult;
        //            if (shortestCombination.Count == 0 || shortestCombination.Count > currentCombination.Count)
        //            {
        //                shortestCombination.Clear();
        //                shortestCombination = new List<int>(currentCombination);
        //            }
                    
        //        }
        //     }
        //    return shortestCombination;
        //}

        public int minCoins(int[] coins, int amount)
        {
            if(amount==0)
            {
                return 0;
            }
            int result = Int32.MaxValue;
            for(int i=0;i<coins.Length;i++)
            {
                if(coins[i]<=amount)
                {
                    int sub = minCoins(coins, amount - coins[i]);

                    if(sub!=Int32.MaxValue && result>sub+1)
                    {
                        result = sub + 1;
                    }
                }
            }
            return result;
        }

        

        public int coinChange(int[] coins, int amount)
        { 
        //this is the base test case, you dont have to process if amount is 0 or less
            if (amount <= 0 ) 
                return 0;
            //this is calling the helper method
            //this count array is just used for caching. It assumes the worst case scenario of having 1 as a coin
            //in such case you will need 1*totalamount number of coins, so it can be stored in this array
            return coinChange(coins, amount, new int[amount]);
        }

        public int coinChange(int[] coins, int remainder, int[] count)
        {
            //we reached an impossible case
            if (remainder < 0)
            {
                return -1;
            }
            //we hit base case
            if (remainder == 0)
            {
                return 0;
            }
            //return the cached value
            if (count[remainder - 1] != 0)
            {
                return count[remainder - 1];
            }

            int minValue = Int32.MaxValue;

            foreach (int coin in coins)
            {
                int result = coinChange(coins, remainder - coin, count);
                if (result >= 0 && result < minValue)
                    minValue = 1 + result;
            }
            count[remainder - 1] = (minValue == Int32.MaxValue) ? -1 : minValue;
            return count[remainder - 1];
        }
    }
}

