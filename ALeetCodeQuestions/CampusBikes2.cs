using System;
using System.Collections.Generic;
using System.Text;

namespace ALQ
{
    class CampusBikes2
    {
        int minSum = Int32.MaxValue;
        public void CampusBikes(int[][] workers,int[][] bikes)
        {
            bool[] used = new bool[bikes.Length];

            CampusBikesHelper(workers, bikes, 0, 0, used);
        }
        private void CampusBikesHelper(int[][] workers,int[][] bikes, int workerIndex, int sum, bool[] used)
        {
            if(workerIndex==workers.Length)
            {
                minSum = Math.Min(sum, minSum);
                return;
            }
            if(sum>minSum)
            {
                return;
            }
            for(int i=0;i<bikes.Length;i++)
            {
                if(!used[i])
                {
                    used[i] = true;
                    sum += CalculateManhattenDistance(workers[workerIndex], bikes[i]);
                    CampusBikesHelper(workers, bikes, workerIndex + 1, sum, used);
                    used[i] = false;
                }
            }
        }
        private int CalculateManhattenDistance(int[] workerCordinates, int[] bikeCordinates)
        {
            return Math.Abs(workerCordinates[0] - bikeCordinates[0]) + Math.Abs(workerCordinates[1] - bikeCordinates[1]);
        }
    }
}
