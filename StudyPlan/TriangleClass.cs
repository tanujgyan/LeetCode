using System;
using System.Collections.Generic;
using System.Text;

namespace StudyPlan
{
    //Time Complexity O(n2)
    /* https://leetcode.com/problems/triangle/
     */
    class TriangleClass
    {
        public int MinimumTotal(IList<IList<int>> triangle)
        {
            int minimum = 0;
            int[][] result = new int[triangle.Count][];
            //initialize the results array
            for(int i=0;i<result.Length;i++)
            {
                result[i] = new int[result.Length];
                for(int j=0;j<result.Length;j++)
                {
                    if (i == 0 && j==0)
                    {
                        result[0][0] = triangle[0][0];
                    }
                    else if(i>0 && j==0)
                    {
                        result[i][j] = result[i - 1][j] + triangle[i][j];
                    }
                    else
                    {
                        result[i][j] = int.MaxValue;
                    }
                }
               
            }
            minimum = result[result.Length - 1][0];

            //general strategy here is to use 2d array to track the best possible values of a row in consideration. 
            //To calculate each row we can either go up or up and one left
            for (int i=1;i<result.Length;i++)
            {
                for(int j=1;j<result[i].Length;j++)
                {
                    if (result[i - 1][j] != int.MaxValue)
                    {
                        result[i][j] = Math.Min(result[i - 1][j] + triangle[i][j], result[i - 1][j-1] + triangle[i][j]);
                        if(i==result.Length-1)
                        {
                            minimum = Math.Min(minimum, result[i][j]);
                        }
                    }
                    else if(result[i - 1][j - 1]!=int.MaxValue)
                    {
                        result[i][j] = result[i - 1][j - 1] + triangle[i][j];
                        if (i == result.Length-1)
                        {
                            minimum = Math.Min(minimum, result[i][j]);
                        }
                    }
                }
            }
            return minimum;
        }
    }
}
