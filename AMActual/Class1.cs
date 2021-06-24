using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AMActual
{
    class Result
    {
        static Dictionary<string, List<string>> adjacencyList = new Dictionary<string, List<string>>();
        static List<List<string>> result = new List<List<string>>();
        public static void connectedSum(int n, List<string> edges)
        {
            BuildAdjacencyList(edges);
            List<string> visitedNodes = new List<string>();
            int returnValue = 0;
            int counter = 0;
            foreach (var node in adjacencyList.Keys)
            {
                if (!visitedNodes.Contains(node))
                {
                    List<string> tempResult = new List<string>();
                    List<string> visitedTemp = new List<string>();
                    connectedSumHelper(node, visitedTemp, tempResult);
                    result.Add(tempResult);
                    visitedNodes.AddRange(visitedTemp);
                }
            }
            //parse the result and get the square root and ceil
            foreach(var r in result)
            {
                counter += r.Count;
                returnValue += (int)Math.Ceiling(Math.Sqrt(r.Count));
            }
            //calculate for the remaining nodes
            returnValue += (n - counter);
        }
        private static void connectedSumHelper(string node,List<string> visited,List<string> tempResult)
        {
            if(visited.Contains(node))
            {
                return;
            }
            visited.Add(node);
            tempResult.Add(node);
            if (adjacencyList.ContainsKey(node))
            {
                foreach (var neghibor in adjacencyList[node])
                {
                    connectedSumHelper(neghibor, visited,tempResult);
                }
            }
        }
        private static void BuildAdjacencyList(List<string> edges)
        {
            foreach(var edge in edges)
            {
                var e = edge.Split(" ");
                if(adjacencyList.ContainsKey(e[0]))
                {
                    adjacencyList[e[0]].Add(e[1]);
                }
                else
                {
                    adjacencyList.Add(e[0], new List<string>() { e[1] });
                }

                if (adjacencyList.ContainsKey(e[1]))
                {
                    adjacencyList[e[1]].Add(e[0]);
                }
                else
                {
                    adjacencyList.Add(e[1], new List<string>() { e[0] });
                }
            }
        }
    }
}
