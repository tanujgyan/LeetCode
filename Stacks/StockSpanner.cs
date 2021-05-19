using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Stacks
{
    /// <summary>
    /// https://leetcode.com/problems/online-stock-span/
    /// </summary>
    public class StockSpanner
    {
        Stack<Dictionary<int, int>> stockTracker;
        public StockSpanner()
        {
            stockTracker = new Stack<Dictionary<int,int>>();
        }
        /// <summary>
        /// The idea is to use a stack to store what we have seen so far
        /// Lets say first number is 100 and stack is empty so push 100 as key and value as 1
        /// Next comes 80 the top of stack is greater than 80 so we push 80,1 to stack
        /// Next comes 60 the top of stack is greater than 60 so we push 60,1 to stack
        /// Next comes 70 the top of stack is lesser than 70 we pop it and take the value and add it to result
        /// We then push 70 with result as value to stack because anything greater than 70 will also be greater than 60 and its
        /// cheaper to store just one value with the count as value.
        /// Continue the process till the calls are not terminated.
        /// </summary>
        /// <param name="price"></param>
        /// <returns></returns>
        public int Next(int price)
        {
            int result = 1;
            if(stockTracker.Count==0)
            {
                Dictionary<int, int> keyValuePairs = new Dictionary<int, int>();
                keyValuePairs.Add(price, 1);
                stockTracker.Push(keyValuePairs);
                
            }
            else
            {
                if (stockTracker.Peek().Keys.FirstOrDefault()> price)
                {
                    Dictionary<int, int> keyValuePairs = new Dictionary<int, int>();
                    keyValuePairs.Add(price, 1);
                    stockTracker.Push(keyValuePairs);
                }
                else
                {
                    while(stockTracker.Count>0 && stockTracker.Peek().Keys.FirstOrDefault() <= price)
                    {
                        result += stockTracker.Pop().Values.FirstOrDefault();
                    }
                    Dictionary<int, int> keyValuePairs = new Dictionary<int, int>();
                    keyValuePairs.Add(price, result);
                    stockTracker.Push(keyValuePairs);
                }
            }
            return result;
        }
    }
}
