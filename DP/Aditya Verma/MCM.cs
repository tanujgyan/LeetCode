using System;
using System.Collections.Generic;
using System.Text;

namespace DP.Aditya_Verma
{
    /// <summary>
    /// https://www.geeksforgeeks.org/matrix-chain-multiplication-dp-8/
    /// </summary>
    public class MCM
    {
        /// <summary>
        /// few important steps to jog your memory
        /// 1. choose i which should be left end of array not necessarily 0 index
        /// 2. choose j which should right end and not neccessarily last index
        /// 3. choose k, k is a moving pointer which can move from i to j. choose k carefully 
        /// k should be from i to j-1 because based on k we divide the matrix from i to k and k+1 to j
        /// when k reaches its last index and if we make it j then k+1 will go out of bounds
        /// i should be 1 because we need arr[i-1] and arr[i] to calculate the product
        /// j can be arr.length-1
        /// 4. once you have 3 variables in hand we have to write the for loop
        /// </summary>
        /// <param name="p"></param>
        /// <param name="i"></param>
        /// <param name="j"></param>
        /// <returns></returns>
        public int MatrixChainOrder(int[] p)
        {
            int i = 1;
            int j = p.Length - 1;
            int[][] dpMatrix = new int[100][];
            for (int row = 0; row < 100; row++)
            {
                dpMatrix[row] = new int[100];
                for (int column = 0; column < 100; column++)
                {
                    dpMatrix[row][column] = -1;
                }
            }
            int result = MatrixChainOrderHelper(p, i, j,dpMatrix);
            return result;
        }
        private int MatrixChainOrderHelper(int[] p, int i, int j,int[][] dpMatrix)
        {
            
            if (i >= j)
            {
                return 0;
            }
            if(dpMatrix[i][j]!=-1)
            {
                return dpMatrix[i][j];
            }
            dpMatrix[i][j] = Int32.MaxValue;
            for (int k = i; k <= j - 1; k++)
            {

                int temp1 = MatrixChainOrderHelper(p, i, k,dpMatrix);
                int temp2 = MatrixChainOrderHelper(p, k + 1, j, dpMatrix);
                int temp3 = p[i - 1] * p[k] * p[j];
                int temp = temp1 + temp2 + temp3;


                dpMatrix[i][j] = Math.Min(dpMatrix[i][j], temp);
            }
            return dpMatrix[i][j];
        }
    }
}
