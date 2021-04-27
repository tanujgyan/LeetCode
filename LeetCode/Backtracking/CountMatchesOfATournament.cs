using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Backtracking
{
    class CountMatchesOfATournament
    {
        public int NumberOfMatches(int n)
        {
            int matchCount = 0;
            if(n<1)
            {
                return -1; //this is invalid input
            }
            if(n==1)
            {
                return 0;//this is a valid test case if there is only one team no match will be played
            }
            while(n!=1)
            {
                if(n%2==0)
                {
                    n /= 2;
                    matchCount += n;
                }
                else
                {
                    matchCount += (n - 1) / 2;
                    n = ((n - 1) / 2) + 1;
                   
                }
            }
            return matchCount;
        }
    }
}
