using System;
using System.Collections.Generic;
using System.Text;

namespace ALQ
{
    class Search2DMatrix2
    {
        public bool SearchMatrix(int[][] matrix, int target)
        {
            for(int i=0;i<matrix.Length;i++)
            {
                if(target==matrix[i][0])
                {
                    return true;
                }
                else if(target==matrix[i][matrix[0].Length-1])
                {
                    return true;
                }
                else if(target> matrix[i][0] && target< matrix[i][matrix[0].Length - 1])
                {
                    var arr = matrix[i];
                    int low = 0;
                    int high = arr.Length - 1;
                    int mid = 0;
                    while(low<=high)
                    {
                        mid = (low + high) / 2;
                        if (arr[mid]==target)
                        {
                            return true;
                        }
                        else if(target>arr[mid])
                        {
                            low = mid + 1;
                        }
                        else
                        {
                            high = mid - 1;
                        }
                    }
                }
            }
            return false;
        }
    }
}
