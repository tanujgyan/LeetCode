using System;
using System.Collections.Generic;
using System.Text;
/// <summary>
/// https://leetcode.ca/2018-10-22-1057-Campus-Bikes/
/// </summary>
namespace ALQ
{
    /// <summary>
    /// The idea behind this algorithm is to first create a 2D matrix and store workers index as rows and the columns as bikes index and
    /// cell values represent the distance between worker and bike
    /// Then we need to a run two for loops that will calculate the distance between a worker and all the bikes and store the bike 
    /// nearest to worker in a temp variable. So lets say we assign bike 0 to worker 0 and then we will run the loop again for next worker and
    /// we see the bike 0 is nearer to worker 1 we will change the temp variable for bike 0 to worker 1. At the end of two loops
    /// we will know which bike is assigned to which worker, so we will mark that bike and worker as assigned
    /// We need to run these two loops as many times as number of workers so we need a 3rd outer loop
    /// </summary>
    class CampusBikes
    {
        public int[] AssignBikes(int[][] workers, int[][] bikes)
        {
            int[][] workerBikeDistanceMatrix = new int[workers.Length][];
            int[] result = new int[workers.Length];
            bool[] workerAssigned = new bool[workers.Length];
            bool[] bikeAssigned = new bool[bikes.Length];
            for (int i=0;i<result.Length;i++)
            {
                result[i] = Int32.MaxValue;
            }
            CreateWorkerBikeDistanceMatrix(workers, bikes, workerBikeDistanceMatrix);
            //3rd outer loop this is just a driver to make the inner loops run as many workers are there
            for(int i=0;i<workers.Length;i++)
            {
                int workerIndex = -1;
                int bikeIndex = -1;
                int tempDistance = Int32.MaxValue;

                //these loops will find the best bike worker combination
                for (int j=0;j<workers.Length;j++)
                {
                    if(workerAssigned[j])
                    {
                        continue;
                    }
                    for(int k=0;k<bikes.Length;k++)
                    {
                        if(bikeAssigned[k])
                        {
                            continue;
                        }
                        if(tempDistance > workerBikeDistanceMatrix[j][k])
                        {
                            workerIndex = j;
                            bikeIndex = k;
                            tempDistance = workerBikeDistanceMatrix[j][k];
                        }
                    }
                }
                //save the best combination
                result[workerIndex] = bikeIndex;
                bikeAssigned[bikeIndex] = true;
                workerAssigned[workerIndex] = true;
            }
            return result;
        }
        private void CreateWorkerBikeDistanceMatrix(int[][] workers, int[][] bikes,int[][] workerBikeDistanceMatrix)
        {
            for(int i=0;i<workers.Length;i++)
            {
                workerBikeDistanceMatrix[i] = new int[bikes.Length];
                for(int j=0;j<bikes.Length;j++)
                {
                    workerBikeDistanceMatrix[i][j] = Math.Abs(workers[i][0] - bikes[j][0]) + Math.Abs(workers[i][1] - bikes[j][1]);
                }
            }
        }
    }
}
