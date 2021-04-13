using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    public class BuySellStockClass
    {
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
