using System;
using System.Collections.Generic;
using System.Text;

namespace ALQ
{
    class SellDiminishingColorValueBallsJava
    {
        public int maxProfit(int[] inventory, long orders)
        {
			// map will store the freq count of balls.
			Dictionary<int, int> freqCount = new Dictionary<int, int>();
			foreach (int ele in inventory)
			{
				if(!freqCount.ContainsKey(ele))
                {
					freqCount.Add(ele, 1);
                }
				else
                {
					freqCount[ele]++;
                }
			}
			int[][] arr = new int[freqCount.Count + 1][];
			// to handle case when we want to take all balls, then arr[0] holds l=0
			arr[0] = new int[] { 0, 1 };
			int i = 1;
			foreach (int key in freqCount.Keys)
				arr[i++] = new int[] { key, freqCount[key] };
			// sort array in increasing order of the ball number
			Array.Sort(arr, (a, b)=>(a[0] - b[0]));
			int mod = (int)1e9 + 7;
			i = arr.Length - 1;
			long profit = 0;
			// same count will holds the # of balls of different color but having same count.
			long sameCount = arr[i][1];
			while (orders > 0)
			{
				long r = arr[i][0];
				long l = arr[i - 1][0];
				long currTotal = (r - l) * sameCount;
				if (currTotal <= orders)
				{
					orders -= currTotal;
					profit += sameCount * ((r * (r + 1)) / 2 - ((l) * (l + 1)) / 2);
				}
				else
				{
					long takeAll = orders / sameCount;
					long takeRemaining = orders % sameCount;
					orders -= takeAll * sameCount;
					profit += sameCount * ((r * (r + 1)) / 2 - ((r - takeAll) * (r - takeAll + 1)) / 2);
					orders -= takeRemaining;
					profit += takeRemaining * (r - takeAll);
				}
				sameCount += arr[i - 1][1];
				i--;
				profit %= mod;
			}
			return (int)profit;
		}
    }
}
