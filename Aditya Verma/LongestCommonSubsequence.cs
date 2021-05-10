using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DP.Aditya_Verma
{
    /// <summary>
    /// https://www.geeksforgeeks.org/longest-common-subsequence-dp-4/
    /// 
    /// </summary>
    public class LongestCommonSubsequence
    {
        public int LongestCommonSubsequenceMethod(string x, string y)
        {
            int lengthOfX = x.Length;
            int lengthOfY = y.Length;
            HashSet<char> hs = new HashSet<char>();
            int[][] memoMatrix = new int[lengthOfX + 1][];

            //intialize memo matrix with 0 for 0th row and 0th columns
            //-1 for rest
            for (int i = 0; i <= lengthOfX; i++)
            {
                memoMatrix[i] = new int[lengthOfY + 1];
                for (int j = 0; j <= lengthOfY; j++)
                {
                    if (i == 0 || j == 0)
                    {
                        memoMatrix[i][j] = 0;
                    }
                    else
                    {
                        memoMatrix[i][j] = -1;
                    }
                }
            }
            var result = LongestCommonSubsequenceHelper(x, y, lengthOfX, lengthOfY, memoMatrix, hs);
            for (int i = 0; i < hs.Count; i++)
            {
                Console.WriteLine(hs.ElementAt(i));
            }
            return result;
        }
        private int LongestCommonSubsequenceHelper(string x, string y, int lengthOfX, int lengthOfY, int[][] memoMatrix, HashSet<char> hs)
        {
            //base condition
            if (lengthOfX == 0 || lengthOfY == 0)
            {
                return 0;
            }

            if (memoMatrix[lengthOfX][lengthOfY] != -1)
            {
                return memoMatrix[lengthOfX][lengthOfY];
            }
            //choice diagram left side if last characters of both match
            if (x[lengthOfX - 1] == y[lengthOfY - 1])
            {
                memoMatrix[lengthOfX][lengthOfY] = 1 + LongestCommonSubsequenceHelper(x, y, lengthOfX - 1, lengthOfY - 1, memoMatrix, hs);
                hs.Add(x[lengthOfX - 1]);
                return memoMatrix[lengthOfX][lengthOfY];
            }
            //choice diagram right side if both characters at end do not match
            else
            {
                return Math.Max(LongestCommonSubsequenceHelper(x, y, lengthOfX - 1, lengthOfY, memoMatrix, hs), //choice right part 1
                    LongestCommonSubsequenceHelper(x, y, lengthOfX, lengthOfY - 1, memoMatrix, hs)); //choice right part 2
            }
        }

        public int LongestCommonSubsequenceTopDown(string x, string y)
        {
            int lengthOfX = x.Length;
            int lengthOfY = y.Length;
            int[][] memoMatrix = new int[lengthOfX + 1][];
            StringBuilder sb = new StringBuilder();
            //intialize memo matrix with 0 for 0th row and 0th columns
            //-1 for rest
            for (int i = 0; i <= lengthOfX; i++)
            {
                memoMatrix[i] = new int[lengthOfY + 1];
                for (int j = 0; j <= lengthOfY; j++)
                {
                    if (i == 0 || j == 0)
                    {
                        memoMatrix[i][j] = 0;
                    }
                    else
                    {
                        memoMatrix[i][j] = -1;
                    }
                }
            }
            for (int i = 1; i <= lengthOfX; i++)
            {
                for (int j = 1; j <= lengthOfY; j++)
                {
                    if (x[i - 1] == y[j - 1])
                    {
                        memoMatrix[i][j] = 1 + memoMatrix[i - 1][j - 1];

                    }
                    else
                    {
                        memoMatrix[i][j] = Math.Max(memoMatrix[i - 1][j], memoMatrix[i][j - 1]);
                    }
                }
            }
            //print the subsequence 
            int il = lengthOfX;
            int jl = lengthOfY;
                    while(il>0 && jl>0)
                    if(x[il-1]==y[jl-1])
                    {
                        sb.Append(x[il - 1]);
                        il--;
                        jl--;
                    }
                    else
                    {
                        if(memoMatrix[il-1][jl]>memoMatrix[il][jl-1])
                        {
                            il--;
                        }
                        else
                        {
                            jl--;
                        }
                    }
             
            Console.WriteLine(sb.ToString().Reverse());
            return memoMatrix[lengthOfX][lengthOfY];
        }
    }
}
