using System;
using System.Collections.Generic;
using System.Text;

namespace DP
{
    class ClimbingStairs
    {
        public void ClimbingStairsMethod(int n)
        {
            var total= ClimbingStairsDFS(n);
        }
        public int ClimbingStairsDFS(int n)
        {
            //to get to 0th stair there is 1 way i.e. to keep standing
            //to get to 1st stair there is one climb one stair 
            //anything beyond this will be computed so cant be base case
            if (n==0 ||n==1) 
            {
                return 1;
            }
            //now think this how many ways to come to 2 stairs
            //or a better question is where should i be standing to get to stair 2
            //ans is either stair 0 climb 2 steps. to reach stair 0 how many ways are needed -- 1
            //or be on stair 1 and climb 1 step. to reach stair 1 how many ways are needed -- 1
            //so put it like this f(2)= f(1)+f(0) = 2 ways
            //generalize it f(n)=f(n-1)+f(n-2) 
            // int totalways = Math.Min(ClimbingStairsDFS(n - 1), ClimbingStairsDFS(n - 2));
            int totalways = ClimbingStairsDFS(n - 1);
            return totalways;
        }
    }
}
