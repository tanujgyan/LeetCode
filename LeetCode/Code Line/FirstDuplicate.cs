using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Code_Line
{
    class FirstDuplicate
    {
        public int firstDuplicate(int[] a)
        {
            Dictionary<int, List<int>> dict = new Dictionary<int, List<int>>();
            int inputLength = a.Length;
            for(int i=0;i<inputLength; i++)
            {
                if(!dict.ContainsKey(a[i]))
                {
                    dict.Add(a[i], new List<int> { i });
                }
                else
                {
                    return a[i];
                }
            }
            return -1;
        }
    }
}
