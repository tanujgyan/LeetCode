using System;
using System.Collections.Generic;
using System.Text;
using HeapImplementation;

namespace LeetCode
{
    class HeapOperations
    {
        public void HeapOperationsMethod()
        {
            MinHeap minHeap = new MinHeap();
            minHeap.Add(4);
            minHeap.Add(2);
            minHeap.Add(1);
            while(minHeap.Count>0)
            {
                Console.WriteLine(minHeap.Pop());
            }
        }
    }
}
