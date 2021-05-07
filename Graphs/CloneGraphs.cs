using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Graphs
{
    class CloneGraphs
    {
        public void CloneGraph(Node node)
        {
            Dictionary<int, Node> clonedGraph = new Dictionary<int, Node>();

            CloneGraphDFS(node, clonedGraph);

        }
        private Node CloneGraphDFS(Node node, Dictionary<int, Node> clonedGraph)
        {
            if (clonedGraph.ContainsKey(node.val))
                return clonedGraph[node.val];
            Node tempNode = new Node(node.val);
            clonedGraph.Add(node.val, tempNode);
            foreach (var neghibor in node.neighbors)
            {
                
                CloneGraphDFS(neghibor, clonedGraph);
            }
            return tempNode;

        }
    }
    public class Node
    {
        public int val;
        public IList<Node> neighbors;

        public Node()
        {
            val = 0;
            neighbors = new List<Node>();
        }

        public Node(int _val)
        {
            val = _val;
            neighbors = new List<Node>();
        }

        public Node(int _val, List<Node> _neighbors)
        {
            val = _val;
            neighbors = _neighbors;
        }
    }
}
