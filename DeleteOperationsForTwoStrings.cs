using System;
using System.Collections.Generic;
using System.Text;

namespace DP
{
    /// <summary>
    /// https://leetcode.com/problems/delete-operation-for-two-strings/
    /// </summary>
    class DeleteOperationsForTwoStrings
    {
        /// <summary>
        /// The idea to solve this problem is to find the LCS of the two strings and then the number of chars
        /// to delete from string1 will be string length - LCS and simillarly for string 2
        /// Add the two results to get o/p
        /// </summary>
        /// <param name="word1"></param>
        /// <param name="word2"></param>
        /// <returns></returns>
        public int MinDistance(string word1, string word2)
        {
            int lengthOfWord1 = word1.Length;
            int lengthOfWord2 = word2.Length;
            int[][] dpMatrix = new int[lengthOfWord1 + 1][];
            //initialize your dp matrix
            for (int i = 0; i < lengthOfWord1 + 1; i++)
            {
                dpMatrix[i] = new int[lengthOfWord2 + 1];
                for (int j = 0; j < lengthOfWord2 + 1; j++)
                {
                    if (i == 0 || j == 0)
                    {
                        dpMatrix[i][j] = 0;
                    }
                }
            }
            for (int i = 1; i < lengthOfWord1 + 1; i++)
            {
                for (int j = 1; j < lengthOfWord2 + 1; j++)
                {
                    if (word1[i - 1] == word2[j - 1])
                    {
                        dpMatrix[i][j] = 1 + dpMatrix[i - 1][j - 1];
                    }
                    else
                    {
                        dpMatrix[i][j] = Math.Max(dpMatrix[i][j - 1], dpMatrix[i - 1][j]);
                    }
                }
            }
            var lengthOfLCS = dpMatrix[lengthOfWord1][lengthOfWord2];
            var result = lengthOfWord1 + lengthOfWord2 - (2 * lengthOfLCS);
            return result;
        }
    }
}
