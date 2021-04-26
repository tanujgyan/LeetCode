using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.DFS_Questions
{
    /// <summary>
    /// https://leetcode.com/problems/surrounded-regions/
    /// </summary>
    class SorroundedRegions
    {
        List<int[]> list = new List<int[]>();
        bool didWeCross = false;
        public void Solve(char[][] board)
        {
            for (int i = 1; i < board.Length - 1; i++)
            {
                for (int j = 1; j < board[0].Length - 1; j++)
                {
                    if (board[i][j] == 'O')
                    {
                        SolveDFS(board, i, j);
                        //if we crossed the border flip all the switches back
                        if (didWeCross == true)
                        {
                            foreach (var l in list)
                            {
                                board[l[0]][l[1]] = 'O';
                            }
                        }
                        didWeCross = false;
                        list = new List<int[]>();
                    }
                }
            }
        }
        public void SolveDFS(char[][] board, int row, int column)
        {
            if (row < 0 || column < 0 || row >= board.Length || column >= board[row].Length)
            {
                didWeCross = true;
                return;
            }
            if (row >= 0 && column >= 0 && row < board.Length && column < board[row].Length && board[row][column] == 'X')
            {
                return;
            }
           //flip the switch
            board[row][column] = 'X';
            //Add the flipped rows and columns to a list.
            //it will be used if we have to flip back to 'O'
            list.Add(new int[] { row, column });
            
            //perform dfs on all adjacent rows
            SolveDFS(board, row + 1, column);
            SolveDFS(board, row - 1, column);
            SolveDFS(board, row, column + 1);
            SolveDFS(board, row, column - 1);
        }
    }
}
