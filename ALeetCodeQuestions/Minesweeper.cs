using System;
using System.Collections.Generic;
using System.Text;
/// <summary>
/// https://leetcode.com/problems/minesweeper/
/// </summary>
namespace ALQ
{
    /// <summary>
    /// This is based on DFS. The idea is to first check if the cell clicked is a mine then set it to X and return
    /// If it is E then we need to run DFS. We will use a direction 2D array to define where we can move on the grid
    /// Take the directions from array one by one and check for all possible cells to see if it is M. If an M is encountered
    /// set flag to true and look for other directions also as we have to update the number based on how many M's are encountered
    /// If we have no Ms in vicinity set the cell to B and call DFS in all directions.
    /// </summary>
    class Minesweeper
    {
        public char[][] UpdateBoard(char[][] board, int[] click)
        {
            int[][] directions = new int[][]
            {
                new int[]{1,0},
                new int[]{-1,0},
                new int[]{0,1},
                new int[]{0,-1},
                new int[]{1,1},
                new int[]{1,-1},
                new int[]{-1,1},
                new int[]{-1,-1}
            };

            if (board[click[0]][click[1]] == 'M')
            {
                board[click[0]][click[1]] = 'X';
            }
            else
            {
                UpdateBoardHelper(board, click, click[0], click[1], directions);
            }
            return board;
        }
        private void UpdateBoardHelper(char[][] board, int[] click, int row, int column, int[][] directions)
        {
            bool flag = false;
            if (row >= board.Length || column >= board[0].Length || row < 0 || column < 0)
            {
                return;
            }
            if (board[row][column] != 'E')
            {
                return;
            }
            foreach (var direction in directions)
            {
                if (row + direction[0] < board.Length && column + direction[1] < board[0].Length && row + direction[0] >= 0 && column + direction[1] >= 0 && board[row + direction[0]][column + direction[1]] == 'M')
                {
                    UpdateCell(board, row, column);
                    flag = true;
                }
            }
            if (flag)
            {
                return;
            }
            else
            {
                board[row][column] = 'B';
            }
            foreach (var direction in directions)
            {
                UpdateBoardHelper(board, click, row + direction[0], column + direction[1], directions);
            }

        }
        private void UpdateCell(char[][] board, int row, int column)
        {
            if (char.IsDigit(board[row][column]))
            {
                var c = char.GetNumericValue(board[row][column]);
                ++c;
                board[row][column] = Convert.ToChar(c.ToString());
            }
            else
            {
                board[row][column] = '1';
            }
        }
    }
}
