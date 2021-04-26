using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Amazon_Interview_Questions
{
    /// <summary>
    /// https://leetcode.com/problems/number-of-islands/
    /// </summary>
    class NumberOfIslands
    {
        public int NumIslands(char[][] grid)
        {
            int count = 0;
            //repeat the process till we check each number from the grid
            for(int i=0;i<grid.Length;i++)
            {
                for(int j=0;j<grid[i].Length;j++)
                {
                    if(grid[i][j]=='1')
                    {
                        NumIslandsDFS(i, j, grid);
                        //once back from recursion increase the count by1
                        count++;
                    }
                }
            }
            return count;
        }
        public void NumIslandsDFS(int row, int column,char[][] grid)
        {
            if (row < 0 || column < 0 || row >= grid.Length || column>= grid[row].Length || grid[row][column] == '0')
            {
                return;
            }
           //set island to 0 to avoid recounting it.
            grid[row][column] = '0';
            //look for more islands in adjacent rows/columns and set them to 0 if they satisfy the condition
            NumIslandsDFS(row + 1, column, grid);
            NumIslandsDFS(row - 1, column, grid);
            NumIslandsDFS(row , column+1, grid);
            NumIslandsDFS(row, column-1, grid);
        }

    }
}
