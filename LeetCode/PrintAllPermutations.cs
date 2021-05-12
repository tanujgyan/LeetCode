using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    class PrintAllPermutations
    {
        public void PrintPerm(string s)
        {
            int inputLength = s.Length;
            PrintPermHelper(s, 0, inputLength);
        } 
        public void PrintPermHelper(string s,  int l, int r)
        {
            {
                if (l == r)
                    Console.WriteLine(s);
                else
                {
                    for (int i = l; i < r; i++)
                    {
                        s = swapChars(s, l, i);
                        PrintPermHelper(s, l + 1, r);
                        s = swapChars(s, l, i);
                    }
                }

            }
        }
        private string swapChars(string s, int p1, int p2)
        {
            StringBuilder sb = new StringBuilder(s);
            char temp = sb[p1];
            sb[p1] = sb[p2];
            sb[p2] = temp;
            return sb.ToString();
        }


        public void PrintPermUsingHeap(string s,int size,int n)
        {
            if(size==1)
            {
                Console.WriteLine(s);
            }
            for(int i=0;i<size;i++)
            {
                PrintPermUsingHeap(s, size - 1, n);
                if(size%2==1) //odd size
                {
                    s = swapChars(s, 0, size - 1);
                }
                else
                {
                    s = swapChars(s, i, size - 1);
                }
            }
        }
    }
}
