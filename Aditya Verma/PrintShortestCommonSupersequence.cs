using System;
using System.Collections.Generic;
using System.Text;

namespace DP.Aditya_Verma
{
    /// <summary>
    /// https://leetcode.com/problems/shortest-common-supersequence/submissions/
    /// </summary>
    class PrintShortestCommonSupersequence
    {
        /// <summary>
        /// Get the lcs matrix filled up
        /// print lcs and where there is no match found we have two options
        ///     a. go up then print the char from string representing row
        ///     b. go left then print the char from string representing column
        /// Once the loop is over, check for leftovers in either of the strings and append them
        /// reverse the string to get the output
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <returns></returns>
        public string ShortestCommonSupersequence(string x, string y)
        {
            int lengthOfX = x.Length;
            int lengthOfY = y.Length;
            StringBuilder sb = new StringBuilder();
            int[][] dpMatrix = new int[lengthOfX + 1][];
            for (int i = 0; i < lengthOfX + 1; i++)
            {
                dpMatrix[i] = new int[lengthOfY + 1];
                for (int j = 0; j < lengthOfY + 1; j++)
                {
                    if (i == 0 || j == 0)
                    {
                        dpMatrix[i][j] = 0;
                    }
                }
            }
            for (int i = 1; i < lengthOfX + 1; i++)
            {
                for (int j = 1; j < lengthOfY + 1; j++)
                {
                    if (x[i - 1] == y[j - 1])
                    {
                        dpMatrix[i][j] = 1 + dpMatrix[i - 1][j - 1];
                    }
                    else
                    {
                        dpMatrix[i][j] = Math.Max(dpMatrix[i][j - 1], dpMatrix[i - 1][j]);
                    }
                }
            }

            while (lengthOfX>0 && lengthOfY>0)
            {
               
                if (x[lengthOfX - 1] == y[lengthOfY - 1])
                {
                    sb.Append(x[lengthOfX - 1]);
                    lengthOfX--;
                    lengthOfY--;
                }
                else
                {
                    if (dpMatrix[lengthOfX][lengthOfY - 1] >= dpMatrix[lengthOfX][lengthOfY])
                    {
                        sb.Append(y[lengthOfY - 1]);
                        lengthOfY--;
                    }
                    else
                    {
                        sb.Append(x[lengthOfX - 1]);
                        lengthOfX--;
                    }
                }

            }
            if (lengthOfX == 0 && lengthOfY != 0)
            {
                while (lengthOfY != 0)
                {
                    sb.Append(y[lengthOfY - 1]);
                    lengthOfY--;
                }
            }
            else if (lengthOfY == 0 && lengthOfX != 0)
            {
                while (lengthOfX != 0)
                {
                    sb.Append(x[lengthOfX - 1]);
                    lengthOfX--;
                }
            }
            char[] tempreverse = sb.ToString().ToCharArray();
            Array.Reverse(tempreverse);
            string reverse = new string(tempreverse);
            return reverse;
        }
    }
}
