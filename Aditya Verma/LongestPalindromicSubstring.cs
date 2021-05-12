using System;
using System.Collections.Generic;
using System.Text;

namespace DP
{
    class LongestPalindromicSubstring
    {
        public string LongestPalindrome(string s)
        {
            string maxsubstring = "";
            int inputLength = s.Length;
            if(inputLength==1)
            {
                return s;
            }
            //create a 2d matrix of row inputLength and column inputLength
            int[][] dpMatrix = new int[inputLength][];
            //initialize the matrix
            //fill the diagonal of dpMatrix with 1 that is the single letters as they are palindrome 
            //first base case
            for (int i=0;i<inputLength;i++)
            {
                dpMatrix[i] = new int[inputLength];
                dpMatrix[i][i] = 1;
            }
            maxsubstring = s[0].ToString();
            //second base case
            //take the first two letters and see if they are palindrome or not
            for(int i=0;i<inputLength-1;i++)
            {
                //set to 1 if palindrome
                if(s[i]==s[i+1])
                {
                    dpMatrix[i][i + 1] = 1;
                    if(maxsubstring.Length<=2)
                    {
                        maxsubstring = s.Substring(i, 2);
                    }
                }
                //set to 0 if not palindrome
                else
                {
                    dpMatrix[i][i + 1] = 0;
                }
            }
            //this loop will fix the length of string we will be covering
            for(int k=3;k<=inputLength;k++)
            {
                //since we will be covering a particular length so the limit to i will not be input length
                //as it will lead to index out of bound
                for(int i=0;i<inputLength-k+1;i++)
                {
                    //calculate the end index of string to compare based on the length
                    int j = i + k - 1;
                    if(s[i]==s[j] && dpMatrix[i+1][j-1]==1)
                    {
                        dpMatrix[i][j] = 1;
                        if (maxsubstring.Length <= s.Substring(i,j-i+1).Length)
                        {
                            maxsubstring = s.Substring(i, j - i + 1);
                        }
                    }
                    else
                    {
                        dpMatrix[i][j] = 0;
                    }
                }
            }
            return maxsubstring;
            
        }
    }
}
