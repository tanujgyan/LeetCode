using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    public class PascalTriangleClass
    {
        public IList<IList<int>> Generate(int numRows)
        {
            List<IList<int>> list = new List<IList<int>>();
            list.Add(new List<int>() { 1 });
            for(int i=1;i<numRows;i++)
            {
                list.Add(new List<int>());
                for (int j=0;j<=i;j++)
                {
                    if (j - 1 >= 0 && list[i - 1].Count > j)
                    {
                        list[i].Add(list[i - 1][j] + list[i - 1][j - 1]);
                    }
                    else if (i == j || j==0)
                    {
                        list[i].Add(1);
                    }
                    else
                    {
                        list[i].Add(list[i - 1][j]);
                    }
                }
            }
            return list;
        }
    }
}
