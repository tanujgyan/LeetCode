using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
/// <summary>
/// https://leetcode.com/problems/elimination-game/
/// </summary>
namespace LeetCode.Amazon_Interview_Questions
{
    /// <summary>
    /// https://leetcode.com/problems/elimination-game/discuss/87119/JAVA%3A-Easiest-solution-O(logN)-with-explanation
    /// Solution that runs in O(logn)
    ///     public int lastRemaining(int n) {
    //boolean left = true;
    //    int remaining = n;
    //    int step = 1;
    //    int head = 1;
    //        while (remaining > 1) {
    //            if (left || remaining % 2 ==1) {
    //                head = head + step;
    //            }
    //remaining = remaining / 2;
    //step = step * 2;
    //left = !left;
    //        }
    //        return head;
    //    }

    /// </summary>
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
