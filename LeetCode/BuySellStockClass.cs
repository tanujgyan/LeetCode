using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    public class BuySellStockClass
    {
        /// <summary>
        /// start with buying and selling price as int32.max
        /// start the loop to scan the array
        /// if buying price is less than current buying price put a value in buying price. set selling price to int32.max
        /// if selling price is int32.max and current number is greater than buying price. put that as selling price and calculate profit
        /// if selling price has valid value and we come across a greater value recalculate profit.
        /// 
        /// </summary>
        /// <param name="prices"></param>
        /// <returns></returns>
        public int MaxProfit(int[] prices)
        {
            int profit = 0;
            int buyingPrice = Int32.MaxValue;
            int sellingPrice = Int32.MaxValue;
            for (int i = 0; i < prices.Length; i++)
            {
                if (prices[i] < buyingPrice)
                {
                    buyingPrice = prices[i];
                    sellingPrice = Int32.MaxValue;
                }
                else if (prices[i] > buyingPrice && sellingPrice==Int32.MaxValue )
                {
                    sellingPrice = prices[i];
                }
                else if(sellingPrice!=Int32.MaxValue && prices[i]>sellingPrice)
                {
                    sellingPrice = prices[i];
                }
                if (buyingPrice != Int32.MaxValue && sellingPrice != Int32.MaxValue)
                {
                    if (sellingPrice - buyingPrice > profit)
                    {
                        profit = sellingPrice - buyingPrice;
                    }
                }
            }
            
            return profit;
        }
    }
}
