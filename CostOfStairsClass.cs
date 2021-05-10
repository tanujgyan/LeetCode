using System;
using System.Collections.Generic;
using System.Text;

namespace DP
{
    class CostOfStairsClass
    {
        public static int MinCostClimbingStairs(int[] cost)
        {
            int inputLength = cost.Length;
            //create dp array
            int[] dparray = new int[inputLength];
            //create base case
            //dparray[0] = 0;//if you dont climb you dont pay
            dparray[0] = cost[0]; //start from stair 0
            dparray[1] = cost[1];//start from stair 1
            if(inputLength==2)
            {
                return Math.Min(dparray[0], dparray[1]);
            }
            for(int i=2;i<inputLength;i++)
            {
                dparray[i] = Math.Min(cost[i] + dparray[i - 2], cost[i] + dparray[i - 1]);
            }
            int result = Math.Min(dparray[inputLength - 2], dparray[inputLength - 1]);
            return result;
        }
    }
}
