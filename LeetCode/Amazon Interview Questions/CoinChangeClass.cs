using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCode.Amazon_Interview_Questions
{
    class CoinChangeClass
    {
        public int MaximumNumberOfWaysToMakeTheAmount(int[] coins, int amount)
        {
            int[][] dpMatrix = new int[coins.Length + 1][];
            //Initialize DP Matrix
            for (int i = 0; i < dpMatrix.Length; i++)
            {
                dpMatrix[i] = new int[amount + 1];
                for (int j = 0; j < dpMatrix[0].Length; j++)
                {
                    if (i == 0)
                    {
                        dpMatrix[i][j] = 0;
                    }
                    else if (j == 0)
                    {
                        dpMatrix[i][j] = 1;
                    }
                }
            }

            //Fill the DP Matrix
            for(int i=1;i<dpMatrix.Length;i++)
            {
                for(int j=1;j<dpMatrix[0].Length;j++)
                {
                    //this indicates that how many ways are there to solve the problem using coins excluding the one in consideration+
                    //if we include this coin then the amount which is left (denoted by column) how many ways to achieve that amount
                    if(coins[i-1]<=j)
                    {
                        dpMatrix[i][j] = dpMatrix[i - 1][j] + dpMatrix[i][j - coins[i - 1]];
                    }
                    //if it is not possible to use the coin just take the number of ways to solve it excluding this coin
                    else
                    {
                        dpMatrix[i][j] = dpMatrix[i - 1][j];
                    }
                }
            }
            return dpMatrix[coins.Length][amount];

        }




    }
}
