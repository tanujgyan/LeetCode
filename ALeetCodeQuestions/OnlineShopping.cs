using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
/*
 A customer wants to buy a pair of jeans, a pair of shoes, a skirt, and a top but has a limited budget in dollars. Given different pricing options for each product, determine how many options our customer has to buy 1 of each product. You cannot spend more money than the budgeted amount.

Example
priceOfJeans = [2, 3]
priceOfShoes = [4]
priceOfSkirts = [2, 3]
priceOfTops = [1, 2]
budgeted = 10

The customer must buy shoes for 4 dollars since there is only one option. This leaves 6 dollars to spend on the other 3 items. Combinations of prices paid for jeans, skirts, and tops respectively that add up to 6 dollars or less are [2, 2, 2], [2, 2, 1], [3, 2, 1], [2, 3, 1]. There are 4 ways the customer can purchase all 4 items.

Function Description

Complete the getNumberOfOptions function in the editor below. The function must return an integer which represents the number of options present to buy the four items.

getNumberOfOptions has 5 parameters:
int[] priceOfJeans: An integer array, which contains the prices of the pairs of jeans available.
int[] priceOfShoes: An integer array, which contains the prices of the pairs of shoes available.
int[] priceOfSkirts: An integer array, which contains the prices of the skirts available.
int[] priceOfTops: An integer array, which contains the prices of the tops available.
int dollars: the total number of dollars available to shop with.

Constraints

1 ≤ a, b, c, d ≤ 103
1 ≤ dollars ≤ 109
1 ≤ price of each item ≤ 109
Note: a, b, c and d are the sizes of the four price arrays
 */
namespace ALQ
{
    class OnlineShopping
    {
        int totalWays = 0;
        List<List<int>> combinationsF = new List<List<int>>();
        public int NumberOfWays(int[] priceOfJeans, int[] priceOfTops, int[] priceOfSkirts, int[] priceOfShoes, int dollars)
        {
            List<int[]> list = new List<int[]>();
            list.Add(priceOfJeans);
            list.Add(priceOfTops);
            list.Add(priceOfSkirts);
            list.Add(priceOfShoes);
            NumberOfWaysHelper(list, dollars, 0, new List<int>());
            return totalWays;

        }
        private void NumberOfWaysHelper(List<int[]> list,int dollars,int index,List<int> combinations)
        {
            if(index==4)
            {
                combinationsF.Add(new List<int>(combinations));
                if (combinations.Sum()<=dollars)
                {
                    totalWays++;
                }

                combinations = new List<int>();
                return;
            }
            if(index>4)
            {
                return;
            }
            for(int i=0;i<list[index].Length;i++)
            {
                combinations.Add(list[index][i]);
                NumberOfWaysHelper(list, dollars, index + 1, combinations);
                combinations.RemoveAt(combinations.Count - 1);
            }
           
        }
    }
}
