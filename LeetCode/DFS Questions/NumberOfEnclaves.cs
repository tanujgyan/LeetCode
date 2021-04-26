using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.DFS_Questions
{
    /// <summary>
    /// https://leetcode.com/problems/number-of-enclaves/
    /// </summary>
    class NumberOfEnclaves
    {
        int count = 0;
        int individualCounter = 0;
        bool didWeCross = false;
        public int NumEnclaves(int[][] grid)
        {
            for (int i = 0; i < grid.Length; i++)
            {
                for (int j = 0; j < grid[i].Length; j++)
                {
                    if (grid[i][j] == 1)
                    {

                        //dont count border 1s
                        if (i == 0 || j == 0 || i == grid.Length - 1 || j == grid[0].Length - 1)
                        {
                            continue;
                        }
                        else
                        {
                            NumEnclavesDFS(grid, i, j);
                            //if we did not cross the border increment count
                            if (!didWeCross)
                            {
                                count += individualCounter;
                            }
                            didWeCross = false;
                            individualCounter = 0;
                        }
                    }
                }
            }
            return count;
        }
        public void NumEnclavesDFS(int[][] grid, int row, int column)
        {
            //if we reach the border set did we cross to true so that we dont unflip those elements
            if (row < 0 || column < 0 || row >= grid.Length || column >= grid[row].Length)
            {
                didWeCross = true;
                return;
            }
            //if the element encountered is 0 return
            if (row >= 0 && column >= 0 && row < grid.Length && column < grid[row].Length && grid[row][column] == 0)
            {
                return;
            }
            else if (row >= 0 && column >= 0 && row < grid.Length && column < grid[row].Length && grid[row][column] == 1)
            {
                //once we process the element set it to 0
                grid[row][column] = 0;
                //increase the count here. its potential and may be removed if we cross border
                individualCounter++;
                //send search parties in all 4 directions. this is standard DFS
                NumEnclavesDFS(grid, row + 1, column);
                NumEnclavesDFS(grid, row - 1, column);
                NumEnclavesDFS(grid, row, column + 1);
                NumEnclavesDFS(grid, row, column - 1);
            }

        }
    }
}
