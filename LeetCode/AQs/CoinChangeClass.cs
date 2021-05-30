using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCode.Amazon_Interview_Questions
{
    class CoinChangeClass
    {
        /// <summary>
        /// Sabse pehle sort the array
        /// find the largest number in array joki target se bada hai
        /// us number se divide kro currency ko and uska remainder agar 0 nahi hai to usko le lo
        /// remainder ko next largest number s divide krke same process follow kro
        /// 
        /// 
        ///
        /// </summary>
        /// <param name="coins"></param>
        /// <param name="amount"></param>
        /// <returns></returns>
        //public int CoinChange(int[] coins, int amount)
        //{
        //    //make sure amount is valid and can be processed
        //    if (amount == 0)
        //    {
        //        return 0;
        //    }
        //    Array.Sort(coins);
        //    var list = coins.ToList();
        //    for (int i = list.Count - 1; i >= 0; i--)
        //    {
        //        var ret = CoinChangeHelper(list.ToArray(), amount);
        //        if (ret != -1)
        //        {
        //            return ret;
        //        }
        //        else
        //        {
        //            list.RemoveAt(i);
        //        }
        //    }
        //    return -1;

        //}
        //public int CoinChangeHelper(int[] coins, int amount)
        //{

        //    int coinCount = 0;
        //    int tempAmount = amount;
        //    for (int i = coins.Length - 1; i >= 0; i--)
        //    {
        //        if (coins[i] <= tempAmount)
        //        {
        //            int baseValue = coins[i];
        //            while (tempAmount != 0)
        //            {
        //                //coinCount += tempAmount / baseValue;
        //                coinCount++;
        //                tempAmount -= baseValue;

        //                if (tempAmount >= baseValue)
        //                {
        //                    continue;
        //                }
        //                else if (tempAmount < baseValue)
        //                {
        //                    break;
        //                }
        //            }
        //            if (tempAmount == 0)
        //            {
        //                return coinCount;
        //            }
        //        }
        //    }
        //    return -1;
        //}
        Stack<int> s = new Stack<int>();
        //public List<int> CoinChange(int[] coins, int amount)
        //{
           
        //}

    }
}
