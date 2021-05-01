using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Code_Line
{
    /// <summary>
    /// https://app.codesignal.com/interview-practice/task/5A8jwLGcEpTPyyjTB/description
    /// </summary>
    class RotateImage
    {
        public int[][] rotateImage(int[][] matrix)
        {
            int n = matrix.Length;
            for(int i=0;i<n;i++)
            {
                for(int j=i;j<n;j++)
                {
                    int temp = matrix[i][j];
                    matrix[i][j] = matrix[j][i];
                    matrix[j][i] = temp;
                }
            }
            for(int i=0;i<n;i++)
            {
                int x = 0;
                int y = n-1;
                while(x<y)
                {
                    int temp = matrix[i][x];
                    matrix[i][x] = matrix[i][y];
                    matrix[i][y] = temp;
                    x++;
                    y--;
                }
            }
            return matrix;
        }
    }
}
