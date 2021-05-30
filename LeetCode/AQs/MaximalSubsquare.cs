using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Amazon_Interview_Questions
{
    /// <summary>
    /// https://leetcode.com/problems/maximal-square/
    /// </summary>
    class MaximalSubsquare
    {
        public int gCount = 0;
        /// <summary>
        /// This is solved using DP
        /// Step 1 : Create a DP matrix which is same size as matrix
        /// Step 2: Initialize the first row and column of DP matrix same as matrix. If you find any one initialize count with 1
        /// Step 3: Start iterating the matrix when you find 0, simply put 0 in dpMatrix at that position
        /// Step 4: If you find 1 this is where we use what we have see so far to calculate the result. Check the sorrounding values
        /// of current box, one left, one up and one diagonally up. Take the min of 3 and add 1 to it
        /// The idea is the upper box provides size of size 1 matrix seen so far above it, the box on left gives info
        /// about what was seen before it and the box diagonally up covers the rest. They all have to be perfect 1 matrix if the new
        /// found 1 wants to contribute positively to result. Otherwise this can contribute partially only
        /// so we find MIN and add 1 to it. TRY IT ON SMALL 2X2 matrix if this doesn't make sense.
        /// </summary>
        /// <param name="matrix"></param>
        /// <returns></returns>
        public int MaximalSquare(char[][] matrix)
        {
            int rowCount = matrix.Length;
            int columnCount = matrix[0].Length;
            int[][] dpMatrix = new int[rowCount][];
            for (int i = 0; i < rowCount; i++)
            {
                dpMatrix[i] = new int[columnCount];
                for (int j = 0; j < columnCount; j++)
                {
                    if (i == 0 || j == 0)
                    {
                        if (matrix[i][j] == '0')
                        {
                            dpMatrix[i][j] = 0;
                        }
                        else if (matrix[i][j] == '1')
                        {
                            dpMatrix[i][j] = 1;
                            gCount = 1;
                        }
                    }
                }
            }
            for (int i = 1; i < rowCount; i++)
            {
                for (int j = 1; j < columnCount; j++)
                {
                    if(matrix[i][j]=='1')
                    {
                        dpMatrix[i][j] = Math.Min(Math.Min(dpMatrix[i - 1][j], dpMatrix[i][j - 1]), dpMatrix[i - 1][j - 1]) + 1;
                        gCount = Math.Max(dpMatrix[i][j], gCount);
                    }
                    else
                    {
                        dpMatrix[i][j] = 0;
                    }
                }
            }
            return gCount*gCount;
        }
    }
}

