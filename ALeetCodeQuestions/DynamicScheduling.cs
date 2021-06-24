using System;
using System.Collections.Generic;
using System.Text;

namespace ALQ
{
    class DynamicScheduling
    {
        public void DynamicSchedule(int[] arr, int d)
        {
            var ans = DynamicScheduleHelper(arr, 0, d-1);
        }
        private int DynamicScheduleHelper(int[] arr, int i, int j)
        {
            if(i==j)
            {
                int temp = Int32.MinValue;
                for(int t=0;t<=i;t++)
                {
                    temp = Math.Max(temp, arr[t]);
                }
                return temp;
            }
            int ans = Int32.MaxValue;
            for(int k=i;k<=arr.Length-j;k++)
            {
                var tempans = DynamicScheduleHelper(arr, i, k) + DynamicScheduleHelper(arr, k + 1, j);
               
                ans = Math.Min(ans, tempans);
            }
            return ans;
        }
    }
}
