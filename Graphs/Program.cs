using System;

namespace Graphs
{
    class Program
    {
        static void Main(string[] args)
        {
            NumberOfConnectedNodesInUnconnectedgraphDriverCode();
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
