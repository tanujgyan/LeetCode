using System;
using System.Collections.Generic;
using System.Text;
/// <summary>
/// https://leetcode.com/problems/count-number-of-teams/
/// </summary>
namespace ALQ
{
    /// <summary>
    /// This is solved using DP matrix
    /// At any point of time in a cell we will maintain how many smaller/greater numbers are behind the cell
    /// So we have to keep increasing the count as we go and the count will depend on how mnay number behind me are smaller or greater
    /// since its a running count so we dont need any formula or thing to make it work
    /// </summary>
    class CountNumberOfTeams
    {
        public int NumTeams(int[] rating)
        {
            
            int[][] dpMatrix = new int[rating.Length][];
            for(int i=0;i<rating.Length;i++)
            {
                dpMatrix[i] = new int[] { 0, 0 };
            }
            int ct = 0;
            for (int i = 0; i < rating.Length; i++)
            {
                for (int j = i + 1; j < rating.Length; j++)
                {
                    if (rating[j] > rating[i])
                    {
                        
                        dpMatrix[j][0]++;
                       
                        ct += dpMatrix[i][0];
                    }
                    if (rating[i] > rating[j])
                    {
                        dpMatrix[j][1]++;
                        ct += dpMatrix[i][1];
                    }
                }
            }
            return ct;
        }
    }
}
