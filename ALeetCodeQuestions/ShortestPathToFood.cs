using System;
using System.Collections.Generic;
using System.Text;
/// <summary>
/// https://leetcode.ca/2021-03-13-1730-Shortest-Path-to-Get-Food/
/// </summary>
namespace ALQ
{
    class ShortestPathToFood
    {
        public int ShortestPath(char[][] grid)
        {
            int rows = grid.Length, columns = grid[0].Length;
            bool[][] visited = new bool[rows][];
            for(int i=0;i<rows;i++)
            {
                visited[i] = new bool[columns];
                for(int j=0;j<columns;j++)
                {
                    visited[i][j] = false;
                }
            }
            int startRow = -1, startColumn = -1;
            int total = rows * columns;
            for (int i = 0; i < total; i++)
            {
                int row = i / columns, column = i % columns;
                if (grid[row][column] == '*')
                {
                    startRow = row;
                    startColumn = column;
                    break;
                }
            }
            visited[startRow][startColumn] = true;
            Queue<int[]> queue = new Queue<int[]>();
            queue.Enqueue(new int[] { startRow, startColumn });
            // int[][] directions = [ [ -1, 0 }], { 1, 0 }, { 0, -1 }, { 0, 1 } };
            int[][] directions = new int[4][];
            directions[0] = new int[] { -1, 0 };
            directions[1] = new int[] { 1, 0 };
            directions[2] = new int[] { 0, -1 };
            directions[3] = new int[] { 0,1 };
            int steps = 0;
            while (queue.Count>0)
            {
                int size = queue.Count;
                for (int i = 0; i < size; i++)
                {
                    int[] cell = queue.Dequeue();
                    int row = cell[0], column = cell[1];
                    if (grid[row][column] == '#')
                        return steps;
                    foreach (var direction in directions)
                    {
                        int newRow = row + direction[0], newColumn = column + direction[1];
                        if (newRow >= 0 && newRow < rows && newColumn >= 0 && newColumn < columns && grid[newRow][newColumn] != 'X' && !visited[newRow][newColumn])
                        {
                            visited[newRow][newColumn] = true;
                            queue.Enqueue(new int[] { newRow, newColumn });
                        }
                    }
                }
                steps++;
            }
            return -1;
        }
    }
}
