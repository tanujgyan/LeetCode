using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ALQ
{
    class CourseSchedule2
    {
        Dictionary<int, List<int>> adjacencyList = new Dictionary<int, List<int>>();
        Dictionary<int, char> colorCoding = new Dictionary<int, char>();
        List<int> topologicallySortedCourses = new List<int>();
        bool cycleDetected = false;
        public int[] FindOrder(int numCourses, int[][] prerequisites)
        {
            BuildAdjacencyList(prerequisites);
            //initially mark all nodes as White
            InitializeColorCoding(numCourses);

            foreach(var element in adjacencyList)
            {
                if(colorCoding[element.Key]=='W')
                {
                    FindOrderHelper(element.Key);
                }
            }
            if(!cycleDetected)
            {
                return topologicallySortedCourses.ToArray();
            }
            return new int[0];
        }
        private void FindOrderHelper(int node)
        {
            if(cycleDetected)
            {
                return;
            }
            colorCoding[node] = 'G';
            if (adjacencyList.ContainsKey(node))
            {
                foreach (var neghibor in adjacencyList[node])
                {
                    if (colorCoding[neghibor] == 'W')
                    {
                        FindOrderHelper(neghibor);
                    }
                    else if (colorCoding[neghibor] == 'G')
                    {
                        cycleDetected = true;
                    }
                }
            }
            colorCoding[node] = 'B';
            topologicallySortedCourses.Add(node);
        }
        private void BuildAdjacencyList(int[][] prerequisites)
        {
            for(int i=0;i<prerequisites.Length;i++)
            {
                if(!adjacencyList.ContainsKey(prerequisites[i][0]))
                {
                    adjacencyList.Add(prerequisites[i][0], new List<int>() { prerequisites[i][1] });
                }
                else
                {
                    adjacencyList[prerequisites[i][0]].Add(prerequisites[i][1]);
                }
            }
        }
        private void InitializeColorCoding(int numCourses)
        {
            for(int i=0;i<numCourses;i++)
            {
                colorCoding.Add(i, 'W');
            }
        }
    }
}
