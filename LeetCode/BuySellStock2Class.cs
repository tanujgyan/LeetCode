using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    class BuySellStock2Class
    {
        public int MaxProfit(int[] prices)
        {
            int i = 0;
            int totalProfit = 0;

            while (i < prices.Length - 1)
            {
                int maxProfit = 0;
                int j = i + 1;
                while (j <= prices.Length - 1 && prices[i] < prices[j])
                {
                    int potentialProfit = prices[j] - prices[i];
                    if (potentialProfit <= maxProfit) break;
                    maxProfit = potentialProfit;
                    j++;
                }

                totalProfit += maxProfit;
                i = j;
            }
            return totalProfit;
        }
    }
}
