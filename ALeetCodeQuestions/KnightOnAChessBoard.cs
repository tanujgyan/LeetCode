using System;
using System.Collections.Generic;
using System.Text;
/// <summary>
/// Given a 8X8 chess board and a starting co-ordinate of a knight X,Y and number of moves (k) the knight can take, return the number of valid squares the knight can reach by making k combination moves.

//Example:

//input -
//origin - 0,0
//moves - 1
//out put is 2 - The knight can go to (2,1) and(1, 2) distinct squares in one move

//origin - 0,0
//moves -2
//output -12

// origin 0,0 
// 3 moves ---> 32 valid squares

//0 <= X, Y <=7
//1 <= K <= 30
/// 
/// </summary>
namespace ALQ
{
    class KnightOnAChessBoard
    {
        public int ValidSquares(int k, int row, int column)
        {
            var chessBoard = CreateChessBoard();
            Queue<int[]> queue = new Queue<int[]>();
           
            if (row < 0 || column < 0 || row >= 8 || column >= 8)
            {
                return 0;
            }
            int count = 0;
            int[][] directions = new int[][]
            {
                new int[]{-2,1},
                new int[]{-2,-1},
                new int[]{2,-1},
                new int[]{2,1},

                new int[]{1, -2},
                new int[]{-1,-2},
                new int[]{1,2},
                new int[]{-1,2},
            };
            queue.Enqueue(new int[] { row, column });
            int moves = 0;
            while (queue.Count > 0)
            {
                int size = queue.Count;
                
                    
               
                for (int i = 0; i < size; i++)
                {
                    var cell = queue.Dequeue();
                    foreach (var direction in directions)
                    {
                        if (cell[0] + direction[0] >= 0 && cell[1] + direction[1] >= 0
                            && cell[0] + direction[0] < chessBoard.Length && cell[1] + direction[1] < chessBoard[0].Length
                            && chessBoard[cell[0] + direction[0]][cell[1] + direction[1]] == 0)
                        {
                            count++;
                            chessBoard[cell[0] + direction[0]][cell[1] + direction[1]] = 1;
                            queue.Enqueue(new int[] { cell[0] + direction[0], cell[1] + direction[1] });
                        }
                    }
                }
                moves++;
                if(moves==k)
                {
                    break;
                }
            }
            return count;
        }
        private int[][] CreateChessBoard()
        {
            int[][] board = new int[8][]
            {
                new int[]{0,0,0,0,0,0,0,0},
                new int[]{0,0,0,0,0,0,0,0},
                new int[]{0,0,0,0,0,0,0,0},
                new int[]{0,0,0,0,0,0,0,0},
                new int[]{0,0,0,0,0,0,0,0},
                new int[]{0,0,0,0,0,0,0,0},
                new int[]{0,0,0,0,0,0,0,0},
                new int[]{0,0,0,0,0,0,0,0}
            };
            return board;
        }
    }
}
