using System;
using System.Collections.Generic;
using System.Text;

namespace Graphs
{
    class RouteBetweenTwoNodes
    {
        public static bool RouteExists(int source, int dest, int[][] graph)
        {
            Queue<int> q = new Queue<int>();
            List<int> visited = new List<int>();
            bool result = false;
            var ad = BuildAdjacencyList(graph);
            if (ad.ContainsKey(source))
            {
                q.Enqueue(source);
                visited.Add(source);
                while (q.Count > 0)
                {
                    var temp = q.Dequeue();
                    if (ad.ContainsKey(temp))
                    {
                        foreach (var neghibor in ad[temp])
                        {
                            if (neghibor == dest)
                            {
                                result = true;
                                break;
                            }
                            if (!visited.Contains(neghibor))
                            {
                                visited.Add(neghibor);
                                q.Enqueue(neghibor);
                            }
                        }
                        if (result)
                        {
                            break;
                        }
                    }
                }
            }
            return result;
        }
        private static Dictionary<int, List<int>> BuildAdjacencyList(int[][] graph)
        {
            Dictionary<int, List<int>> ad = new Dictionary<int, List<int>>();
            for (int i = 0; i < graph.Length; i++)
            {
                
                    if (!ad.ContainsKey(graph[i][0]))
                    {
                        ad.Add(graph[i][0], new List<int>() { graph[i][1]});
                    }
                    else
                    {
                        ad[graph[i][0]].Add(graph[i][1]);
                    }
                
            }
            return ad;
        }
    }
}
