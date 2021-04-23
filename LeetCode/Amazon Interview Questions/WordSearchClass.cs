using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCode.Amazon_Interview_Questions
{
    class WordSearchClass
    {
        string s = "";
        public void Exist(char[][] board, string word)
        {
           for(int i=0;i<board.Length;i++)
            {
                for(int j=0;j<board[i].Length;j++)
                {
                    if(board[i][j]==word[0])
                    {
                      var ret=  RecursiveMethod(board, word, i, j, 0);

                    }
                }
            }

        }
        public bool RecursiveMethod(char[][] board, string word, int row, int column,int indexofnextletter)
        {
            bool ret = false;
            if(row<0 || row>=board.Length || column<0 || column>=board[row].Length)
            {
                return false;
            }
            if (indexofnextletter < word.Length && board[row][column] == word[indexofnextletter])
            {
                ret = true;
                s += word[indexofnextletter];
            }
            else
            {
                return ret;
            }
             ret= RecursiveMethod(board, word, row + 1, column, indexofnextletter+1)
                || RecursiveMethod(board, word, row - 1, column, indexofnextletter+1)
                || RecursiveMethod(board, word, row, column + 1, indexofnextletter+1)
                || RecursiveMethod(board, word, row, column - 1, indexofnextletter+1);
            
            return ret;
        }
    }
}
