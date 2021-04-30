using System;
using System.Collections.Generic;
using System.Text;

namespace Graphs
{
    /// <summary>
    /// https://leetcode.com/problems/find-the-town-judge/
    /// </summary>
    class TownJudge
    {
        public int FindJudge(int N, int[][] trust)
        {
            //declare and initialize adjacency list
            Dictionary<int, List<int>> adjacency = new Dictionary<int, List<int>>();
            int[] trustCounter = new int[N];
            bool[] visited = new bool[N];
            int judge = -1;

            for (int i = 0; i < N; i++)
            {
                adjacency.Add(i, new List<int>());
                trustCounter[i] = 0;
            }
            //fill up the list
            for (int i = 0; i < trust.Length; i++)
            {
                adjacency[trust[i][0] - 1].Add(trust[i][1] - 1);
            }
            //call DFS
            for (int i = 0; i < N; i++)
            {
                FindJudgeDFS(N, i, adjacency, visited, trustCounter);
            }

            //analyze visited array
            for (int i = 0; i < N; i++)
            {
                if (trustCounter[i] > N)
                {
                    return -1;
                }
                if (trustCounter[i] == N - 1)
                {
                    if (judge == -1)
                    {
                        //make sure the node we are going to assign as judge doesn't have any neghibors
                        if (adjacency[i].Count == 0)
                            judge = i + 1;
                    }
                    else
                    {
                        return -1;
                    }
                }
            }
            return judge;
        }
        public void FindJudgeDFS(int N, int node, Dictionary<int, List<int>> adjacency, bool[] visited, int[] trustCounter)
        {

            if (visited[node])
            {
                return;
            }
            //mark the main node as visited
            visited[node] = true;
            foreach (var neghibor in adjacency[node])
            {
                //mark the neghibor as visited
                visited[node] = true;
                //increase the trust counter for the neghibor
                trustCounter[neghibor]++;
                FindJudgeDFS(N, neghibor, adjacency, visited, trustCounter);
            }

        }
    }
}
