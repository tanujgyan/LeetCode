using System;
using System.Collections.Generic;
using System.Text;

namespace ALQ
{
    class TopologicalSorting
    {
        Dictionary<int, List<int>> adjacencyList = new Dictionary<int, List<int>>();
        public void TopologicalSortingMethod(int[][] graph)
        {
            BuildAdjacencyList(graph);
            List<int> visited = new List<int>();
            Stack<int> topologicallySortedNodes = new Stack<int>();
            foreach (var node in adjacencyList)
            {
                if (!visited.Contains(node.Key))
                {
                    TopologicalSortingMethodHelper(node.Key, visited, topologicallySortedNodes);
                }

            }
            while (topologicallySortedNodes.Count > 0)
            {
                Console.WriteLine(topologicallySortedNodes.Pop());
            }
        }
        private void TopologicalSortingMethodHelper(int node, List<int> visited, Stack<int> topologicallySortedNodes)
        {
            if (visited.Contains(node))
            {
                return;
            }
            visited.Add(node);
            if (adjacencyList.ContainsKey(node))
            {
                foreach (var neghibor in adjacencyList[node])
                {
                    if (!visited.Contains(neghibor))
                    {
                        TopologicalSortingMethodHelper(neghibor, visited, topologicallySortedNodes);
                    }
                }

            }
            topologicallySortedNodes.Push(node);
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
