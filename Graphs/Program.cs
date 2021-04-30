using System;

namespace Graphs
{
    class Program
    {
        static void Main(string[] args)
        {
           //NumberOfConnectedNodesInUnconnectedgraphDriverCode();
            TownJudgeDriverCode();
        }

        private static void TownJudgeDriverCode()
        {
            TownJudge townJudge = new TownJudge();
            //int[][] edges = new int[5][];

            //edges[0] = new int[] { 1, 3};
            //edges[1] = new int[] { 1, 4 };
            //edges[2] = new int[] { 2, 3 };
            //edges[3] = new int[] { 2, 4 };
            //edges[4] = new int[] { 4, 3 };
            int[][] edges = new int[3][];

            edges[0] = new int[] { 1, 3 };
            edges[1] = new int[] { 2, 3 };
            edges[2] = new int[] { 3, 1 };
           
            //[[1,3],[2,3],[3,1]]
            townJudge.FindJudge(3,edges);
        }

        private static void NumberOfConnectedNodesInUnconnectedgraphDriverCode()
        {
            int[][] edges = new int[4][];
            edges[0] = new int[] { 0, 1 };
            edges[1] = new int[] { 1, 2 };
            edges[2] = new int[] { 2, 0 };
            edges[3] = new int[] { 3, 4 };
            NumberOfConnectedNodesInUnconnectedgraph.NumberOfConnectedNodes(5, edges);
        }
    }
}
