﻿using System;
using System.Collections.Generic;

namespace Graphs
{
    class Program
    {
        static void Main(string[] args)
        {
           //NumberOfConnectedNodesInUnconnectedgraphDriverCode();
            //TownJudgeDriverCode();
            //CloneGraphsDriverCOde();
           //RouteBetweenTwoNodesDriverCode();
            pathUnweightedDriverCode();
        }

        private static void pathUnweightedDriverCode()
        {
            pathUnweighted pathUnweight = new pathUnweighted();
                // No of vertices
                int v = 8;

                // Adjacency list for storing
                // which vertices are connected
                List<List<int>> adj =
                            new List<List<int>>(v);

                for (int i = 0; i < v; i++)
                {
                    adj.Add(new List<int>());
                }

         
            pathUnweight.addEdge(adj, 0, 1);
            pathUnweight.addEdge(adj, 0, 3);
            pathUnweight.addEdge(adj, 1, 2);
            pathUnweight.addEdge(adj, 3, 4);
            pathUnweight.addEdge(adj, 3, 7);
            pathUnweight.addEdge(adj, 4, 5);
            pathUnweight.addEdge(adj, 4, 6);
            pathUnweight.addEdge(adj, 4, 7);
            pathUnweight.addEdge(adj, 5, 6);
            pathUnweight.addEdge(adj, 6, 7);
                int source = 1, dest = 3;
            pathUnweight.printShortestDistance(adj, source,
                                        dest, v);
            
        }

        private static void RouteBetweenTwoNodesDriverCode()
        {
            int[][] edges = new int[4][];

            edges[0] = new int[] { 1, 2 };
            edges[1] = new int[] { 2, 3 };
            edges[2] = new int[] { 1, 4 };
            edges[3] = new int[] { 4, 6 };
            RouteBetweenTwoNodes.RouteExists(2, 6, edges);
        }
        private static void CloneGraphsDriverCOde()
        {
            CloneGraphs cloneGraphs = new CloneGraphs();
            Node node1 = new Node(1);
            Node node2 = new Node(2);
            Node node3 = new Node(3);
            Node node4 = new Node(4);
            node1.neighbors.Add(node2);
            node1.neighbors.Add(node4);
            node2.neighbors.Add(node3);
            node2.neighbors.Add(node1);
            node3.neighbors.Add(node4);
            node3.neighbors.Add(node2);
            node4.neighbors.Add(node1);
            node4.neighbors.Add(node3);
            cloneGraphs.CloneGraph(node1);
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
