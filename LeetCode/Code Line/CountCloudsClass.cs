using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Code_Line
{
    class CountCloudsClass
    {
       public int countClouds(char[][] skyMap)
        {
            int countOfClouds = 0;
            int rows = skyMap.Length;
            
            if(rows==0)
            {
                return 0;
            }
            int columns = skyMap[0].Length;
            for (int i=0;i<rows;i++)
            {
                for(int j=0;j<columns;j++)
                {
                    if(skyMap[i][j]=='1')
                    {
                        countOfClouds++;
                        countCloudsDFS(skyMap, i, j, rows, columns);
                    }
                }
            }
            return countOfClouds;
        }
        public void countCloudsDFS(char[][] skyMap,int row, int column,int rowLimit,int columnLimit)
        {
            if(row>=rowLimit||column>=columnLimit||row<0 || column<0)
            {
                return;
            }
            if(skyMap[row][column]=='0' || skyMap[row][column]=='X')
            {
                return;
            }
            if (skyMap[row][column] == '1' )
            {
                skyMap[row][column] = 'X';
            }
            countCloudsDFS(skyMap, row + 1, column, rowLimit, columnLimit);
            countCloudsDFS(skyMap, row - 1, column, rowLimit, columnLimit);
            countCloudsDFS(skyMap, row, column+1, rowLimit, columnLimit);
            countCloudsDFS(skyMap, row, column-1, rowLimit, columnLimit);
        }
    }
}
