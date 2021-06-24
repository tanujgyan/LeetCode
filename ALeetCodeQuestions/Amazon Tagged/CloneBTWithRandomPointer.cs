using System;
using System.Collections.Generic;
using System.Text;

namespace ALQ.Amazon_Tagged
{
    class CloneBTWithRandomPointer
    {
        //Dictionary<Node,NodeCopy>
        //public NodeCopy CreateCopy(Node node)
        //{
        //    if(node==null)
        //    {
        //        return null;
        //    }
        //}
    }
    class Node
    {
        int val;
        Node left;
        Node right;
        Node random;
        Node() { }
        public Node(int val) { this.Val = val; }
        public Node(int val, Node left, Node right, Node random)
        {
            this.Val = val;
            this.Left = left;
            this.Right = right;
            this.Random = random;
        }

        public int Val { get => val; set => val = value; }
        public Node Left { get => left; set => left = value; }
        internal Node Right { get => right; set => right = value; }
        internal Node Random { get => random; set => random = value; }
    }
    class NodeCopy
    {
        int val;
        NodeCopy left;
        NodeCopy right;
        NodeCopy random;
        public NodeCopy(int val) { this.Val = val; }

        public int Val { get => val; set => val = value; }
        internal NodeCopy Left { get => left; set => left = value; }
        internal NodeCopy Right { get => right; set => right = value; }
        internal NodeCopy Random { get => random; set => random = value; }
    }
}
