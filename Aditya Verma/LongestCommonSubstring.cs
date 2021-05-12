using System;
using System.Collections.Generic;
using System.Text;

namespace DP.Aditya_Verma
{
    class LongestCommonSubstring
    {
        public int LongestCommonSubstringMethod(string x,string y)
        {
            int lengthOfX = x.Length;
            int lengthOfY = y.Length;
            int result = 0;
            int[][] dpMatrix = new int[lengthOfX + 1][];
            for(int i=0;i< lengthOfX + 1;i++)
            {
                dpMatrix[i] = new int[lengthOfY + 1];
                for(int j=0;j<lengthOfY+1;j++)
                {
                    if(i==0 || j==0)
                    {
                        dpMatrix[i][j] = 0;
                    }
                }
            }
            for(int i=1;i<=lengthOfX;i++)
            {
                for(int j=1;j<=lengthOfY;j++)
                {
                    if(x[i-1]==y[j-1])
                    {
                        if(i-2>=0 && j-2>=0 && x[i-2]==y[j-2])
                        {
                            dpMatrix[i][j] = 1 + dpMatrix[i - 1][j - 1];
                            result = Math.Max(result, dpMatrix[i][j]);
                        }
                        else
                        {
                            dpMatrix[i][j] = 1;
                            result = Math.Max(result, dpMatrix[i][j]);
                        }
                    }
                    else
                    {
                        dpMatrix[i][j] = Math.Max(dpMatrix[i - 1][j], dpMatrix[i][j - 1]);
                        result = Math.Max(result, dpMatrix[i][j]);
                    }
                }
            }
            return result;
        }
    }
}
