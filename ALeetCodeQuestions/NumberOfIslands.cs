using System;
using System.Collections.Generic;
using System.Text;

namespace ALQ
{
    class NumberOfIslands
    {
        private int result = 0;
        public int NumIslands(char[][] grid)
        {
            for(int i=0;i<grid.Length;i++)
            {
                for(int j=0;j<grid[0].Length;j++)
                {
                    if(grid[i][j]=='1')
                    {
                        NumIslandsHelper(grid, i, j);
                        result++;
                    }
                }
            }
            return result;
        }
        private void NumIslandsHelper(char[][] grid, int row, int column)
        {
            if (grid[row][column] == '0' || grid[row][column] == 'X' || row >= grid.Length || column >= grid[0].Length||row<0 || column<0 )
            {
                return;
            }
            else if(grid[row][column] == '1')
            {
                grid[row][column] = 'X';
            }
            NumIslandsHelper(grid, row - 1, column);
            NumIslandsHelper(grid, row + 1, column);
            NumIslandsHelper(grid, row, column + 1);
            NumIslandsHelper(grid, row, column - 1);
        }
    }
}
