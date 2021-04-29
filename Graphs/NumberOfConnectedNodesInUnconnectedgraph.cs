using System;
using System.Collections.Generic;
using System.Text;

namespace Graphs
{
    /// <summary>
    /// https://www.geeksforgeeks.org/connected-components-in-an-undirected-graph/
    /// </summary>
    class NumberOfConnectedNodesInUnconnectedgraph
    {
        public static void NumberOfConnectedNodes(int n, int[][] edges)
        {
            #region Boiler plate code
            //build an adjacency list
            //key is node label 0...n-1
            //value is neghibor list
            Dictionary<int, List<int>> adjacency = new Dictionary<int, List<int>>();
            //initialize the list
            for(int i=0;i<n;i++)
            {
                adjacency.Add(i, new List<int>());
            }
            //read the 2d array and add it to the adjacency list
            for(int i=0;i<edges.Length;i++)
            {
                    adjacency[edges[i][0]].Add(edges[i][1]);
                    adjacency[edges[i][1]].Add(edges[i][0]);
            }
            //create a visited array
            bool[] visited = new bool[n];

            #endregion

            for(int i=0;i<n;i++)
            {
                NumberOfConnectedNodesDFS(i, adjacency, visited);
                Console.WriteLine(" ");
            }
        }
        public static void NumberOfConnectedNodesDFS(int node, Dictionary<int,List<int>> adjacency, bool[] visited)
        {
            //if already visited dont visit again
            if(visited[node]==true)
            {
                return;
            }
            //add it to visited nodes as we are visiting it now
            visited[node] = true;
            //write the node on console
            Console.Write(node+" ");
            //for every neghibor the node has we will visit recursively.
            //double visits will be prevented by visited array
            for(int i=0;i<adjacency[node].Count;i++)
            {
                NumberOfConnectedNodesDFS(adjacency[node][i], adjacency, visited);
            }
        }
    }
}
