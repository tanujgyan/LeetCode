using System;
using System.Collections.Generic;
using System.Text;

namespace ALQ
{
    class DetectCycleInDirectedGraph
    {
        Dictionary<int, List<int>> adjacencyList = new Dictionary<int, List<int>>();
        List<int> visitedNode;
        public bool DetectCycle(int[][] graph)
        {
            BuildAdjacencyList(graph);
            visitedNode = new List<int>();
            bool[] visited = new bool[adjacencyList.Count];
            bool[] recursionStack = new bool[adjacencyList.Count];
            foreach (var node in adjacencyList)
            {
                if (DetectCycleHelper(node.Key, visited, recursionStack,new List<int>()))
                {
                    visitedNode = new List<int>();
                    return true;
                }
            }
            return false;
        }
        private bool DetectCycleHelper( int node, bool[] visited, bool[] recursionStack,List<int> temp)
        {
            if(node>=recursionStack.Length || node>=visited.Length)
            {
                return false;
            }
            if(node<recursionStack.Length && recursionStack[node])
            {
                return true;
            }
            if(node<visited.Length && visited[node])
            {
                return false;
            }
            recursionStack[node] = true;
            visited[node] = true;
            temp.Add(node);
            foreach(var neghibor in adjacencyList[node])
            {
                if(DetectCycleHelper(neghibor, visited, recursionStack,temp))
                {
                    return true;
                }
            }
            recursionStack[node] = false;
            visitedNode.AddRange(temp);
            return false;
        }
        private void BuildAdjacencyList(int[][] graph)
        {
            for (int i = 0; i < graph.Length; i++)
            {
                for (int j = 0; j < graph[0].Length; j++)
                {
                    if (graph[i][j] == 1)
                    {
                        if (!adjacencyList.ContainsKey(i))
                        {
                            adjacencyList.Add(i, new List<int>() { j });
                        }
                        else
                        {
                            adjacencyList[i].Add(j);
                        }
                    }
                }
            }
        }
    }
}
