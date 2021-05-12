using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.DFS_Questions
{
    class PrintCombinationsDFS
    {
        StringBuilder sb = new StringBuilder();
        public void print(int n)
        {
            string[][] d = new string[2][];
            for(int i=0;i<2;i++)
            {
                d[i] = new string[n];
                for(int j=0;j<n;j++)
                {
                    if(i==0)
                    {
                        d[i][j] = "(";
                    }
                    else if(i==1)
                    {
                        d[i][j] = ")";
                    }
                }
            }
            for(int i=0;i<n;i++)
            {
                printDFS(d, i);
            }
        }

        private void printDFS(string[][] d, int i,int j=0)
        {
            if(i>=d[0].Length)
            {
                return;
            }
            printDFS(d, i + 1, 0);
            //printDFS(d, i - 1, 0);
            printDFS(d, i + 1, 1);
            //printDFS(d, i - 1, 1);
            sb.Append(d[i][j]);
        }
    }
}
