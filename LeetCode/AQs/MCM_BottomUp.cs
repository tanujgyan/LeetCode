using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Amazon_Interview_Questions
{
    class MCM_BottomUp
    {
        //public int MCM(int[] arr)
        //{
        //    int[][] dpMatrix = new int[arr.Length + 1][];
        //    //initialize dp matrix
        //    for (int i = 0; i <= dpMatrix.Length; i++)
        //    {
        //        dpMatrix[i] = new int[arr.Length];
        //        for (int j = 0; j < dpMatrix[0].Length; j++)
        //        {
        //            //diagonals are assigned to 0
        //            if (i == j)
        //            {
        //                dpMatrix[i][j] = 0;
        //            }
        //        }
        //    }
        //    MCMHelper(arr, dpMatrix);
        //}
        //private void MCMHelper(int[] arr, int[][] dpMatrix)
        //{
        //    int count = 0;
        //    //top loop will create chains
        //    for (int chainLength = 2; chainLength < arr.Length; chainLength++)
        //    {
        //        for(int i=1;i<=chainLength;i++)
        //        {
        //            //j is dependent on i for getting its value in array depending on chain length j has to be picked
        //            //array wise if chain lenght is 2 and we want to use first element of array upper bound
        //            //j is 2 ahead of it. simillary if chain length is 3 j is 3 ahead of it
        //            int j = i + chainLength;
        //            for(int k=i;k<j )

        //        }
        //    }
        //}
    }
}
