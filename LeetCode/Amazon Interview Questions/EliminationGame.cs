using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCode.Amazon_Interview_Questions
{
    class EliminationGame
    {
       
        public int LastRemaining(int n)
        {
            int?[] arr = new int?[n];
            for (int i=1;i<=n;i++)
            {
                arr[i - 1] = i;
            }
            var a = LastRemainingHelper(0, arr?.ToList(), 2);
            return (int)a.FirstOrDefault(x => x != null);
        }
        private List<int?> LastRemainingHelper(int start, List<int?> arr, int iterator)
        {
           
            if(arr.Count(x=>x!=null)==1)
            {
                return arr;
            }
            while(true)
            {
               
                arr[start] = null;
                start += iterator;
                if (start > arr.Count - 1 || start < 0)
                {
                    break;
                }

            }
            arr.RemoveAll(x => x == null);
            if(iterator==2)
            {
                return LastRemainingHelper(arr.Count - 1, arr, -2);
            }
           
                return LastRemainingHelper(0, arr, 2);
            
        }
    }
}
