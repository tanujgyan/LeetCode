using System;
using System.Collections.Generic;
using System.Text;
/// <summary>
/// https://leetcode.com/problems/rotting-oranges/
/// </summary>
namespace ALQ
{
    class RottingOranges
    {
        Queue<int[]> bfsQueue = new Queue<int[]>();
        public int OrangesRotting(int[][] grid)
        {
            int minutes = 0;
            InitializeBFSQueue(grid);
            while (bfsQueue.Count > 0)
            {
                int size = bfsQueue.Count;
                bool didWeRotSomething = false;
                for (int i = 0; i < size; i++)
                {
                    var cell = bfsQueue.Dequeue();
                    didWeRotSomething = RotNeghibors(grid, cell)|| didWeRotSomething;
                }
                if (didWeRotSomething)
                {
                    minutes++;
                }
            }
            if(CheckIfAnyFreshOrangesAreLeft(grid))
            {
                minutes = -1;
            }
            return minutes;
        }
        private bool RotNeghibors(int[][] grid, int[] cell)
        {
            int row = cell[0];
            int column = cell[1];
            bool didWeRotSomething = false;
            //rot the cell above
            if (row - 1 >= 0 && grid[row - 1][column] == 1)
            {
                bfsQueue.Enqueue(new int[] { row - 1, column });
                grid[row - 1][column] = 2;
                didWeRotSomething = true;
            }
            //rot the cell below
            if (row + 1 <= grid.Length - 1 && grid[row + 1][column] == 1)
            {
                bfsQueue.Enqueue(new int[] { row + 1, column });
                grid[row + 1][column] = 2;
                didWeRotSomething = true;
            }
            //rot the cell to the left
            if (column - 1 >= 0 && grid[row][column - 1] == 1)
            {
                bfsQueue.Enqueue(new int[] { row, column - 1 });
                grid[row][column - 1] = 2;
                didWeRotSomething = true;
            }
            //rot the cell to the right
            if (column + 1 <= grid[0].Length-1 && grid[row][column + 1] == 1)
            {
                bfsQueue.Enqueue(new int[] { row, column + 1 });
                grid[row][column + 1] = 2;
                didWeRotSomething = true;
            }
            return didWeRotSomething;
        }
        private void InitializeBFSQueue(int[][] grid)
        {
          
            for (int i = 0; i < grid.Length; i++)
            {
                for (int j = 0; j < grid[0].Length; j++)
                {
                    if (grid[i][j] == 2)
                    {
                        bfsQueue.Enqueue(new int[] { i, j });
                    }
                }
            }
        }
        private bool CheckIfAnyFreshOrangesAreLeft(int[][] grid)
        {
            for (int i = 0; i < grid.Length; i++)
            {
                for (int j = 0; j < grid[0].Length; j++)
                {
                    if (grid[i][j] == 1)
                    {
                        return true;
                    }
                }
            }
            return false;
        }
    }
}
