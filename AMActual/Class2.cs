using System;
using System.Collections.Generic;
using System.Text;

namespace AMActual
{
    class Class2
    {
        static Dictionary<int, List<int>> adjacencyList = new Dictionary<int, List<int>>();
        static List<List<int>> result = new List<List<int>>();
        public static int countGroups(List<string> related)
        {
            List<int> visitedNodes = new List<int>();
            int numberOfPeople = related[0].Length;
            BuildAdjacencyList(related);
            int counter = 0;
            foreach (var node in adjacencyList.Keys)
            {
                if (!visitedNodes.Contains(node))
                {
                    List<int> tempResult = new List<int>();
                    List<int> visitedTemp = new List<int>();
                    countGroupsHelper(node, visitedTemp, tempResult);
                    result.Add(tempResult);
                    visitedNodes.AddRange(visitedTemp);
                }
            }
            foreach (var r in result)
            {
                counter += r.Count;
            }
            int peopleWithoutGroups = numberOfPeople - counter;
            int totalGroups = result.Count + peopleWithoutGroups;
            return totalGroups;
        }
        private static void countGroupsHelper(int node, List<int> visited, List<int> tempResult)
        {
            if (visited.Contains(node))
            {
                return;
            }
            visited.Add(node);
            tempResult.Add(node);
            if (adjacencyList.ContainsKey(node))
            {
                foreach (var neghibor in adjacencyList[node])
                {
                    countGroupsHelper(neghibor, visited, tempResult);
                }
            }

        }
        private static void BuildAdjacencyList(List<string> edges)
        {
            int counter = 0;
            foreach (var edge in edges)
            {
                
                for (int i = counter; i < edge.Length; i++)
                {
                    if (i != counter && edge[i] == '1' && !adjacencyList.ContainsKey(counter))
                    {
                        adjacencyList.Add(counter, new List<int>() { i });
                    }
                    else if (i != counter && edge[i] == '1' && adjacencyList.ContainsKey(counter))
                    {
                        adjacencyList[counter].Add(i);
                    }
                }
                counter++;
            }
        }
    }
}
