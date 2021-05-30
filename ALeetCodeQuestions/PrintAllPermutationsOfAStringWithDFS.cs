using System;
using System.Collections.Generic;
using System.Text;

namespace ALQ
{
    class PrintAllPermutationsOfAStringWithDFS
    {
        public void PrintAllPermutationsOfAStringWithDFSMethod(string s)
        {
            bool[] visited = new bool[s.Length];
            PrintAllPermutationsOfAStringWithDFSMethodHelper(s, new StringBuilder(), -1,visited);
        }
        private void PrintAllPermutationsOfAStringWithDFSMethodHelper(string s, StringBuilder sb, int index,bool[] visited)
        {
            if(index==s.Length-1)
            {
                Console.WriteLine(sb.ToString());
                return;
            }
            
            for(int i=0;i<s.Length;i++)
            {
                if (!visited[i])
                {
                    sb.Append(s[i]);
                    index++;
                    visited[i] = true;
                    PrintAllPermutationsOfAStringWithDFSMethodHelper(s, sb, index, visited);
                    visited[i] = false;
                    index--;
                    sb.Remove(sb.Length - 1, 1);
                }
            }
        }
    }
}
