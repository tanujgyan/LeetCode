using System;
using System.Collections.Generic;
using System.Text;

namespace ALQ
{
    /// <summary>
    /// https://leetcode.com/problems/number-of-provinces/
    /// </summary>
    class NumberOfProvinces
    {
        /// <summary>
        /// The idea of this algorithm is to just use DFS and visit all the neghibors of a node.
        /// This will make us traverse all the directly or indirectly connected provinces.
        /// when we finish one iteration we will mark all the neghibors of a node as visited (they will be one province)
        /// Then we will look for unmarked nodes and do the same steps as above
        /// </summary>
        private Dictionary<int, List<int>> adjacencyList = new Dictionary<int, List<int>>();
        public int FindCircleNum(int[][] isConnected)
        {
            int result = 0;
            BuildAdjacencyList(isConnected);
            Dictionary<int, bool> visited = new Dictionary<int, bool>();
            for(int i=0;i<adjacencyList.Count;i++)
            {
                if(!visited.ContainsKey(i))
                {
                    FindCircleNumHelper(i,visited);
                    result++;
                }
            }
            return result;
        }
        private void FindCircleNumHelper(int node, Dictionary<int, bool> visited)
        {
            if(visited.ContainsKey(node))
            {
                return;
            }
            visited.Add(node, true);
            foreach(var neghibor in adjacencyList[node])
            {
               
                FindCircleNumHelper(neghibor, visited);
            }
        }
        private void BuildAdjacencyList(int[][] isConnected)
        {
            for (int i = 0; i < isConnected.Length; i++)
            {
                for (int j = 0; j < isConnected[0].Length; j++)
                {
                    if (isConnected[i][j] == 1)
                    {
                        if (!adjacencyList.ContainsKey(i))
                        {
                            adjacencyList.Add(i, new List<int>() { j});
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
