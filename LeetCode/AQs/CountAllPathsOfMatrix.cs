using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Amazon_Interview_Questions
{
    /// <summary>
    /// https://www.geeksforgeeks.org/count-possible-paths-top-left-bottom-right-nxm-matrix/
    /// </summary>
    class CountAllPathsOfMatrix
    {
        Dictionary<string, int > cache = new Dictionary<string,int>();
        public int CountAllPaths(int[][] matrix)
        {
            return CountAllPathsHelper(matrix, 0, 0);
        }
        private int CountAllPathsHelper(int[][] matrix, int row, int column)
        {
            if(row==matrix.Length-1 && column==matrix[0].Length-1)
            {
                return 1;
            }
            if(row> matrix.Length - 1 || column > matrix[0].Length - 1)
            {
                return 0;
            }

            if(!cache.ContainsKey(row+"_"+column))
            {
                cache.Add(row + "_" + column, CountAllPathsHelper(matrix, row, column + 1) + CountAllPathsHelper(matrix, row + 1, column));
            }
            return cache[row + "_" + column];
        }
    }
}
