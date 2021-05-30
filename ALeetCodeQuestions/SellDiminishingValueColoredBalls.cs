using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
/// <summary>
/// https://leetcode.com/problems/sell-diminishing-valued-colored-balls/
/// </summary>
namespace ALQ
{
    class SellDiminishingValueColoredBalls
    {
        private int mod = 1000000007;
        public int MaxProfit(int[] inventory, int orders1)
        {
            long orders = Convert.ToInt64(orders1);
            var inventoryDict = BuildDictionaryForMapping(inventory);
            long profit = 0;
            while (orders > 0)
            {
                long costOfFirstItem = Math.Abs(inventoryDict.ElementAt(0).Key);
                long numberOfFirstItem = Math.Abs(inventoryDict.ElementAt(0).Value);
                long costOfSecondItem = 0;
                if (inventoryDict.Count > 1)
                {
                    costOfSecondItem = Math.Abs(inventoryDict.ElementAt(1).Key);
                }
                long totalItemsThatCanBeSoldInOneShot = (costOfFirstItem - costOfSecondItem) * numberOfFirstItem;
                if (orders >= totalItemsThatCanBeSoldInOneShot)
                {
                    profit += (CalculateProfit(costOfFirstItem, costOfSecondItem)*numberOfFirstItem);
                    orders -= totalItemsThatCanBeSoldInOneShot;
                    if (costOfSecondItem > 0)
                    {
                        UpdateDictionary(inventoryDict, costOfSecondItem,numberOfFirstItem,costOfFirstItem);
                    }
                    profit %= mod;
                }
               
                else
                {
                    if(orders<=numberOfFirstItem)
                    {
                        profit += orders * costOfFirstItem;
                        break;
                    }
                    long itemsThatCanBeSoldAtFullPotential = orders - (orders % numberOfFirstItem);
                    costOfSecondItem = costOfFirstItem - (itemsThatCanBeSoldAtFullPotential / numberOfFirstItem);
                    profit += CalculateProfit(costOfFirstItem, costOfSecondItem)* numberOfFirstItem;
                    profit %= mod;
                    long costOfLeftOverItem = costOfSecondItem - 1;
                    profit += (costOfLeftOverItem * (orders % numberOfFirstItem));
                    profit %= mod;
                    break;
                }
               
            }
            
            return Convert.ToInt32(profit);

        }
        private long CalculateProfit(long costOfItem, long costOfSecondLargestItem)
        {
            //double moduloOfFirstItem = costOfItem % mod;
            //double moduloOfSecondItem = costOfSecondLargestItem % mod;
            //double sumOfFirstItemDouble = (moduloOfFirstItem * (moduloOfFirstItem + 1)) %mod;
            //sumOfFirstItemDouble /= 2;
            //double sumOfSecondItemDouble= (moduloOfSecondItem * (moduloOfSecondItem + 1)) % mod;
            //sumOfSecondItemDouble /= 2;
            //// double temp1= moduloOfFirstItem * (moduloOfFirstItem + 1)
            //int sumOfFirstItem = Convert.ToInt32((moduloOfFirstItem * (moduloOfFirstItem + 1) / 2) % mod);
            //int sumOfSecondItem = Convert.ToInt32((moduloOfSecondItem * (moduloOfSecondItem + 1) / 2) % mod);
            //int profit = Convert.ToInt32((sumOfFirstItem % mod - sumOfSecondItem % mod) %mod);
            var profit = ((costOfItem * (costOfItem + 1)) / 2) - ((costOfSecondLargestItem * (costOfSecondLargestItem + 1)) / 2);
            
            return profit;
        }
        private void UpdateDictionary(SortedDictionary<long, long> inventoryDict, long key,long value,long keyToBeRemoved)
        {
            
            if (inventoryDict.ContainsKey((key) * -1))
            {
                inventoryDict[(key) * -1] += value;
            }
            else
            {
                inventoryDict.Add((key) * -1, value);
            }
            inventoryDict.Remove(keyToBeRemoved * -1);
        }
        private SortedDictionary<long, long> BuildDictionaryForMapping(int[] inventory)
        {
            SortedDictionary<long, long> dict = new SortedDictionary<long, long>();
            foreach (var i in inventory)
            {
                if (!dict.ContainsKey(i*-1))
                {
                    dict.Add(i * -1, 1);
                }
                else
                {
                    dict[i * -1]++;
                }
            }
            return dict;
        }
    }
}
